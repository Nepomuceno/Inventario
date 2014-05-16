namespace Sirius.Coletor.Views
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
            this.btnSalvar = new System.Windows.Forms.MenuItem();
            this.lbCominhoDados = new System.Windows.Forms.Label();
            this.tbCaminhoDados = new System.Windows.Forms.TextBox();
            this.tbCodigoDispositivo = new System.Windows.Forms.TextBox();
            this.lblCodigoDispositivo = new System.Windows.Forms.Label();
            this.cbQuantidade = new System.Windows.Forms.CheckBox();
            this.cbUmaLeituraPorLocalizacao = new System.Windows.Forms.CheckBox();
            this.cbContagemNaoCadastrado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.btnVoltar);
            this.mainMenu1.MenuItems.Add(this.btnSalvar);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lbCominhoDados
            // 
            this.lbCominhoDados.Location = new System.Drawing.Point(3, 8);
            this.lbCominhoDados.Name = "lbCominhoDados";
            this.lbCominhoDados.Size = new System.Drawing.Size(146, 20);
            this.lbCominhoDados.Text = "Caminho dos arquivos";
            // 
            // tbCaminhoDados
            // 
            this.tbCaminhoDados.Enabled = false;
            this.tbCaminhoDados.Location = new System.Drawing.Point(3, 31);
            this.tbCaminhoDados.Name = "tbCaminhoDados";
            this.tbCaminhoDados.Size = new System.Drawing.Size(234, 21);
            this.tbCaminhoDados.TabIndex = 1;
            // 
            // tbCodigoDispositivo
            // 
            this.tbCodigoDispositivo.Enabled = false;
            this.tbCodigoDispositivo.Location = new System.Drawing.Point(3, 78);
            this.tbCodigoDispositivo.Name = "tbCodigoDispositivo";
            this.tbCodigoDispositivo.Size = new System.Drawing.Size(234, 21);
            this.tbCodigoDispositivo.TabIndex = 3;
            // 
            // lblCodigoDispositivo
            // 
            this.lblCodigoDispositivo.Location = new System.Drawing.Point(3, 55);
            this.lblCodigoDispositivo.Name = "lblCodigoDispositivo";
            this.lblCodigoDispositivo.Size = new System.Drawing.Size(146, 20);
            this.lblCodigoDispositivo.Text = "Codigo do dispositivo";
            // 
            // cbQuantidade
            // 
            this.cbQuantidade.Location = new System.Drawing.Point(0, 112);
            this.cbQuantidade.Name = "cbQuantidade";
            this.cbQuantidade.Size = new System.Drawing.Size(234, 20);
            this.cbQuantidade.TabIndex = 5;
            this.cbQuantidade.Text = "Digitar quantidade";
            // 
            // cbUmaLeituraPorLocalizacao
            // 
            this.cbUmaLeituraPorLocalizacao.Location = new System.Drawing.Point(0, 138);
            this.cbUmaLeituraPorLocalizacao.Name = "cbUmaLeituraPorLocalizacao";
            this.cbUmaLeituraPorLocalizacao.Size = new System.Drawing.Size(234, 20);
            this.cbUmaLeituraPorLocalizacao.TabIndex = 6;
            this.cbUmaLeituraPorLocalizacao.Text = "Uma leitura por localizacao";
            // 
            // cbContagemNaoCadastrado
            // 
            this.cbContagemNaoCadastrado.Location = new System.Drawing.Point(0, 164);
            this.cbContagemNaoCadastrado.Name = "cbContagemNaoCadastrado";
            this.cbContagemNaoCadastrado.Size = new System.Drawing.Size(234, 20);
            this.cbContagemNaoCadastrado.TabIndex = 7;
            this.cbContagemNaoCadastrado.Text = "Contagem de produto nao cadastrado";
            // 
            // ViewParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 188);
            this.Controls.Add(this.cbContagemNaoCadastrado);
            this.Controls.Add(this.cbUmaLeituraPorLocalizacao);
            this.Controls.Add(this.cbQuantidade);
            this.Controls.Add(this.tbCodigoDispositivo);
            this.Controls.Add(this.lblCodigoDispositivo);
            this.Controls.Add(this.tbCaminhoDados);
            this.Controls.Add(this.lbCominhoDados);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "ViewParametros";
            this.Text = "Parametros";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem btnVoltar;
        private System.Windows.Forms.MenuItem btnSalvar;
        private System.Windows.Forms.Label lbCominhoDados;
        private System.Windows.Forms.TextBox tbCaminhoDados;
        private System.Windows.Forms.TextBox tbCodigoDispositivo;
        private System.Windows.Forms.Label lblCodigoDispositivo;
        private System.Windows.Forms.CheckBox cbQuantidade;
        private System.Windows.Forms.CheckBox cbUmaLeituraPorLocalizacao;
        private System.Windows.Forms.CheckBox cbContagemNaoCadastrado;
    }
}