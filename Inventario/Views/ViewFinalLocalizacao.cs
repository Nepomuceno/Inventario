using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class ViewFinalLocalizacao : Form
    {
        private readonly Form _formAntigo;
        private readonly Inventario _inventario;
        private readonly Localizacao _localizacao;
        private readonly Deposito _deposito;
        private readonly LocalizacaoInventario _localizacaoInventario;
        private Leitura _leitura;
        private readonly Produto _produto;
        private BarcodeReader _reader;

        public ViewFinalLocalizacao(Form formAntigo, Inventario inventario, Localizacao localizacao, Deposito deposito, LocalizacaoInventario localizacaoInventario)
        {
            _formAntigo = formAntigo;
            _inventario = inventario;
            _localizacao = localizacao;
            _deposito = deposito;
            _localizacaoInventario = localizacaoInventario;
            InitializeComponent();
            InicializarLabels();
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _formAntigo.Show();
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            _localizacaoInventario.DatFim = DateTime.Now;
            
        }

        private void InicializarLabels()
        {
            lblOperador.Text += Program.Operador.Codigo.ToString();
            lblFilial.Text += _inventario.Filial.Codigo.ToString();
            lblInventario.Text += string.Format("{0} / {1}", _inventario.Codigo, _inventario.CodigoContagem);
            lblDeposito.Text += _deposito.Codigo.ToString();
            lblLocalizacao.Text += _localizacao.Codigo.ToString();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            _localizacaoInventario.InformacaoAdicional = tbInfoAdicional.Text;
            _inventario.LocalizacoesInventario.Add(_localizacaoInventario);
        }

        

    }
}