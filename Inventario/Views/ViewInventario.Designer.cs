namespace Sirius.Coletor.Views
{
    partial class ViewInventario
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
            this.btnContinuar = new System.Windows.Forms.MenuItem();
            this.btnEnviar = new System.Windows.Forms.MenuItem();
            this.btnFinalizar = new System.Windows.Forms.MenuItem();
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.cbInventarios = new System.Windows.Forms.ComboBox();
            this.btnExecutar = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.btnVoltar);
            this.mainMenu1.MenuItems.Add(this.btnContinuar);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.MenuItems.Add(this.btnExecutar);
            this.btnContinuar.MenuItems.Add(this.btnEnviar);
            this.btnContinuar.MenuItems.Add(this.btnFinalizar);
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblOperador
            // 
            this.lblOperador.Location = new System.Drawing.Point(4, 4);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(233, 22);
            this.lblOperador.Text = "Operador";
            // 
            // lblDeposito
            // 
            this.lblDeposito.Location = new System.Drawing.Point(4, 38);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(128, 20);
            this.lblDeposito.Text = "Escolha o inventario";
            // 
            // cbInventarios
            // 
            this.cbInventarios.Location = new System.Drawing.Point(4, 61);
            this.cbInventarios.Name = "cbInventarios";
            this.cbInventarios.Size = new System.Drawing.Size(233, 22);
            this.cbInventarios.TabIndex = 6;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // ViewInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 188);
            this.Controls.Add(this.lblDeposito);
            this.Controls.Add(this.cbInventarios);
            this.Controls.Add(this.lblOperador);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "ViewInventario";
            this.Text = "Inventarios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.MenuItem btnVoltar;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.ComboBox cbInventarios;
        private System.Windows.Forms.MenuItem btnContinuar;
        private System.Windows.Forms.MenuItem btnEnviar;
        private System.Windows.Forms.MenuItem btnFinalizar;
        private System.Windows.Forms.MenuItem btnExecutar;
    }
}