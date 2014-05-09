using System;
using System.ComponentModel;
using System.Linq;
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
            Program.Banco.SalvarTudo(Program.Caminho);
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            var operador =
                Program.Banco.Operadores.FirstOrDefault(
                    o => o.Nome.Equals(tbUsuario.Text, StringComparison.InvariantCultureIgnoreCase));

            if (operador != null)
            {
                Program.Operador = operador;
                var entrada = new ViewEntrada(this);
                entrada.Show();    
            }
            else
            {
                MessageBox.Show("Usuario ou senha invalidos");
            }
            
            
        }

        
    }
}