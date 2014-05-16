using System.Windows.Forms;
using Sirius.Coletor.Base;

namespace Sirius.Coletor.Views
{
    public partial class ViewImportacao : Form
    {
        private readonly Form _formAntigo;

        public ViewImportacao(Form formAntigo)
        {
            _formAntigo = formAntigo;
            InitializeComponent();
            btnOperadores.Visible = Program.Operador.TipoUsuario == TipoUsuario.Administrador;
        }

        private void btnInventario_Click(object sender, System.EventArgs e)
        {
            Program.StartWaiting(this);
            Program.Banco.ImportarDados(true,false,false,false);
            Program.Banco.SalvarInventarios(Program.Caminho);
            Program.StopWaiting(this);
        }

        private void btnOperadores_Click(object sender, System.EventArgs e)
        {
            Program.StartWaiting(this);
            Program.Banco.ImportarDados(false,true, false, false);
            Program.Banco.SalvarOperadores(Program.Caminho);
            Program.StopWaiting(this);
        }
        private void btnFiliais_Click(object sender, System.EventArgs e)
        {
            Program.StartWaiting(this);
            Program.Banco.ImportarDados(false, false, true, false);
            Program.Banco.SalvarFiliais(Program.Caminho);
            Program.StopWaiting(this);
        }

        private void btnProdutos_Click(object sender, System.EventArgs e)
        {
            Program.StartWaiting(this);
            Program.Banco.ImportarDados(false, false, false, true);
            Program.Banco.SalvarProdutos(Program.Caminho);
            Program.StopWaiting(this);
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            _formAntigo.Show();
            Close();
        }
        
    }
}