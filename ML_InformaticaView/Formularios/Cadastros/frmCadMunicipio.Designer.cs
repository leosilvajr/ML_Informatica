namespace ML_InformaticaView.Formularios.Cadastros
{
  partial class frmCadMunicipio
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
      this.cboEstado = new Controles.ComboBoxEdit();
      this.txtCodMunicipio = new Controles.TextBoxEdit();
      this.txtNomeMunicipio = new Controles.TextBoxEdit();
      this.labelEdit3 = new Controles.LabelEdit();
      this.labelEdit2 = new Controles.LabelEdit();
      this.labelEdit1 = new Controles.LabelEdit();
      this.pnlBaseCadastro.SuspendLayout();
      this.pnlBotoesTopo.SuspendLayout();
      this.pnlStatus.SuspendLayout();
      this.pnlTopo.SuspendLayout();
      this.pnlBase.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlBaseCadastro
      // 
      this.pnlBaseCadastro.Controls.Add(this.labelEdit1);
      this.pnlBaseCadastro.Controls.Add(this.cboEstado);
      this.pnlBaseCadastro.Controls.Add(this.txtCodMunicipio);
      this.pnlBaseCadastro.Controls.Add(this.txtNomeMunicipio);
      this.pnlBaseCadastro.Controls.Add(this.labelEdit3);
      this.pnlBaseCadastro.Controls.Add(this.labelEdit2);
      this.pnlBaseCadastro.Size = new System.Drawing.Size(593, 216);
      this.pnlBaseCadastro.Controls.SetChildIndex(this.pnlBotoesTopo, 0);
      this.pnlBaseCadastro.Controls.SetChildIndex(this.pnlStatus, 0);
      this.pnlBaseCadastro.Controls.SetChildIndex(this.labelEdit2, 0);
      this.pnlBaseCadastro.Controls.SetChildIndex(this.labelEdit3, 0);
      this.pnlBaseCadastro.Controls.SetChildIndex(this.txtNomeMunicipio, 0);
      this.pnlBaseCadastro.Controls.SetChildIndex(this.txtCodMunicipio, 0);
      this.pnlBaseCadastro.Controls.SetChildIndex(this.cboEstado, 0);
      this.pnlBaseCadastro.Controls.SetChildIndex(this.labelEdit1, 0);
      // 
      // pnlBotoesTopo
      // 
      this.pnlBotoesTopo.Size = new System.Drawing.Size(589, 66);
      // 
      // btnIncluir
      // 
      this.btnIncluir.FlatAppearance.BorderSize = 0;
      this.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      // 
      // btnExit
      // 
      this.btnExit.FlatAppearance.BorderSize = 0;
      this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.btnExit.Location = new System.Drawing.Point(497, 0);
      // 
      // btnCancelar
      // 
      this.btnCancelar.FlatAppearance.BorderSize = 0;
      this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      // 
      // btnGravar
      // 
      this.btnGravar.FlatAppearance.BorderSize = 0;
      this.btnGravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      // 
      // btnProcurar
      // 
      this.btnProcurar.FlatAppearance.BorderSize = 0;
      this.btnProcurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      // 
      // btnExcluir
      // 
      this.btnExcluir.FlatAppearance.BorderSize = 0;
      this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      // 
      // pnlStatus
      // 
      this.pnlStatus.Size = new System.Drawing.Size(589, 26);
      // 
      // lblStatus
      // 
      this.lblStatus.Location = new System.Drawing.Point(320, 5);
      // 
      // pnlTopo
      // 
      this.pnlTopo.Size = new System.Drawing.Size(593, 29);
      // 
      // pnlBase
      // 
      this.pnlBase.Size = new System.Drawing.Size(593, 216);
      // 
      // btnSair
      // 
      this.btnSair.FlatAppearance.BorderSize = 0;
      this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
      this.btnSair.Location = new System.Drawing.Point(569, 0);
      // 
      // btnMinimizar
      // 
      this.btnMinimizar.FlatAppearance.BorderSize = 0;
      this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
      this.btnMinimizar.Location = new System.Drawing.Point(545, 0);
      // 
      // cboEstado
      // 
      this.cboEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.cboEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.cboEstado.BackColor = System.Drawing.Color.White;
      this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboEstado.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cboEstado.ForeColor = System.Drawing.Color.Black;
      this.cboEstado.FormattingEnabled = true;
      this.cboEstado.Location = new System.Drawing.Point(90, 168);
      this.cboEstado.Name = "cboEstado";
      this.cboEstado.PrtAceitaEspaco = false;
      this.cboEstado.PrtAceitaNumeros = false;
      this.cboEstado.PrtAtivaPesquisa = false;
      this.cboEstado.PrtAtivaValidacao = true;
      this.cboEstado.PrtCampoObrigatorio = true;
      this.cboEstado.PrtCaracteresEspeciais = null;
      this.cboEstado.PrtDesabilitarControle = false;
      this.cboEstado.PrtGravaParametroTela = false;
      this.cboEstado.PrtIniciaFocusControle = false;
      this.cboEstado.PrtLabelDescricao = null;
      this.cboEstado.PrtMensagemCampoObrigatorio = "Campo não pode ser vazio !";
      this.cboEstado.PrtMontaTelaAutomatico = true;
      this.cboEstado.PrtNaoLimparControle = false;
      this.cboEstado.PrtNomeCampoBD = "NomeUF";
      this.cboEstado.PrtNomeTabelaBD = "";
      this.cboEstado.PrtOcultarAlertaErro = false;
      this.cboEstado.PrtTabEnter = true;
      this.cboEstado.PrtTipoTexto = Controles.Enums.TipoTexto.TEXTO_MAIUSCULO;
      this.cboEstado.PrtToolTipMensagem = null;
      this.cboEstado.PrtValorPadrao = null;
      this.cboEstado.Size = new System.Drawing.Size(479, 22);
      this.cboEstado.TabIndex = 9;
      // 
      // txtCodMunicipio
      // 
      this.txtCodMunicipio.BackColor = System.Drawing.SystemColors.Menu;
      this.txtCodMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtCodMunicipio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtCodMunicipio.ForeColor = System.Drawing.Color.Black;
      this.txtCodMunicipio.Location = new System.Drawing.Point(90, 109);
      this.txtCodMunicipio.MaxLength = 7;
      this.txtCodMunicipio.Name = "txtCodMunicipio";
      this.txtCodMunicipio.PrtAceitaEspaco = false;
      this.txtCodMunicipio.PrtAceitaNumeros = false;
      this.txtCodMunicipio.PrtAtivaPesquisa = false;
      this.txtCodMunicipio.PrtAtivaValidacao = true;
      this.txtCodMunicipio.PrtCampoObrigatorio = true;
      this.txtCodMunicipio.PrtCaracteresEspeciais = null;
      this.txtCodMunicipio.PrtDesabilitarControle = false;
      this.txtCodMunicipio.PrtGravaParametroTela = false;
      this.txtCodMunicipio.PrtIniciaFocusControle = false;
      this.txtCodMunicipio.PrtLabelDescricao = null;
      this.txtCodMunicipio.PrtMensagemCampoObrigatorio = "Código não pode ser vazio !";
      this.txtCodMunicipio.PrtMontaTelaAutomatico = true;
      this.txtCodMunicipio.PrtNaoLimparControle = false;
      this.txtCodMunicipio.PrtNomeCampoBD = "CodigoMunicipio";
      this.txtCodMunicipio.PrtNomeTabelaBD = "";
      this.txtCodMunicipio.PrtOcultarAlertaErro = false;
      this.txtCodMunicipio.PrtTabEnter = true;
      this.txtCodMunicipio.PrtTamanhoMaximo = 7;
      this.txtCodMunicipio.PrtTipoTexto = Controles.Enums.TipoTexto.TEXTO_MAIUSCULO;
      this.txtCodMunicipio.PrtToolTipMensagem = null;
      this.txtCodMunicipio.PrtValorPadrao = null;
      this.txtCodMunicipio.Size = new System.Drawing.Size(61, 18);
      this.txtCodMunicipio.TabIndex = 7;
      // 
      // txtNomeMunicipio
      // 
      this.txtNomeMunicipio.BackColor = System.Drawing.SystemColors.Menu;
      this.txtNomeMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtNomeMunicipio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNomeMunicipio.ForeColor = System.Drawing.Color.Black;
      this.txtNomeMunicipio.Location = new System.Drawing.Point(90, 140);
      this.txtNomeMunicipio.MaxLength = 100;
      this.txtNomeMunicipio.Name = "txtNomeMunicipio";
      this.txtNomeMunicipio.PrtAceitaEspaco = false;
      this.txtNomeMunicipio.PrtAceitaNumeros = false;
      this.txtNomeMunicipio.PrtAtivaPesquisa = false;
      this.txtNomeMunicipio.PrtAtivaValidacao = true;
      this.txtNomeMunicipio.PrtCampoObrigatorio = true;
      this.txtNomeMunicipio.PrtCaracteresEspeciais = null;
      this.txtNomeMunicipio.PrtDesabilitarControle = false;
      this.txtNomeMunicipio.PrtGravaParametroTela = false;
      this.txtNomeMunicipio.PrtIniciaFocusControle = false;
      this.txtNomeMunicipio.PrtLabelDescricao = null;
      this.txtNomeMunicipio.PrtMensagemCampoObrigatorio = "Nome não pode ser vazio !";
      this.txtNomeMunicipio.PrtMontaTelaAutomatico = true;
      this.txtNomeMunicipio.PrtNaoLimparControle = false;
      this.txtNomeMunicipio.PrtNomeCampoBD = "Nome";
      this.txtNomeMunicipio.PrtNomeTabelaBD = "";
      this.txtNomeMunicipio.PrtOcultarAlertaErro = false;
      this.txtNomeMunicipio.PrtTabEnter = true;
      this.txtNomeMunicipio.PrtTamanhoMaximo = 100;
      this.txtNomeMunicipio.PrtTipoTexto = Controles.Enums.TipoTexto.TEXTO_MAIUSCULO;
      this.txtNomeMunicipio.PrtToolTipMensagem = null;
      this.txtNomeMunicipio.PrtValorPadrao = null;
      this.txtNomeMunicipio.Size = new System.Drawing.Size(479, 18);
      this.txtNomeMunicipio.TabIndex = 8;
      // 
      // labelEdit3
      // 
      this.labelEdit3.AutoSize = true;
      this.labelEdit3.BackColor = System.Drawing.Color.Transparent;
      this.labelEdit3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelEdit3.ForeColor = System.Drawing.Color.Black;
      this.labelEdit3.Location = new System.Drawing.Point(24, 172);
      this.labelEdit3.Name = "labelEdit3";
      this.labelEdit3.PrtMontaTelaAutomatico = false;
      this.labelEdit3.PrtNaoLimparControle = true;
      this.labelEdit3.PrtNomeCampoBD = "";
      this.labelEdit3.PrtValorPadrao = null;
      this.labelEdit3.Size = new System.Drawing.Size(43, 14);
      this.labelEdit3.TabIndex = 11;
      this.labelEdit3.Text = "Estado:";
      this.labelEdit3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // labelEdit2
      // 
      this.labelEdit2.AutoSize = true;
      this.labelEdit2.BackColor = System.Drawing.Color.Transparent;
      this.labelEdit2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelEdit2.ForeColor = System.Drawing.Color.Black;
      this.labelEdit2.Location = new System.Drawing.Point(24, 140);
      this.labelEdit2.Name = "labelEdit2";
      this.labelEdit2.PrtMontaTelaAutomatico = false;
      this.labelEdit2.PrtNaoLimparControle = true;
      this.labelEdit2.PrtNomeCampoBD = "";
      this.labelEdit2.PrtValorPadrao = null;
      this.labelEdit2.Size = new System.Drawing.Size(54, 14);
      this.labelEdit2.TabIndex = 10;
      this.labelEdit2.Text = "Município:";
      this.labelEdit2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // labelEdit1
      // 
      this.labelEdit1.AutoSize = true;
      this.labelEdit1.BackColor = System.Drawing.Color.Transparent;
      this.labelEdit1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelEdit1.ForeColor = System.Drawing.Color.Black;
      this.labelEdit1.Location = new System.Drawing.Point(24, 112);
      this.labelEdit1.Name = "labelEdit1";
      this.labelEdit1.PrtMontaTelaAutomatico = false;
      this.labelEdit1.PrtNaoLimparControle = true;
      this.labelEdit1.PrtNomeCampoBD = "";
      this.labelEdit1.PrtValorPadrao = null;
      this.labelEdit1.Size = new System.Drawing.Size(43, 14);
      this.labelEdit1.TabIndex = 12;
      this.labelEdit1.Text = "Código:";
      this.labelEdit1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // frmCadMunicipio
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(603, 250);
      this.Name = "frmCadMunicipio";
      this.Text = "frmCadMunicipio";
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

        private Controles.LabelEdit labelEdit1;
        private Controles.ComboBoxEdit cboEstado;
        private Controles.TextBoxEdit txtCodMunicipio;
        private Controles.TextBoxEdit txtNomeMunicipio;
        private Controles.LabelEdit labelEdit3;
        private Controles.LabelEdit labelEdit2;
    }
}