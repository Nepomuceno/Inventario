using System;
using System.ComponentModel;
using System.Windows.Forms;
using Symbol.Barcode;

namespace Sirius.Coletor.Views
{
    public partial class FrmLogin : Form
    {
        private readonly BarcodeReader _reader;
        public FrmLogin()
        {
            InitializeComponent();
                //_reader = new BarcodeReader();
                //_reader.Start();
                //_reader.ListChanged += (sender, args) =>
                //{
                //    if (args.ListChangedType == ListChangedType.ItemAdded)
                //    {
                //        tbUsuario.Text = _reader.ReaderData.Text;
                //    }
                //};
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Program.Banco.SalvarTudo(Program.Caminho);
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var entrada = new ViewEntrada(this);
            entrada.Show();
        }

        
    }
}