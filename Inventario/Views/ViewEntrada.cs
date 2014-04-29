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
            var inventario = new ViewInventario(this);
            inventario.Show();
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            _formAntigo.Show();
            Close();
        }

        private void btnParametros_Click(object sender, System.EventArgs e)
        {
            var parametros = new ViewParametros(this);
            parametros.Show();
        }
    }
}