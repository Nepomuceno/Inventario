namespace Sirius.Coletor.Views
{
    partial class ViewDeposito
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
            this.btnConfirmar = new System.Windows.Forms.MenuItem();
            this.lblOperador = new System.Windows.Forms.Label();
            this.cbDepositos = new System.Windows.Forms.ComboBox();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.lblInventario = new System.Windows.Forms.Label();
            this.lblContagem = new System.Windows.Forms.Label();
            this.lblFilial = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.btnVoltar);
            this.mainMenu1.MenuItems.Add(this.btnConfirmar);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblOperador
            // 
            this.lblOperador.Location = new System.Drawing.Point(4, 4);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(210, 25);
            // 
            // cbDepositos
            // 
            this.cbDepositos.Location = new System.Drawing.Point(4, 154);
            this.cbDepositos.Name = "cbDepositos";
            this.cbDepositos.Size = new System.Drawing.Size(233, 22);
            this.cbDepositos.TabIndex = 1;
            // 
            // lblDeposito
            // 
            this.lblDeposito.Location = new System.Drawing.Point(3, 131);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(128, 20);
            this.lblDeposito.Text = "Escolha o deposito";
            // 
            // lblInventario
            // 
            this.lblInventario.Location = new System.Drawing.Point(4, 47);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(128, 28);
            this.lblInventario.Text = "Inventario:";
            // 
            // lblContagem
            // 
            this.lblContagem.Location = new System.Drawing.Point(138, 47);
            this.lblContagem.Name = "lblContagem";
            this.lblContagem.Size = new System.Drawing.Size(99, 28);
            this.lblContagem.Text = "Contagem:";
            // 
            // lblFilial
            // 
            this.lblFilial.Location = new System.Drawing.Point(4, 90);
            this.lblFilial.Name = "lblFilial";
            this.lblFilial.Size = new System.Drawing.Size(144, 27);
            this.lblFilial.Text = "Filial:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 20);
            this.label1.Text = "Operador:";
            // 
            // ViewDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.lblContagem);
            this.Controls.Add(this.lblFilial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDeposito);
            this.Controls.Add(this.cbDepositos);
            this.Controls.Add(this.lblOperador);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "ViewDeposito";
            this.Text = "Depositos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.MenuItem btnVoltar;
        private System.Windows.Forms.ComboBox cbDepositos;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.MenuItem btnConfirmar;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Label lblContagem;
        private System.Windows.Forms.Label lblFilial;
        private System.Windows.Forms.Label label1;
    }
}