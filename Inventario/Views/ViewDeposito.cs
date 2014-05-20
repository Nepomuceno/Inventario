using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using Sirius.Coletor.Base;
using Sirius.Coletor.Dados;
using System;

namespace Sirius.Coletor.Views
{
    public partial class ViewDeposito : Form
    {
        private readonly Form _formAntigo;
        private readonly Inventario _inventarioCorrente;

        public ViewDeposito(Form formAntigo, Inventario inventarioCorrente)
        {
            _formAntigo = formAntigo;
            _inventarioCorrente = inventarioCorrente;
            InitializeComponent();
            cbDepositos.DisplayMember = "Nome";
            var depositos = Program.Banco.Filiais.
                FirstOrDefault(f => f.Codigo == _inventarioCorrente.Filial.Codigo).Depositos;
            cbDepositos.DataSource =  depositos;
            InicializaLabels();
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            _formAntigo.Show();
            Close();
        }
        private void InicializaLabels()
        {
            lblOperador.Text += string.Format("{0} - {1}", Program.Operador.Codigo,Program.Operador.Nome);
            lblInventario.Text += _inventarioCorrente.Codigo.ToString();
            lblContagem.Text += _inventarioCorrente.CodigoContagem.ToString();
            lblFilial.Text += string.Format("{0}",_inventarioCorrente.Filial.Nome);
        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (Program.Banco.ParametrosDeInicializacao.LeituraLocalAposCadaItem)
            {
                //var leituras = new ViewLeituras(this, _inventarioCorrente, cbDepositos.SelectedItem as Deposito);
                //leituras.Show();
            }
            else
            {
                var local = new ViewLocal(this, _inventarioCorrente, cbDepositos.SelectedItem as Deposito);
                SystemSounds.Beep.Play();
                local.Show();
            }
        }
    }
}