namespace ML_InformaticaView.Formularios.Principal
{
  partial class frmLogin
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
      this.pictureBoxEdit1 = new Controles.PictureBoxEdit();
      this.pnlLogin = new Controles.PanelEdit();
      this.buttonEdit1 = new Controles.ButtonEdit();
      this.btnCancelar = new Controles.ButtonEdit();
      this.txtSenha = new Controles.TextBoxEdit();
      this.txtUsuario = new Controles.TextBoxEdit();
      this.labelEdit3 = new Controles.LabelEdit();
      this.labelEdit2 = new Controles.LabelEdit();
      this.labelEdit1 = new Controles.LabelEdit();
      this.pnlTopo.SuspendLayout();
      this.pnlBase.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit1)).BeginInit();
      this.pnlLogin.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlTopo
      // 
      this.pnlTopo.Size = new System.Drawing.Size(568, 10);
      // 
      // pnlBase
      // 
      this.pnlBase.Controls.Add(this.pnlLogin);
      this.pnlBase.Controls.Add(this.pictureBoxEdit1);
      this.pnlBase.Location = new System.Drawing.Point(5, 10);
      this.pnlBase.Size = new System.Drawing.Size(568, 289);
      // 
      // btnSair
      // 
      this.btnSair.FlatAppearance.BorderSize = 0;
      this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
      this.btnSair.Location = new System.Drawing.Point(544, 0);
      this.btnSair.Size = new System.Drawing.Size(24, 10);
      // 
      // btnMinimizar
      // 
      this.btnMinimizar.FlatAppearance.BorderSize = 0;
      this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
      this.btnMinimizar.Location = new System.Drawing.Point(520, 0);
      this.btnMinimizar.Size = new System.Drawing.Size(24, 10);
      // 
      // lblTituloForm
      // 
      this.lblTituloForm.Size = new System.Drawing.Size(104, 17);
      this.lblTituloForm.Text = "Login de Acesso";
      // 
      // pictureBoxEdit1
      // 
      this.pictureBoxEdit1.Image = global::ML_InformaticaView.Properties.Resources.LOGIN2;
      this.pictureBoxEdit1.Location = new System.Drawing.Point(0, -3);
      this.pictureBoxEdit1.Name = "pictureBoxEdit1";
      this.pictureBoxEdit1.Size = new System.Drawing.Size(574, 191);
      this.pictureBoxEdit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBoxEdit1.TabIndex = 0;
      this.pictureBoxEdit1.TabStop = false;
      // 
      // pnlLogin
      // 
      this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
      this.pnlLogin.Controls.Add(this.buttonEdit1);
      this.pnlLogin.Controls.Add(this.btnCancelar);
      this.pnlLogin.Controls.Add(this.txtSenha);
      this.pnlLogin.Controls.Add(this.txtUsuario);
      this.pnlLogin.Controls.Add(this.labelEdit3);
      this.pnlLogin.Controls.Add(this.labelEdit2);
      this.pnlLogin.Controls.Add(this.labelEdit1);
      this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pnlLogin.Location = new System.Drawing.Point(0, 178);
      this.pnlLogin.Name = "pnlLogin";
      this.pnlLogin.PrtBorderColor = System.Drawing.Color.Transparent;
      this.pnlLogin.Size = new System.Drawing.Size(568, 111);
      this.pnlLogin.TabIndex = 1;
      // 
      // buttonEdit1
      // 
      this.buttonEdit1.BackColor = System.Drawing.Color.Transparent;
      this.buttonEdit1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
      this.buttonEdit1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
      this.buttonEdit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonEdit1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonEdit1.ForeColor = System.Drawing.Color.Transparent;
      this.buttonEdit1.Image = global::ML_InformaticaView.Properties.Resources.confirm;
      this.buttonEdit1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.buttonEdit1.Location = new System.Drawing.Point(285, 80);
      this.buttonEdit1.Name = "buttonEdit1";
      this.buttonEdit1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.buttonEdit1.PrtDesabilitarControle = false;
      this.buttonEdit1.PrtEstiloBotao = Controles.Enums.TipoEstiloBotao.Nenhum;
      this.buttonEdit1.PrtImagemAlinhamento = Controles.Enums.ImagemAlignmento.MiddleLeft;
      this.buttonEdit1.PrtIniciaFocusControle = false;
      this.buttonEdit1.PrtToolTipMensagem = null;
      this.buttonEdit1.Size = new System.Drawing.Size(112, 28);
      this.buttonEdit1.TabIndex = 5;
      this.buttonEdit1.Text = "Confirmar";
      this.buttonEdit1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.buttonEdit1.UseVisualStyleBackColor = false;
      this.buttonEdit1.Click += new System.EventHandler(this.buttonEdit1_Click);
      // 
      // btnCancelar
      // 
      this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
      this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
      this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
      this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancelar.ForeColor = System.Drawing.Color.Transparent;
      this.btnCancelar.Image = global::ML_InformaticaView.Properties.Resources.cancel;
      this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnCancelar.Location = new System.Drawing.Point(172, 80);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.btnCancelar.PrtDesabilitarControle = false;
      this.btnCancelar.PrtEstiloBotao = Controles.Enums.TipoEstiloBotao.Nenhum;
      this.btnCancelar.PrtImagemAlinhamento = Controles.Enums.ImagemAlignmento.MiddleLeft;
      this.btnCancelar.PrtIniciaFocusControle = false;
      this.btnCancelar.PrtToolTipMensagem = null;
      this.btnCancelar.Size = new System.Drawing.Size(107, 28);
      this.btnCancelar.TabIndex = 6;
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnCancelar.UseVisualStyleBackColor = false;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // txtSenha
      // 
      this.txtSenha.BackColor = System.Drawing.Color.White;
      this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.txtSenha.ForeColor = System.Drawing.Color.Black;
      this.txtSenha.Location = new System.Drawing.Point(231, 53);
      this.txtSenha.MaxLength = 50;
      this.txtSenha.Name = "txtSenha";
      this.txtSenha.PrtAceitaEspaco = false;
      this.txtSenha.PrtAceitaNumeros = false;
      this.txtSenha.PrtAtivaPesquisa = false;
      this.txtSenha.PrtAtivaValidacao = true;
      this.txtSenha.PrtCampoObrigatorio = false;
      this.txtSenha.PrtCaracteresEspeciais = null;
      this.txtSenha.PrtDesabilitarControle = false;
      this.txtSenha.PrtGravaParametroTela = false;
      this.txtSenha.PrtIniciaFocusControle = false;
      this.txtSenha.PrtLabelDescricao = null;
      this.txtSenha.PrtMensagemCampoObrigatorio = "Campo não pode ser vazio !";
      this.txtSenha.PrtMontaTelaAutomatico = true;
      this.txtSenha.PrtNaoLimparControle = false;
      this.txtSenha.PrtNomeCampoBD = null;
      this.txtSenha.PrtNomeTabelaBD = null;
      this.txtSenha.PrtOcultarAlertaErro = false;
      this.txtSenha.PrtTabEnter = true;
      this.txtSenha.PrtTamanhoMaximo = 50;
      this.txtSenha.PrtTipoTexto = Controles.Enums.TipoTexto.SENHA;
      this.txtSenha.PrtToolTipMensagem = null;
      this.txtSenha.PrtValorPadrao = null;
      this.txtSenha.Size = new System.Drawing.Size(154, 22);
      this.txtSenha.TabIndex = 4;
      this.txtSenha.Text = "admin";
      this.txtSenha.UseSystemPasswordChar = true;
      // 
      // txtUsuario
      // 
      this.txtUsuario.BackColor = System.Drawing.Color.White;
      this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.txtUsuario.ForeColor = System.Drawing.Color.Black;
      this.txtUsuario.Location = new System.Drawing.Point(231, 27);
      this.txtUsuario.MaxLength = 50;
      this.txtUsuario.Name = "txtUsuario";
      this.txtUsuario.PrtAceitaEspaco = false;
      this.txtUsuario.PrtAceitaNumeros = false;
      this.txtUsuario.PrtAtivaPesquisa = false;
      this.txtUsuario.PrtAtivaValidacao = true;
      this.txtUsuario.PrtCampoObrigatorio = false;
      this.txtUsuario.PrtCaracteresEspeciais = null;
      this.txtUsuario.PrtDesabilitarControle = false;
      this.txtUsuario.PrtGravaParametroTela = false;
      this.txtUsuario.PrtIniciaFocusControle = false;
      this.txtUsuario.PrtLabelDescricao = null;
      this.txtUsuario.PrtMensagemCampoObrigatorio = "Campo não pode ser vazio !";
      this.txtUsuario.PrtMontaTelaAutomatico = true;
      this.txtUsuario.PrtNaoLimparControle = false;
      this.txtUsuario.PrtNomeCampoBD = null;
      this.txtUsuario.PrtNomeTabelaBD = null;
      this.txtUsuario.PrtOcultarAlertaErro = false;
      this.txtUsuario.PrtTabEnter = true;
      this.txtUsuario.PrtTamanhoMaximo = 50;
      this.txtUsuario.PrtTipoTexto = Controles.Enums.TipoTexto.TEXTO_MAIUSCULO;
      this.txtUsuario.PrtToolTipMensagem = null;
      this.txtUsuario.PrtValorPadrao = null;
      this.txtUsuario.Size = new System.Drawing.Size(154, 22);
      this.txtUsuario.TabIndex = 3;
      this.txtUsuario.Text = "ADMIN";
      // 
      // labelEdit3
      // 
      this.labelEdit3.AutoSize = true;
      this.labelEdit3.BackColor = System.Drawing.Color.Transparent;
      this.labelEdit3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelEdit3.ForeColor = System.Drawing.Color.White;
      this.labelEdit3.Location = new System.Drawing.Point(179, 56);
      this.labelEdit3.Name = "labelEdit3";
      this.labelEdit3.PrtMontaTelaAutomatico = false;
      this.labelEdit3.PrtNaoLimparControle = true;
      this.labelEdit3.PrtNomeCampoBD = "";
      this.labelEdit3.PrtValorPadrao = null;
      this.labelEdit3.Size = new System.Drawing.Size(46, 17);
      this.labelEdit3.TabIndex = 2;
      this.labelEdit3.Text = "Senha:";
      this.labelEdit3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // labelEdit2
      // 
      this.labelEdit2.AutoSize = true;
      this.labelEdit2.BackColor = System.Drawing.Color.Transparent;
      this.labelEdit2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelEdit2.ForeColor = System.Drawing.Color.White;
      this.labelEdit2.Location = new System.Drawing.Point(169, 30);
      this.labelEdit2.Name = "labelEdit2";
      this.labelEdit2.PrtMontaTelaAutomatico = false;
      this.labelEdit2.PrtNaoLimparControle = true;
      this.labelEdit2.PrtNomeCampoBD = "";
      this.labelEdit2.PrtValorPadrao = null;
      this.labelEdit2.Size = new System.Drawing.Size(56, 17);
      this.labelEdit2.TabIndex = 1;
      this.labelEdit2.Text = "Usuário:";
      this.labelEdit2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // labelEdit1
      // 
      this.labelEdit1.AutoSize = true;
      this.labelEdit1.BackColor = System.Drawing.Color.Transparent;
      this.labelEdit1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelEdit1.ForeColor = System.Drawing.Color.White;
      this.labelEdit1.Location = new System.Drawing.Point(212, 4);
      this.labelEdit1.Name = "labelEdit1";
      this.labelEdit1.PrtMontaTelaAutomatico = false;
      this.labelEdit1.PrtNaoLimparControle = true;
      this.labelEdit1.PrtNomeCampoBD = "";
      this.labelEdit1.PrtValorPadrao = null;
      this.labelEdit1.Size = new System.Drawing.Size(155, 21);
      this.labelEdit1.TabIndex = 0;
      this.labelEdit1.Text = "Controle de Acesso";
      this.labelEdit1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // frmLogin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
      this.ClientSize = new System.Drawing.Size(578, 304);
      this.Name = "frmLogin";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "frmLogin";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
      this.pnlTopo.ResumeLayout(false);
      this.pnlTopo.PerformLayout();
      this.pnlBase.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit1)).EndInit();
      this.pnlLogin.ResumeLayout(false);
      this.pnlLogin.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private Controles.PanelEdit pnlLogin;
        private Controles.PictureBoxEdit pictureBoxEdit1;
        private Controles.ButtonEdit buttonEdit1;
        private Controles.ButtonEdit btnCancelar;
        private Controles.TextBoxEdit txtSenha;
        private Controles.TextBoxEdit txtUsuario;
        private Controles.LabelEdit labelEdit3;
        private Controles.LabelEdit labelEdit2;
        private Controles.LabelEdit labelEdit1;
    }
}