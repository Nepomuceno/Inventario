using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Sirius.Coletor.Base;
using Sirius.Coletor.Dados;
using System;
using Sirius.Coletor.VewModel;
using Symbol.Barcode;

namespace Sirius.Coletor.Views
{
    public partial class ViewLeituras : Form
    {
        private readonly Form _formAntigo;
        private readonly Inventario _inventarioCorrente;
        private readonly Deposito _deposito;
        private readonly Localizacao _localizacao;
        private BarcodeReader _reader;

        public ViewLeituras(Form formAntigo, Inventario inventarioCorrente, Deposito deposito)
        {
            _formAntigo = formAntigo;
            _inventarioCorrente = inventarioCorrente;
            _deposito = deposito;
            Inicializar();


        }


        public ViewLeituras(Form formAntigo, Inventario inventarioCorrente,Deposito deposito, Localizacao localizacao)
        {
            _formAntigo = formAntigo;
            _inventarioCorrente = inventarioCorrente;
            _deposito = deposito;
            _localizacao = localizacao;
            Inicializar();
        }


        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            _formAntigo.Show();
            Close();
        }

        
        private void Inicializar()
        {
            InitializeComponent();
            _reader = new BarcodeReader();
            _reader.Start();
            leituraBindingSource.ListChanged += leituraBindingSource_ListChanged;
            _reader.ListChanged += (sender, args) =>
            {
                if (args.ListChangedType == ListChangedType.ItemAdded)
                {
                    var readertext = ((BarcodeReader)sender).ReaderData.Text;
                    var produto = Program.Banco.Produtos.FirstOrDefault(p => p.EANS.Any(e => e == readertext));
                    if (produto == null)
                    {
                        MessageBox.Show("Este produto não foi encontrado.");
                    }
                    else
                    {
                        var leitura = new Leitura()
                        {
                            CodigoLocalizacao = _localizacao == null ? 0 : _localizacao.Codigo,
                            CodigoOperador = Program.Operador.Codigo,
                            CodigoProduto = produto.Codigo,
                            DataDeLeitura = DateTime.Now,
                            Quantidade = 1,
                            TipoLeitura = produto.TipoLeitura
                        };
                        

                        _inventarioCorrente.Leituras.Add(leitura);
                        if (leitura.TipoLeitura == TipoLeitura.Multipla)
                        {
                            var viewLeitura = new ViewLeitura(this, ref leitura);
                            viewLeitura.Show();
                        }
                        
                    }
                }
                RefreshLeituras();
            };
            RefreshLeituras();
        }

        private void RefreshLeituras()
        {
            leituraBindingSource.DataSource = _inventarioCorrente.Leituras;
            dgLeituras.DataSource = leituraBindingSource;
            dgLeituras.Refresh();
        }

        void leituraBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            Console.WriteLine("Lista alterada");
        }

        private void ViewLeituras_GotFocus(object sender, EventArgs e)
        {
            Inicializar();
        }

        



    }
}