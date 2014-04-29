using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Sirius.Coletor.Base;
using Sirius.Coletor.Dados;
using System;

namespace Sirius.Coletor.Views
{
    public partial class ViewInventario : Form
    {
        private readonly Form _formAntigo;

        public ViewInventario(Form formAntigo)
        {
            _formAntigo = formAntigo;
            InitializeComponent();
            cbInventarios.DisplayMember = "Nome";
            cbInventarios.DataSource = Program.Banco.Inventarios;
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
            var deposito = new ViewDeposito(this,cbInventarios.SelectedItem as Inventario);
            deposito.Show();

        }

    }
}