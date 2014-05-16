namespace Sirius.Coletor.Views
{
    partial class ViewImportacao
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
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnParametros = new System.Windows.Forms.Button();
            this.btnOperadores = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(27, 55);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(187, 29);
            this.btnInventario.TabIndex = 1;
            this.btnInventario.Text = "Inventarios";
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnParametros
            // 
            this.btnParametros.Location = new System.Drawing.Point(27, 123);
            this.btnParametros.Name = "btnParametros";
            this.btnParametros.Size = new System.Drawing.Size(187, 27);
            this.btnParametros.TabIndex = 2;
            this.btnParametros.Text = "Filiais";
            this.btnParametros.Click += new System.EventHandler(this.btnFiliais_Click);
            // 
            // btnOperadores
            // 
            this.btnOperadores.Location = new System.Drawing.Point(27, 90);
            this.btnOperadores.Name = "btnOperadores";
            this.btnOperadores.Size = new System.Drawing.Size(187, 27);
            this.btnOperadores.TabIndex = 3;
            this.btnOperadores.Text = "Operadores";
            this.btnOperadores.Click += new System.EventHandler(this.btnOperadores_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Location = new System.Drawing.Point(27, 156);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(187, 27);
            this.btnProdutos.TabIndex = 4;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 22);
            this.label1.Text = "Escolha o que deseja importar";
            // 
            // ViewImportacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 188);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnOperadores);
            this.Controls.Add(this.btnParametros);
            this.Controls.Add(this.btnInventario);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "ViewImportacao";
            this.Text = "Importacao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.MenuItem btnVoltar;
        private System.Windows.Forms.Button btnParametros;
        private System.Windows.Forms.Button btnOperadores;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Label label1;
    }
}