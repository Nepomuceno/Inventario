﻿namespace Sirius.Coletor.Views
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
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnParametros = new System.Windows.Forms.Button();
            this.btnImportacao = new System.Windows.Forms.Button();
            this.btnMetricas = new System.Windows.Forms.Button();
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
            this.btnInventario.Location = new System.Drawing.Point(27, 53);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(187, 29);
            this.btnInventario.TabIndex = 1;
            this.btnInventario.Text = "Inventarios";
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnParametros
            // 
            this.btnParametros.Location = new System.Drawing.Point(27, 121);
            this.btnParametros.Name = "btnParametros";
            this.btnParametros.Size = new System.Drawing.Size(187, 27);
            this.btnParametros.TabIndex = 2;
            this.btnParametros.Text = "Parametros";
            this.btnParametros.Click += new System.EventHandler(this.btnParametros_Click);
            // 
            // btnImportacao
            // 
            this.btnImportacao.Location = new System.Drawing.Point(27, 88);
            this.btnImportacao.Name = "btnImportacao";
            this.btnImportacao.Size = new System.Drawing.Size(187, 27);
            this.btnImportacao.TabIndex = 3;
            this.btnImportacao.Text = "Importacao";
            this.btnImportacao.Click += new System.EventHandler(this.btnImportacao_Click);
            // 
            // btnMetricas
            // 
            this.btnMetricas.Location = new System.Drawing.Point(27, 154);
            this.btnMetricas.Name = "btnMetricas";
            this.btnMetricas.Size = new System.Drawing.Size(187, 27);
            this.btnMetricas.TabIndex = 4;
            this.btnMetricas.Text = "Metricas";
            this.btnMetricas.Click += new System.EventHandler(this.btnMetricas_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 22);
            this.label1.Text = "Sirius Inventario";
            // 
            // ViewEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 188);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMetricas);
            this.Controls.Add(this.btnImportacao);
            this.Controls.Add(this.btnParametros);
            this.Controls.Add(this.btnInventario);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "ViewEntrada";
            this.Text = "Sirius";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.MenuItem btnVoltar;
        private System.Windows.Forms.Button btnParametros;
        private System.Windows.Forms.Button btnImportacao;
        private System.Windows.Forms.Button btnMetricas;
        private System.Windows.Forms.Label label1;
    }
}