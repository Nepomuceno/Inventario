using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Sirius.Coletor.Base;
using Sirius.Coletor.Base.Extensions;
using Sirius.Coletor.Dados;
using System;

namespace Sirius.Coletor.Views
{
    public partial class ViewLeitura : Form
    {
        private readonly Form _formAntigo;
        private readonly Leitura _leitura;
        private readonly Produto _produto;
        private static Regex digitsOnly = new Regex(@"[^\d]");  

        public ViewLeitura(Form formAntigo,ref Leitura leitura)
        {
            _formAntigo = formAntigo;
            _leitura = leitura;
            _produto = Program.Banco.Produtos.ComCodigo(leitura.CodigoProduto);
            InitializeComponent();
            tbProduto.Enabled = false;
            tbProduto.Text = _produto.Descricao;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _formAntigo.Show();
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _leitura.Quantidade = int.Parse(tbQuantidade.Text);
            _formAntigo.Show();
            Close();
        }

        private void tbQuantidade_TextChanged(object sender, EventArgs e)
        {
            tbQuantidade.Text = digitsOnly.Replace(tbQuantidade.Text, "");
        }

        

    }
}