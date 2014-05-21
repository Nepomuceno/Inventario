using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using Newtonsoft.Json;
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
            lblOperador.Text += string.Format("{0} - {1}", Program.Operador.Codigo, Program.Operador.Nome);
            btnExcluir.Enabled = Program.Operador.TipoUsuario != TipoUsuario.Operador;
            btnExcluirTodos.Visible = Program.Operador.TipoUsuario != TipoUsuario.Operador;
        }

        
        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            _formAntigo.Show();
            Close();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            var deposito = new ViewDeposito(this,cbInventarios.SelectedItem as Inventario);
            SystemSounds.Beep.Play();
            deposito.Show();

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            var inventario = cbInventarios.SelectedItem as Inventario;
            if (inventario != null)
            {
                try
                {
                    using (var service = new SiriusService.SiriusService())
                    {
                        inventario.StatusInventario = StatusExecucao.Finalizado;
                        int importarResultado;
                        bool sucesso;
                        service.ImportarInventario(JsonConvert.SerializeObject(inventario), out importarResultado, out sucesso);
                        SystemSounds.Beep.Play();
                        MessageBox.Show(importarResultado == 1 ? "finalizado com sucesso" : "Nao foi possivel finalizar o inventario");
                        if (importarResultado == 1)
                        {
                            Program.Banco.Inventarios.Remove(inventario);
                            cbInventarios.DataSource = Program.Banco.Inventarios;
                        }
                    }
                }
                catch
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("Não foi possivel finalizar este inventario favor entrar em contato");
                }
                
            }
            else
            {
                MessageBox.Show("Nenhuminventario selecionado ");
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Program.StartWaiting(this);
            var inventario = cbInventarios.SelectedItem as Inventario;
            try
            {
                try
                {
                    using (var service = new SiriusService.SiriusService())
                    {
                        int importarResultado;
                        bool sucesso;
                        service.ImportarInventario(JsonConvert.SerializeObject(inventario), out importarResultado, out sucesso);
                        SystemSounds.Beep.Play();
                        MessageBox.Show(importarResultado == 1 ? "Enviado com sucesso" : "Nao foi possivel enviar o inventario");
                    }
                }
                catch 
                {
                    SystemSounds.Exclamation.Play();
                    MessageBox.Show("Não foi possivel enviar este inventario favor entrar em contato");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nao foi possivel enviar o inventario");
            }
            Program.StopWaiting(this);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var inventario = cbInventarios.SelectedItem as Inventario;
            if (inventario != null)
            {
                try
                {
                    Program.Banco.Inventarios.Remove(Program.Banco.Inventarios.Single(i => i.Codigo == inventario.Codigo));
                    Program.Banco.SalvarInventarios(Program.Caminho);
                    SystemSounds.Beep.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel excluir este inventario");
                }
            }
        }

        private void btnExcluirTodos_Click(object sender, EventArgs e)
        {
            var inventario = cbInventarios.SelectedItem as Inventario;
            if (inventario != null)
            {
                var confirmResult = MessageBox.Show("Tem certeza que deseja excluir todos os inventarios ?","Confirmar exclusão!!",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        Program.Banco.Inventarios.Clear();
                        Program.Banco.SalvarInventarios(Program.Caminho);
                        SystemSounds.Beep.Play();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possivel excluir estes inventarios");
                    }
                }
                
            }
        }

    }
}