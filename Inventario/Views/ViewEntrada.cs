using System.Media;
using System.Windows.Forms;
using Sirius.Coletor.Base;

namespace Sirius.Coletor.Views
{
    public partial class ViewEntrada : Form
    {
        private readonly Form _formAntigo;

        public ViewEntrada(Form formAntigo)
        {
            _formAntigo = formAntigo;
            InitializeComponent();
            btnParametros.Visible = Program.Operador.TipoUsuario == TipoUsuario.Supervisor;
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            _formAntigo.Show();
            SystemSounds.Beep.Play();
            Close();
        }

        private void btnParametros_Click(object sender, System.EventArgs e)
        {
            var parametros = new ViewParametros(this);
            SystemSounds.Beep.Play();
            parametros.Show();
        }

        private void btnInventario_Click(object sender, System.EventArgs e)
        {
            var inventario = new ViewInventario(this);
            SystemSounds.Beep.Play();
            inventario.Show();
        }

        private void btnImportacao_Click(object sender, System.EventArgs e)
        {
            var importacao = new ViewImportacao(this);
            SystemSounds.Beep.Play();
            importacao.Show();
        }

        private void btnMetricas_Click(object sender, System.EventArgs e)
        {
            var metricas = new ViewMetricas(this);
            SystemSounds.Beep.Play();
            metricas.Show();
        }
    }
}