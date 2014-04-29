namespace Sirius.Coletor.Views
{
    partial class ViewLocal
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
            this.lblOperador = new System.Windows.Forms.Label();
            this.cbLocalizacoes = new System.Windows.Forms.ComboBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.btnExecutar = new System.Windows.Forms.Button();
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
            // cbLocalizacoes
            // 
            this.cbLocalizacoes.Location = new System.Drawing.Point(4, 60);
            this.cbLocalizacoes.Name = "cbLocalizacoes";
            this.cbLocalizacoes.Size = new System.Drawing.Size(233, 22);
            this.cbLocalizacoes.TabIndex = 1;
            // 
            // lblLocal
            // 
            this.lblLocal.Location = new System.Drawing.Point(4, 37);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(128, 20);
            this.lblLocal.Text = "Escolha o local";
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(165, 88);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(72, 20);
            this.btnExecutar.TabIndex = 3;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // ViewLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.cbLocalizacoes);
            this.Controls.Add(this.lblOperador);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "ViewLocal";
            this.Text = "Local de coleta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.MenuItem btnVoltar;
        private System.Windows.Forms.ComboBox cbLocalizacoes;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Button btnExecutar;
    }
}