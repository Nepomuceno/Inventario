﻿namespace Sirius.Coletor.Views
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.btnSair = new System.Windows.Forms.MenuItem();
            this.btnEntrar = new System.Windows.Forms.MenuItem();
            this.lblVersao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.Location = new System.Drawing.Point(3, 16);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(52, 20);
            this.lblUsuario.Text = "Usuario";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(3, 40);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(234, 21);
            this.tbUsuario.TabIndex = 1;
            // 
            // lblSenha
            // 
            this.lblSenha.Location = new System.Drawing.Point(3, 68);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(100, 20);
            this.lblSenha.Text = "Senha";
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(3, 91);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(234, 21);
            this.tbSenha.TabIndex = 4;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.btnSair);
            this.mainMenu1.MenuItems.Add(this.btnEntrar);
            // 
            // btnSair
            // 
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblVersao
            // 
            this.lblVersao.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblVersao.Location = new System.Drawing.Point(0, 131);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(237, 20);
            this.lblVersao.Text = "Versão: ";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 188);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Menu = this.mainMenu1;
            this.Name = "FrmLogin";
            this.Text = "Inventario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem btnSair;
        private System.Windows.Forms.MenuItem btnEntrar;
        private System.Windows.Forms.Label lblVersao;
    }
}

