namespace Sirius.Coletor.Views
{
    partial class ViewLeituras
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
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.btnVoltar = new System.Windows.Forms.MenuItem();
            this.lblOperador = new System.Windows.Forms.Label();
            this.leituraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgLeituras = new System.Windows.Forms.DataGrid();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.leituraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.btnVoltar);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblOperador
            // 
            this.lblOperador.Location = new System.Drawing.Point(4, 4);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(210, 25);
            // 
            // leituraBindingSource
            // 
            this.leituraBindingSource.DataSource = typeof(Sirius.Coletor.Base.Leitura);
            // 
            // dgLeituras
            // 
            this.dgLeituras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgLeituras.DataSource = this.leituraBindingSource;
            this.dgLeituras.Location = new System.Drawing.Point(4, 32);
            this.dgLeituras.Name = "dgLeituras";
            this.dgLeituras.Size = new System.Drawing.Size(233, 200);
            this.dgLeituras.TabIndex = 6;
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.Location = new System.Drawing.Point(146, 238);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(91, 27);
            this.btnNovoProduto.TabIndex = 8;
            this.btnNovoProduto.Text = "Novo produto";
            // 
            // ViewLeituras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnNovoProduto);
            this.Controls.Add(this.dgLeituras);
            this.Controls.Add(this.lblOperador);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "ViewLeituras";
            this.Text = "Leituras";
            this.GotFocus += new System.EventHandler(this.ViewLeituras_GotFocus);
            ((System.ComponentModel.ISupportInitialize)(this.leituraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.MenuItem btnVoltar;
        private System.Windows.Forms.DataGrid dgLeituras;
        private System.Windows.Forms.Button btnNovoProduto;
        private System.Windows.Forms.BindingSource leituraBindingSource;
    }
}