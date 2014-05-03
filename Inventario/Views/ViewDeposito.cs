using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Sirius.Coletor.Base;
using Sirius.Coletor.Dados;
using System;

namespace Sirius.Coletor.Views
{
    public partial class ViewDeposito : Form
    {
        private readonly Form _formAntigo;
        private readonly Inventario _inventarioCorrente;

        public ViewDeposito(Form formAntigo, Inventario inventarioCorrente)
        {
            _formAntigo = formAntigo;
            _inventarioCorrente = inventarioCorrente;
            InitializeComponent();
            cbDepositos.DisplayMember = "Nome";
            cbDepositos.DataSource = _inventarioCorrente.Filial.Depositos;
        }

        private void btnInventario_Click(object sender, System.EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            _formAntigo.Show();
            Close();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (Program.Banco.ParametrosDeInicializacao.LeituraLocalAposCadaItem)
            {
                //var leituras = new ViewLeituras(this, _inventarioCorrente, cbDepositos.SelectedItem as Deposito);
                //leituras.Show();
            }
            else
            {
                var local = new ViewLocal(this, _inventarioCorrente, cbDepositos.SelectedItem as Deposito);
                local.Show();
            }
        }
    }
}