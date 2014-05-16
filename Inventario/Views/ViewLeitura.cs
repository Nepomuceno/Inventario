﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Sirius.Coletor.Base;
using Sirius.Coletor.Base.Extensions;
using Sirius.Coletor.Dados;
using System;
using Symbol.Barcode;

namespace Sirius.Coletor.Views
{
    public partial class ViewLeitura : Form
    {
        private readonly Form _formAntigo;
        private readonly Inventario _inventario;
        private readonly Localizacao _localizacao;
        private readonly Deposito _deposito;
        private readonly LocalizacaoInventario _localizacaoInventario;
        private Leitura _leitura;
        private static readonly Regex DigitsOnly = new Regex(@"[^\d]");
        private BarcodeReader _reader;

        public ViewLeitura(Form formAntigo, Inventario inventario, Localizacao localizacao, Deposito deposito)
        {
            _formAntigo = formAntigo;
            _inventario = inventario;
            _localizacao = localizacao;
            _deposito = deposito;
            _localizacaoInventario = new LocalizacaoInventario()
            {
                CodigoLocalizacao = localizacao.Codigo,
                DataInicio = DateTime.Now,
                Leituras = new Colecao<Leitura>()
            };
            InitializeComponent();
            tbProduto.Enabled = true;
            InicializarLabels();
            InicializarLeitor();
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
                    BuscaProduto(readertext);
                }
            };
        }

        private void BuscaProduto(string readertext)
        {
            var produto = Program.Banco.Produtos.FirstOrDefault(p => p.EANS.Any(e => e == readertext));
            if (produto == null)
            {
                MessageBox.Show("Este produto não foi encontrado.");
            }
            else
            {
                if (_leitura != null && _leitura.CodigoProduto == produto.Codigo)
                {
                    _leitura.DataDeLeitura = DateTime.Now;
                    var quantidade = int.Parse(tbQuantidade.Text) + 1;
                    tbQuantidade.Text = quantidade.ToString(CultureInfo.InvariantCulture);
                    _leitura.Quantidade = quantidade;
                }
                else
                {
                    _leitura = new Leitura()
                    {
                        CodigoLocalizacao = _localizacao == null ? 0 : _localizacao.Codigo,
                        CodigoOperador = Program.Operador.Codigo,
                        CodigoProduto = produto.Codigo,
                        DataDeLeitura = DateTime.Now,
                        Quantidade = 1,
                        TipoLeitura = produto.TipoLeitura
                    };
                    tbProduto.Text = produto.Codigo.ToString(CultureInfo.InvariantCulture);
                    tbProduto.Enabled = false;
                    lblProdutoDescricao.Text = produto.Descricao;
                    tbQuantidade.Text = "1";
                    tbQuantidade.Enabled = _leitura.TipoLeitura != TipoLeitura.Unica;
                }
                tbQuantidade.Focus();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var vwFinalizacao =
                new ViewFinalLocalizacao(_formAntigo, _inventario, _localizacao, _deposito, _localizacaoInventario);
            tbProduto.Enabled = true;
            tbProduto.Text = string.Empty;
            tbQuantidade.Text = string.Empty;
            tbQuantidade.Enabled = false;
            vwFinalizacao.Show();
            _reader.Dispose();
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarLeitura();
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

        private void SalvarLeitura()
        {
            if (string.IsNullOrEmpty(tbQuantidade.Text))
                return;

            _leitura.Quantidade = int.Parse(tbQuantidade.Text);
            tbProduto.Text = string.Empty;
            lblProduto.Text = string.Empty;
            tbQuantidade.Text = string.Empty;
            tbQuantidade.Enabled = false;
            lblProdutoDescricao.Text = string.Empty;
            _localizacaoInventario.Leituras.Add(_leitura);
            _leitura = null;
        }

        private void tbQuantidade_TextChanged(object sender, EventArgs e)
        {
            tbQuantidade.Text = DigitsOnly.Replace(tbQuantidade.Text, "");
        }

        private void InicializarLabels()
        {
            lblOperador.Text += Program.Operador.Codigo.ToString(CultureInfo.InvariantCulture);
            lblFilial.Text += _inventario.Filial.Codigo.ToString(CultureInfo.InvariantCulture);
            lblInventario.Text += string.Format("{0} / {1}", _inventario.Codigo, _inventario.CodigoContagem);
            lblDeposito.Text += _deposito.Codigo.ToString(CultureInfo.InvariantCulture);
            lblLocalizacao.Text += _localizacao.Codigo.ToString(CultureInfo.InvariantCulture);
            tbQuantidade.Enabled = false;
        }

        private void tbQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                SalvarLeitura();
            }
        }

        private void tbProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                BuscaProduto(tbProduto.Text);
            }
        }
    }
}