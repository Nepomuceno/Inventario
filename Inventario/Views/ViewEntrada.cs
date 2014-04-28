using System.Windows.Forms;

namespace Sirius.Coletor.Views
{
    public partial class ViewEntrada : Form
    {
        private readonly Form _formAntigo;

        public ViewEntrada(Form formAntigo)
        {
            _formAntigo = formAntigo;
            InitializeComponent();
        }

        private void btnInventario_Click(object sender, System.EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            _formAntigo.Show();
            Close();
        }
    }
}