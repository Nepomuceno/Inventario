﻿namespace Sirius.Coletor.Views
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
            this.btnConfirmar = new System.Windows.Forms.MenuItem();
            this.cbLocalizacoes = new System.Windows.Forms.ComboBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.lblInventario = new System.Windows.Forms.Label();
            this.lblContagem = new System.Windows.Forms.Label();
            this.lblFilial = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
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
            // cbLocalizacoes
            // 
            this.cbLocalizacoes.Location = new System.Drawing.Point(10, 185);
            this.cbLocalizacoes.Name = "cbLocalizacoes";
            this.cbLocalizacoes.Size = new System.Drawing.Size(226, 22);
            this.cbLocalizacoes.TabIndex = 1;
            // 
            // lblLocal
            // 
            this.lblLocal.Location = new System.Drawing.Point(9, 162);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(128, 20);
            this.lblLocal.Text = "Escolha o local";
            // 
            // lblDeposito
            // 
            this.lblDeposito.Location = new System.Drawing.Point(9, 131);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(202, 20);
            this.lblDeposito.Text = "Deposito:";
            // 
            // lblInventario
            // 
            this.lblInventario.Location = new System.Drawing.Point(10, 44);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(127, 28);
            this.lblInventario.Text = "Inventario:";
            // 
            // lblContagem
            // 
            this.lblContagem.Location = new System.Drawing.Point(137, 44);
            this.lblContagem.Name = "lblContagem";
            this.lblContagem.Size = new System.Drawing.Size(101, 28);
            this.lblContagem.Text = "Contagem:";
            // 
            // lblFilial
            // 
            this.lblFilial.Location = new System.Drawing.Point(10, 111);
            this.lblFilial.Name = "lblFilial";
            this.lblFilial.Size = new System.Drawing.Size(201, 20);
            this.lblFilial.Text = "Filial:";
            // 
            // lblOperador
            // 
            this.lblOperador.Location = new System.Drawing.Point(9, 14);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(227, 20);
            this.lblOperador.Text = "Operador:";
            // 
            // ViewLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.lblDeposito);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.lblContagem);
            this.Controls.Add(this.lblFilial);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.cbLocalizacoes);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "ViewLocal";
            this.Text = "Local de coleta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem btnVoltar;
        private System.Windows.Forms.ComboBox cbLocalizacoes;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.MenuItem btnConfirmar;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Label lblContagem;
        private System.Windows.Forms.Label lblFilial;
        private System.Windows.Forms.Label lblOperador;
    }
}