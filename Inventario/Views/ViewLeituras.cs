using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Sirius.Coletor.Base;
using Sirius.Coletor.Dados;
using System;

namespace Sirius.Coletor.Views
{
    public partial class ViewLeituras : Form
    {
        private readonly Form _formAntigo;
        private readonly Inventario _inventarioCorrente;
        private readonly Deposito _deposito;
        private readonly Localizacao _localizacao;

        public ViewLeituras(Form formAntigo, Inventario inventarioCorrente, Deposito deposito)
        {
            _formAntigo = formAntigo;
            _inventarioCorrente = inventarioCorrente;
            _deposito = deposito;
            Inicializar();
        }


        public ViewLeituras(Form formAntigo, Inventario inventarioCorrente,Deposito deposito, Localizacao localizacao)
        {
            _formAntigo = formAntigo;
            _inventarioCorrente = inventarioCorrente;
            _deposito = deposito;
            _localizacao = localizacao;
            Inicializar();
        }


        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            _formAntigo.Show();
            Close();
        }

        
        private void Inicializar()
        {
            InitializeComponent();
        }

        



    }
}