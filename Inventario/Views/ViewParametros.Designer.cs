﻿namespace Sirius.Coletor.Views
{
    partial class ViewParametros
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
            this.btnGerarDadosDemo = new System.Windows.Forms.Button();
            this.btnImportarDados = new System.Windows.Forms.Button();
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
            // btnGerarDadosDemo
            // 
            this.btnGerarDadosDemo.Location = new System.Drawing.Point(29, 19);
            this.btnGerarDadosDemo.Name = "btnGerarDadosDemo";
            this.btnGerarDadosDemo.Size = new System.Drawing.Size(187, 47);
            this.btnGerarDadosDemo.TabIndex = 0;
            this.btnGerarDadosDemo.Text = "Gerar dados demo";
            this.btnGerarDadosDemo.Click += new System.EventHandler(this.btnGerarDadosDemo_Click);
            // 
            // btnImportarDados
            // 
            this.btnImportarDados.Location = new System.Drawing.Point(29, 83);
            this.btnImportarDados.Name = "btnImportarDados";
            this.btnImportarDados.Size = new System.Drawing.Size(187, 47);
            this.btnImportarDados.TabIndex = 1;
            this.btnImportarDados.Text = "Importar dados";
            this.btnImportarDados.Click += new System.EventHandler(this.btnImportarDados_Click);
            // 
            // ViewParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnImportarDados);
            this.Controls.Add(this.btnGerarDadosDemo);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "ViewParametros";
            this.Text = "Parametros";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGerarDadosDemo;
        private System.Windows.Forms.MenuItem btnVoltar;
        private System.Windows.Forms.Button btnImportarDados;
    }
}