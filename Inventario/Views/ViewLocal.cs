using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Sirius.Coletor.Base;
using Sirius.Coletor.Dados;
using System;

namespace Sirius.Coletor.Views
{
    public partial class ViewLocal : Form
    {
        private readonly Form _formAntigo;
        private readonly Inventario _inventarioCorrente;
        private readonly Deposito _deposito;

        public ViewLocal(Form formAntigo, Inventario inventarioCorrente, Deposito deposito)
        {
            _formAntigo = formAntigo;
            _inventarioCorrente = inventarioCorrente;
            _deposito = deposito;
            InitializeComponent();
            cbLocalizacoes.DisplayMember = "Nome";
            cbLocalizacoes.DataSource = deposito.Localizacoes;
            InicializaLabels();
        }

        
        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            _formAntigo.Show();
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var leituras = new ViewLeitura(this, _inventarioCorrente, cbLocalizacoes.SelectedItem as Localizacao, _deposito);
            leituras.Show();
        }

        private void InicializaLabels()
        {
            lblOperador.Text += string.Format("{0} - {1}", Program.Operador.Codigo,Program.Operador.Nome);
            lblInventario.Text += _inventarioCorrente.Codigo.ToString();
            lblContagem.Text += _inventarioCorrente.CodigoContagem.ToString();
            lblFilial.Text += string.Format("{0} - {1}", _inventarioCorrente.Filial.Codigo,
                _inventarioCorrente.Filial.Nome);
            lblDeposito.Text += string.Format("{0} - {1}", _deposito.Codigo, _deposito.Nome);

        }

    }
}