using System.Collections.Generic;
using System.Linq;
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
        }

        
        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            _formAntigo.Show();
            Close();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            var deposito = new ViewDeposito(this,cbInventarios.SelectedItem as Inventario);
            deposito.Show();

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            var inventario = cbInventarios.SelectedItem as Inventario;
            if (inventario != null)
            {
                using (var service = new SiriusService.SiriusService())
                {
                    inventario.StatusInventario = StatusExecucao.Finalizado;
                    int importarResultado;
                    bool sucesso;
                    service.ImportarInventario(JsonConvert.SerializeObject(inventario), out importarResultado, out sucesso);
                    MessageBox.Show(importarResultado == 1 ? "finalizado com sucesso" : "Nao foi possivel finalizar o inventario");
                    if (importarResultado == 1)
                    {
                        Program.Banco.Inventarios.Remove(inventario);
                        cbInventarios.DataSource = Program.Banco.Inventarios;
                    }
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
                using (var service = new SiriusService.SiriusService())
                {
                    int importarResultado;
                    bool sucesso;
                    service.ImportarInventario(JsonConvert.SerializeObject(inventario), out importarResultado, out sucesso);
                    MessageBox.Show(importarResultado == 1 ? "Enviado com sucesso" : "Nao foi possivel enviar o inventario");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nao foi possivel enviar o inventario");
            }
            Program.StopWaiting(this);
        }

    }
}