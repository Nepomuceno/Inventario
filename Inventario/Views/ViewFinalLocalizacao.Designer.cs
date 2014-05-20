namespace Sirius.Coletor.Views
{
    partial class ViewFinalLocalizacao
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
            this.btnFinalizar = new System.Windows.Forms.MenuItem();
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblInventario = new System.Windows.Forms.Label();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.lblFilial = new System.Windows.Forms.Label();
            this.lblLocalizacao = new System.Windows.Forms.Label();
            this.lblInfoAdicional = new System.Windows.Forms.Label();
            this.tbInfoAdicional = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.btnVoltar);
            this.mainMenu1.MenuItems.Add(this.btnFinalizar);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Text = "Sair";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
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
            // lblInfoAdicional
            // 
            this.lblInfoAdicional.Location = new System.Drawing.Point(4, 71);
            this.lblInfoAdicional.Name = "lblInfoAdicional";
            this.lblInfoAdicional.Size = new System.Drawing.Size(138, 20);
            this.lblInfoAdicional.Text = "Informações adicionais:";
            // 
            // tbInfoAdicional
            // 
            this.tbInfoAdicional.Location = new System.Drawing.Point(4, 95);
            this.tbInfoAdicional.Multiline = true;
            this.tbInfoAdicional.Name = "tbInfoAdicional";
            this.tbInfoAdicional.Size = new System.Drawing.Size(233, 79);
            this.tbInfoAdicional.TabIndex = 6;
            // 
            // ViewFinalLocalizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.tbInfoAdicional);
            this.Controls.Add(this.lblInfoAdicional);
            this.Controls.Add(this.lblLocalizacao);
            this.Controls.Add(this.lblDeposito);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.lblFilial);
            this.Controls.Add(this.lblOperador);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "ViewFinalLocalizacao";
            this.Text = "Finalizar localizacao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem btnVoltar;
        private System.Windows.Forms.MenuItem btnFinalizar;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.Label lblFilial;
        private System.Windows.Forms.Label lblLocalizacao;
        private System.Windows.Forms.Label lblInfoAdicional;
        private System.Windows.Forms.TextBox tbInfoAdicional;
    }
}