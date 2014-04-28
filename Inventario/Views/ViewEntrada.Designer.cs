namespace Sirius.Coletor.Views
{
    partial class ViewEntrada
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
            this.btnExecutarInventario = new System.Windows.Forms.Button();
            this.lblOperador = new System.Windows.Forms.Label();
            this.btnEnviarInventario = new System.Windows.Forms.Button();
            this.btnParametros = new System.Windows.Forms.Button();
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
            // btnExecutarInventario
            // 
            this.btnExecutarInventario.Location = new System.Drawing.Point(27, 32);
            this.btnExecutarInventario.Name = "btnExecutarInventario";
            this.btnExecutarInventario.Size = new System.Drawing.Size(187, 47);
            this.btnExecutarInventario.TabIndex = 0;
            this.btnExecutarInventario.Text = "Executar Inventario";
            this.btnExecutarInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // lblOperador
            // 
            this.lblOperador.Location = new System.Drawing.Point(4, 4);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(210, 25);
            // 
            // btnEnviarInventario
            // 
            this.btnEnviarInventario.Location = new System.Drawing.Point(27, 85);
            this.btnEnviarInventario.Name = "btnEnviarInventario";
            this.btnEnviarInventario.Size = new System.Drawing.Size(187, 47);
            this.btnEnviarInventario.TabIndex = 1;
            this.btnEnviarInventario.Text = "Enviar Inventario";
            // 
            // btnParametros
            // 
            this.btnParametros.Location = new System.Drawing.Point(27, 138);
            this.btnParametros.Name = "btnParametros";
            this.btnParametros.Size = new System.Drawing.Size(187, 47);
            this.btnParametros.TabIndex = 2;
            this.btnParametros.Text = "Parametros";
            // 
            // FrmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnParametros);
            this.Controls.Add(this.btnEnviarInventario);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.btnExecutarInventario);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "FrmEntrada";
            this.Text = "FrmEntrada";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExecutarInventario;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Button btnEnviarInventario;
        private System.Windows.Forms.MenuItem btnVoltar;
        private System.Windows.Forms.Button btnParametros;
    }
}