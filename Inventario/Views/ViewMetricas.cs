using System.Windows.Forms;
using Sirius.Coletor.Base;

namespace Sirius.Coletor.Views
{
    public partial class ViewMetricas : Form
    {
        private readonly Form _formAntigo;

        public ViewMetricas(Form formAntigo)
        {
            _formAntigo = formAntigo;
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            _formAntigo.Show();
            Close();
        }
        
    }
}