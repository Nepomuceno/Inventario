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
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.tbProduto = new System.Windows.Forms.TextBox();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.btnVoltar);
            this.mainMenu1.MenuItems.Add(this.btnSalvar);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblOperador
            // 
            this.lblOperador.Location = new System.Drawing.Point(4, 4);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(210, 25);
            // 
            // lblProduto
            // 
            this.lblProduto.Location = new System.Drawing.Point(4, 38);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(128, 20);
            this.lblProduto.Text = "Produto";
            // 
            // tbProduto
            // 
            this.tbProduto.Location = new System.Drawing.Point(4, 62);
            this.tbProduto.Name = "tbProduto";
            this.tbProduto.Size = new System.Drawing.Size(210, 21);
            this.tbProduto.TabIndex = 8;
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(4, 115);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(210, 21);
            this.tbQuantidade.TabIndex = 10;
            this.tbQuantidade.TextChanged += new System.EventHandler(this.tbQuantidade_TextChanged);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Location = new System.Drawing.Point(4, 91);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(128, 20);
            this.lblQuantidade.Text = "Quantidade";
            // 
            // ViewLeitura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.tbQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.tbProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblOperador);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "ViewLeitura";
            this.Text = "Leitura";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.MenuItem btnVoltar;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.MenuItem btnSalvar;
        private System.Windows.Forms.TextBox tbProduto;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
    }
}