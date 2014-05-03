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
        }

        
        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            _formAntigo.Show();
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //var leituras = new ViewLeituras(this, _inventarioCorrente, _deposito, cbLocalizacoes.SelectedItem as Localizacao);
            //leituras.Show();
        }

    }
}