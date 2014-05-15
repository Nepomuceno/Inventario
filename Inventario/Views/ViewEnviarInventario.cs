using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Sirius.Coletor.Base;
using Sirius.Coletor.Dados;
using System;
using Newtonsoft.Json;

namespace Sirius.Coletor.Views
{
    public partial class ViewEnviarInventario : Form
    {
        private readonly Form _formAntigo;

        public ViewEnviarInventario(Form formAntigo)
        {
            _formAntigo = formAntigo;
            InitializeComponent();
            cbInventarios.DisplayMember = "Nome";
            cbInventarios.DataSource = Program.Banco.Inventarios;
        }

        private void btnInventario_Click(object sender, System.EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            _formAntigo.Show();
            Close();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            var inventario = cbInventarios.SelectedItem as Inventario;
            bool sucesso;
            int importarResultado;
            using(var service = new SiriusService.SiriusService())
            {
               service.ImportarInventario(JsonConvert.SerializeObject(inventario),out importarResultado,out sucesso);
               if(importarResultado == 1)
               {
                   MessageBox.Show("Enviado com sucesso");
               }else
               {
                   MessageBox.Show("Nao foi possivel enviar o inventario");
               }
            }
        }

    }
}