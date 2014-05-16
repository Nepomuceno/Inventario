using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Sirius.Coletor.Base;
using Sirius.Coletor.Dados;
using System;
using Symbol.Barcode;

namespace Sirius.Coletor.Views
{
    public partial class ViewLocal : Form
    {
        private readonly Form _formAntigo;
        private readonly Inventario _inventarioCorrente;
        private readonly Deposito _deposito;
        private BarcodeReader _reader;

        public ViewLocal(Form formAntigo, Inventario inventarioCorrente, Deposito deposito)
        {
            _formAntigo = formAntigo;
            _inventarioCorrente = inventarioCorrente;
            _deposito = deposito;
            InitializeComponent();
            cbLocalizacoes.DisplayMember = "Nome";
            cbLocalizacoes.DataSource = deposito.Localizacoes;
            InicializaLabels();
            InicializarLeitor();
        }

        
        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            _formAntigo.Show();
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var leituras = new ViewLeitura(this, _inventarioCorrente, cbLocalizacoes.SelectedItem as Localizacao, _deposito);
            _reader.Dispose();
            _reader = null;
            leituras.Show();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            if (_reader == null)
            {
                InicializarLeitor();
            }
            base.OnGotFocus(e);
        }

        private void InicializaLabels()
        {
            lblOperador.Text += string.Format("{0} - {1}", Program.Operador.Codigo,Program.Operador.Nome);
            lblInventario.Text += _inventarioCorrente.Codigo.ToString();
            lblContagem.Text += _inventarioCorrente.CodigoContagem.ToString();
            lblFilial.Text += string.Format("{0}",_inventarioCorrente.Filial.Nome);
            lblDeposito.Text += string.Format("{0} - {1}", _deposito.Codigo, _deposito.Nome);

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (_reader != null)
            {
                _reader.Dispose();
                _reader = null;
            }
            base.OnClosing(e);
        }

        private void InicializarLeitor()
        {
            _reader = new BarcodeReader();
            _reader.Start();
            _reader.ListChanged += (sender, args) =>
            {
                if (args.ListChangedType == ListChangedType.ItemAdded)
                {
                    var readertext = ((BarcodeReader)sender).ReaderData.Text;
                    try
                    {
                        var localizacao = _deposito.Localizacoes.FirstOrDefault(l => l.Codigo == int.Parse(readertext));
                        if (localizacao != null)
                        {
                            _reader.Dispose();
                            var leituras = new ViewLeitura(this, _inventarioCorrente,
                                cbLocalizacoes.SelectedItem as Localizacao, _deposito);
                            leituras.Show();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel localizar essa localização");
                        }
                        
                    }
                    catch
                    {
                        
                    }
                    
                }
            };
        }

    }
}