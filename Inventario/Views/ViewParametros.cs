using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Sirius.Coletor.Base;
using Sirius.Coletor.Dados;
using System;
using Sirius.Coletor.Util;

namespace Sirius.Coletor.Views
{
    public partial class ViewParametros : Form
    {
        private readonly Form _formAntigo;

        public ViewParametros(Form formAntigo)
        {
            _formAntigo = formAntigo;
            InitializeComponent();
            tbCaminhoDados.Text = Program.Caminho;
            tbCodigoDispositivo.Text = DeviceId.GetDeviceID();
            cbContagemNaoCadastrado.Checked = Program.Banco.ParametrosDeInicializacao.LeituraDeProdutoNaoCadastrado;
            cbQuantidade.Checked = Program.Banco.ParametrosDeInicializacao.TipoLeitura != TipoLeitura.Unica;
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            _formAntigo.Show();
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var parametros = Program.Banco.ParametrosDeInicializacao;
            parametros.LeituraDeProdutoNaoCadastrado = cbContagemNaoCadastrado.Checked;
            parametros.LeituraLocalAposCadaItem = cbUmaLeituraPorLocalizacao.Checked;
            parametros.TipoLeitura = cbQuantidade.Checked ? TipoLeitura.Multipla : TipoLeitura.Unica;
            Program.Banco.ParametrosDeInicializacao = parametros;
            Program.Banco.SalvarParametros(Program.Caminho);
        }
    }
}