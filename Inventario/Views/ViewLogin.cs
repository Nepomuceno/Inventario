using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Windows.Forms;
using Sirius.Coletor.Dados;
using Symbol.Barcode;

namespace Sirius.Coletor.Views
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            lblVersao.Text += Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Program.StartWaiting(this);
            Program.Banco.SalvarTudo(Program.Caminho);
            Program.StopWaiting(this);
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            LoginUsuario();
        }

        private void LoginUsuario()
        {
            var operador = Program.Banco.Operadores.FirstOrDefault(
                o => (o.Nome.Equals(tbUsuario.Text, StringComparison.InvariantCultureIgnoreCase) ||
                      o.Codigo.ToString(CultureInfo.InvariantCulture)
                          .Equals(tbUsuario.Text, StringComparison.InvariantCultureIgnoreCase))
                     && o.Senha.Equals(tbSenha.Text, StringComparison.InvariantCultureIgnoreCase));
            SystemSounds.Beep.Play();
            if (operador != null)
            {
                Program.Operador = operador;
                var entrada = new ViewEntrada(this);
                entrada.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario ou senha invalidos");
            }
        }

        private void tbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                LoginUsuario();
            }
        }

        private void tbSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                LoginUsuario();
            }
        }


    }
}