namespace Sirius.Coletor.Views
{
    partial class ViewLeitura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.btnVoltar = new System.Windows.Forms.MenuItem();
            this.btnSalvar = new System.Windows.Forms.MenuItem();
            this.lblProduto = new System.Windows.Forms.Label();
            this.tbProduto = new System.Windows.Forms.TextBox();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblProdutoDescricao = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblInventario = new System.Windows.Forms.Label();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.lblFilial = new System.Windows.Forms.Label();
            this.lblLocalizacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.btnVoltar);
            this.mainMenu1.MenuItems.Add(this.btnSalvar);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Text = "Sair";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Text = "Confirmar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblProduto
            // 
            this.lblProduto.Location = new System.Drawing.Point(4, 73);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(53, 20);
            this.lblProduto.Text = "Produto";
            // 
            // tbProduto
            // 
            this.tbProduto.Location = new System.Drawing.Point(63, 72);
            this.tbProduto.Name = "tbProduto";
            this.tbProduto.Size = new System.Drawing.Size(163, 21);
            this.tbProduto.TabIndex = 8;
            this.tbProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProduto_KeyPress);
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(94, 151);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(132, 21);
            this.tbQuantidade.TabIndex = 10;
            this.tbQuantidade.TextChanged += new System.EventHandler(this.tbQuantidade_TextChanged);
            this.tbQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQuantidade_KeyPress);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Location = new System.Drawing.Point(4, 151);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(84, 20);
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblProdutoDescricao
            // 
            this.lblProdutoDescricao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblProdutoDescricao.Location = new System.Drawing.Point(4, 97);
            this.lblProdutoDescricao.Name = "lblProdutoDescricao";
            this.lblProdutoDescricao.Size = new System.Drawing.Size(222, 50);
            // 
            // lblOperador
            // 
            this.lblOperador.Location = new System.Drawing.Point(4, 9);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(110, 20);
            this.lblOperador.Text = "Operador:";
            // 
            // lblInventario
            // 
            this.lblInventario.Location = new System.Drawing.Point(112, 9);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(114, 20);
            this.lblInventario.Text = "Inventario:";
            // 
            // lblDeposito
            // 
            this.lblDeposito.Location = new System.Drawing.Point(112, 29);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(114, 20);
            this.lblDeposito.Text = "Deposito:";
            // 
            // lblFilial
            // 
            this.lblFilial.Location = new System.Drawing.Point(4, 29);
            this.lblFilial.Name = "lblFilial";
            this.lblFilial.Size = new System.Drawing.Size(110, 20);
            this.lblFilial.Text = "Filial:";
            // 
            // lblLocalizacao
            // 
            this.lblLocalizacao.Location = new System.Drawing.Point(3, 49);
            this.lblLocalizacao.Name = "lblLocalizacao";
            this.lblLocalizacao.Size = new System.Drawing.Size(114, 20);
            this.lblLocalizacao.Text = "Localizacao:";
            // 
            // ViewLeitura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(257, 205);
            this.Controls.Add(this.lblLocalizacao);
            this.Controls.Add(this.lblDeposito);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.lblFilial);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.lblProdutoDescricao);
            this.Controls.Add(this.tbQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.tbProduto);
            this.Controls.Add(this.lblProduto);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "ViewLeitura";
            this.Text = "Leitura";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem btnVoltar;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.MenuItem btnSalvar;
        private System.Windows.Forms.TextBox tbProduto;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblProdutoDescricao;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.Label lblFilial;
        private System.Windows.Forms.Label lblLocalizacao;
    }
}