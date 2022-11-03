namespace ML_InformaticaView.Formularios.Cadastros
{
  partial class frmCadServico
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
      this.labelEdit2 = new Controles.LabelEdit();
      this.txtNomeServico = new Controles.TextBoxEdit();
      this.labelEdit1 = new Controles.LabelEdit();
      this.txtCodigoServico = new Controles.TextBoxEdit();
      this.pnlBaseCadastro.SuspendLayout();
      this.pnlBotoesTopo.SuspendLayout();
      this.pnlStatus.SuspendLayout();
      this.pnlTopo.SuspendLayout();
      this.pnlBase.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlBaseCadastro
      // 
      this.pnlBaseCadastro.Controls.Add(this.labelEdit2);
      this.pnlBaseCadastro.Controls.Add(this.txtNomeServico);
      this.pnlBaseCadastro.Controls.Add(this.labelEdit1);
      this.pnlBaseCadastro.Controls.Add(this.txtCodigoServico);
      this.pnlBaseCadastro.Size = new System.Drawing.Size(588, 175);
      this.pnlBaseCadastro.Controls.SetChildIndex(this.pnlBotoesTopo, 0);
      this.pnlBaseCadastro.Controls.SetChildIndex(this.pnlStatus, 0);
      this.pnlBaseCadastro.Controls.SetChildIndex(this.txtCodigoServico, 0);
      this.pnlBaseCadastro.Controls.SetChildIndex(this.labelEdit1, 0);
      this.pnlBaseCadastro.Controls.SetChildIndex(this.txtNomeServico, 0);
      this.pnlBaseCadastro.Controls.SetChildIndex(this.labelEdit2, 0);
      // 
      // pnlBotoesTopo
      // 
      this.pnlBotoesTopo.Size = new System.Drawing.Size(584, 66);
      // 
      // btnIncluir
      // 
      this.btnIncluir.FlatAppearance.BorderSize = 0;
      this.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
      // 
      // btnExit
      // 
      this.btnExit.FlatAppearance.BorderSize = 0;
      this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
      this.btnExit.Location = new System.Drawing.Point(492, 0);
      // 
      // btnCancelar
      // 
      this.btnCancelar.FlatAppearance.BorderSize = 0;
      this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
      // 
      // btnGravar
      // 
      this.btnGravar.FlatAppearance.BorderSize = 0;
      this.btnGravar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
      // 
      // btnProcurar
      // 
      this.btnProcurar.FlatAppearance.BorderSize = 0;
      this.btnProcurar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
      // 
      // btnExcluir
      // 
      this.btnExcluir.FlatAppearance.BorderSize = 0;
      this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
      // 
      // pnlStatus
      // 
      this.pnlStatus.Size = new System.Drawing.Size(584, 26);
      // 
      // pnlTopo
      // 
      this.pnlTopo.Size = new System.Drawing.Size(588, 29);
      // 
      // pnlBase
      // 
      this.pnlBase.Size = new System.Drawing.Size(588, 175);
      // 
      // btnSair
      // 
      this.btnSair.FlatAppearance.BorderSize = 0;
      this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
      this.btnSair.Location = new System.Drawing.Point(564, 0);
      // 
      // btnMinimizar
      // 
      this.btnMinimizar.FlatAppearance.BorderSize = 0;
      this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
      this.btnMinimizar.Location = new System.Drawing.Point(540, 0);
      // 
      // labelEdit2
      // 
      this.labelEdit2.AutoSize = true;
      this.labelEdit2.BackColor = System.Drawing.Color.Transparent;
      this.labelEdit2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelEdit2.ForeColor = System.Drawing.Color.Black;
      this.labelEdit2.Location = new System.Drawing.Point(15, 134);
      this.labelEdit2.Name = "labelEdit2";
      this.labelEdit2.PrtMontaTelaAutomatico = false;
      this.labelEdit2.PrtNaoLimparControle = true;
      this.labelEdit2.PrtNomeCampoBD = null;
      this.labelEdit2.PrtValorPadrao = null;
      this.labelEdit2.Size = new System.Drawing.Size(77, 14);
      this.labelEdit2.TabIndex = 50;
      this.labelEdit2.Text = "Nome Serviço:";
      this.labelEdit2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtNomeServico
      // 
      this.txtNomeServico.BackColor = System.Drawing.SystemColors.Menu;
      this.txtNomeServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtNomeServico.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNomeServico.ForeColor = System.Drawing.Color.Black;
      this.txtNomeServico.Location = new System.Drawing.Point(102, 131);
      this.txtNomeServico.MaxLength = 100;
      this.txtNomeServico.Name = "txtNomeServico";
      this.txtNomeServico.PrtAceitaEspaco = false;
      this.txtNomeServico.PrtAceitaNumeros = false;
      this.txtNomeServico.PrtAtivaPesquisa = false;
      this.txtNomeServico.PrtAtivaValidacao = true;
      this.txtNomeServico.PrtCampoObrigatorio = true;
      this.txtNomeServico.PrtCaracteresEspeciais = null;
      this.txtNomeServico.PrtDesabilitarControle = false;
      this.txtNomeServico.PrtGravaParametroTela = false;
      this.txtNomeServico.PrtIniciaFocusControle = false;
      this.txtNomeServico.PrtLabelDescricao = null;
      this.txtNomeServico.PrtMensagemCampoObrigatorio = "Campo não pode ser vazio !";
      this.txtNomeServico.PrtMontaTelaAutomatico = true;
      this.txtNomeServico.PrtNaoLimparControle = false;
      this.txtNomeServico.PrtNomeCampoBD = "NomeServico";
      this.txtNomeServico.PrtNomeTabelaBD = null;
      this.txtNomeServico.PrtOcultarAlertaErro = false;
      this.txtNomeServico.PrtTabEnter = true;
      this.txtNomeServico.PrtTamanhoMaximo = 100;
      this.txtNomeServico.PrtTipoTexto = Controles.Enums.TipoTexto.TEXTO_MAIUSCULO;
      this.txtNomeServico.PrtToolTipMensagem = null;
      this.txtNomeServico.PrtValorPadrao = null;
      this.txtNomeServico.Size = new System.Drawing.Size(444, 18);
      this.txtNomeServico.TabIndex = 48;
      // 
      // labelEdit1
      // 
      this.labelEdit1.AutoSize = true;
      this.labelEdit1.BackColor = System.Drawing.Color.Transparent;
      this.labelEdit1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelEdit1.ForeColor = System.Drawing.Color.Black;
      this.labelEdit1.Location = new System.Drawing.Point(15, 110);
      this.labelEdit1.Name = "labelEdit1";
      this.labelEdit1.PrtMontaTelaAutomatico = false;
      this.labelEdit1.PrtNaoLimparControle = true;
      this.labelEdit1.PrtNomeCampoBD = null;
      this.labelEdit1.PrtValorPadrao = null;
      this.labelEdit1.Size = new System.Drawing.Size(76, 14);
      this.labelEdit1.TabIndex = 49;
      this.labelEdit1.Text = "Cód Serviço:";
      this.labelEdit1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtCodigoServico
      // 
      this.txtCodigoServico.BackColor = System.Drawing.Color.White;
      this.txtCodigoServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtCodigoServico.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtCodigoServico.ForeColor = System.Drawing.Color.Black;
      this.txtCodigoServico.Location = new System.Drawing.Point(102, 107);
      this.txtCodigoServico.MaxLength = 9;
      this.txtCodigoServico.Name = "txtCodigoServico";
      this.txtCodigoServico.PrtAceitaEspaco = false;
      this.txtCodigoServico.PrtAceitaNumeros = true;
      this.txtCodigoServico.PrtAtivaPesquisa = false;
      this.txtCodigoServico.PrtAtivaValidacao = true;
      this.txtCodigoServico.PrtCampoObrigatorio = false;
      this.txtCodigoServico.PrtCaracteresEspeciais = null;
      this.txtCodigoServico.PrtDesabilitarControle = false;
      this.txtCodigoServico.PrtGravaParametroTela = false;
      this.txtCodigoServico.PrtIniciaFocusControle = false;
      this.txtCodigoServico.PrtLabelDescricao = null;
      this.txtCodigoServico.PrtMensagemCampoObrigatorio = "Campo não pode ser vazio !";
      this.txtCodigoServico.PrtMontaTelaAutomatico = true;
      this.txtCodigoServico.PrtNaoLimparControle = false;
      this.txtCodigoServico.PrtNomeCampoBD = "CodigoServico";
      this.txtCodigoServico.PrtNomeTabelaBD = null;
      this.txtCodigoServico.PrtOcultarAlertaErro = false;
      this.txtCodigoServico.PrtTabEnter = true;
      this.txtCodigoServico.PrtTamanhoMaximo = 9;
      this.txtCodigoServico.PrtTipoTexto = Controles.Enums.TipoTexto.TEXTO_MAIUSCULO;
      this.txtCodigoServico.PrtToolTipMensagem = null;
      this.txtCodigoServico.PrtValorPadrao = null;
      this.txtCodigoServico.Size = new System.Drawing.Size(64, 18);
      this.txtCodigoServico.TabIndex = 47;
      this.txtCodigoServico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodservico_KeyDown);
      this.txtCodigoServico.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodservico_Validating);
      // 
      // frmCadServico
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(598, 209);
      this.Name = "frmCadServico";
      this.Text = "frmCadServico";
      this.pnlBaseCadastro.ResumeLayout(false);
      this.pnlBaseCadastro.PerformLayout();
      this.pnlBotoesTopo.ResumeLayout(false);
      this.pnlStatus.ResumeLayout(false);
      this.pnlStatus.PerformLayout();
      this.pnlTopo.ResumeLayout(false);
      this.pnlTopo.PerformLayout();
      this.pnlBase.ResumeLayout(false);
      this.ResumeLayout(false);

    }

        #endregion

        private Controles.LabelEdit labelEdit2;
        private Controles.TextBoxEdit txtNomeServico;
        private Controles.LabelEdit labelEdit1;
        private Controles.TextBoxEdit txtCodigoServico;
    }
}