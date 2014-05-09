using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Sirius.Coletor.Base;
using Sirius.Coletor.Dados;
using System;
using Sirius.Coletor.Util;

namespace Sirius.Coletor.Views
{
    public partial class ViewParametros : Form
    {
        private readonly Form _formAntigo;

        public ViewParametros(Form formAntigo)
        {
            _formAntigo = formAntigo;
            InitializeComponent();
        }

  

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            _formAntigo.Show();
            Close();
        }

        private void btnGerarDadosDemo_Click(object sender, System.EventArgs e)
        {
            DadosDeDemonstracao();
        }

        private void DadosDeDemonstracao()
        {
            Demonstracao.PreencheDadosDemonstracao();
        }
    }
}