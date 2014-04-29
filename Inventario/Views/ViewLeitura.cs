using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Sirius.Coletor.Base;
using Sirius.Coletor.Dados;
using System;

namespace Sirius.Coletor.Views
{
    public partial class ViewLeitura : Form
    {
        private readonly Form _formAntigo;
        private readonly Leitura _leitura;

        public ViewLeitura(Form formAntigo, Leitura leitura)
        {
            _formAntigo = formAntigo;
            _leitura = leitura;

            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            _formAntigo.Show();
            Close();
        }


    }
}