namespace Sirius.Coletor.Views
{
    partial class FrmEntrada
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
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnContagem = new System.Windows.Forms.Button();
            this.lblOperador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(27, 44);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(187, 47);
            this.btnInventario.TabIndex = 0;
            this.btnInventario.Text = "Inventario";
            // 
            // btnContagem
            // 
            this.btnContagem.Location = new System.Drawing.Point(27, 139);
            this.btnContagem.Name = "btnContagem";
            this.btnContagem.Size = new System.Drawing.Size(187, 47);
            this.btnContagem.TabIndex = 1;
            this.btnContagem.Text = "Contagem";
            // 
            // lblOperador
            // 
            this.lblOperador.Location = new System.Drawing.Point(4, 4);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(210, 25);
            // 
            // FrmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.btnContagem);
            this.Controls.Add(this.btnInventario);
            this.Menu = this.mainMenu1;
            this.Name = "FrmEntrada";
            this.Text = "FrmEntrada";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnContagem;
        private System.Windows.Forms.Label lblOperador;
    }
}