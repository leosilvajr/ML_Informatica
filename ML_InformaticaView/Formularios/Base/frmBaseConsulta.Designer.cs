namespace ML_InformaticaView.Formularios.Base
{
  partial class frmBaseConsulta
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.txtPesquisa = new Controles.MaskedTextBoxEdit();
      this.btnTipoBusca = new Controles.ButtonEdit();
      this.chkPesquisaDigito = new Controles.CheckBoxEdit();
      this.labelEdit2 = new Controles.LabelEdit();
      this.labelEdit1 = new Controles.LabelEdit();
      this.cboFiltro = new Controles.ComboBoxEdit();
      this.cboPesquisa = new Controles.ComboBoxEdit();
      this.dgvGrid = new Controles.DataGridViewEdit();
      this.ssrConsulta = new Controles.StatusStripEdit();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.ssrQtdReg = new System.Windows.Forms.ToolStripStatusLabel();
      this.pnlTopo.SuspendLayout();
      this.pnlBase.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
      this.ssrConsulta.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlTopo
      // 
      this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
      this.pnlTopo.Size = new System.Drawing.Size(653, 29);
      // 
      // pnlBase
      // 
      this.pnlBase.Controls.Add(this.ssrConsulta);
      this.pnlBase.Controls.Add(this.dgvGrid);
      this.pnlBase.Controls.Add(this.labelEdit2);
      this.pnlBase.Controls.Add(this.labelEdit1);
      this.pnlBase.Controls.Add(this.cboFiltro);
      this.pnlBase.Controls.Add(this.cboPesquisa);
      this.pnlBase.Controls.Add(this.chkPesquisaDigito);
      this.pnlBase.Controls.Add(this.txtPesquisa);
      this.pnlBase.Controls.Add(this.btnTipoBusca);
      this.pnlBase.Size = new System.Drawing.Size(653, 416);
      // 
      // btnSair
      // 
      this.btnSair.FlatAppearance.BorderSize = 0;
      this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
      this.btnSair.Location = new System.Drawing.Point(629, 0);
      // 
      // btnMinimizar
      // 
      this.btnMinimizar.FlatAppearance.BorderSize = 0;
      this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
      this.btnMinimizar.Location = new System.Drawing.Point(605, 0);
      // 
      // lblTituloForm
      // 
      this.lblTituloForm.Size = new System.Drawing.Size(156, 17);
      this.lblTituloForm.Text = "Formulário Base Consulta";
      // 
      // txtPesquisa
      // 
      this.txtPesquisa.BackColor = System.Drawing.Color.White;
      this.txtPesquisa.Font = new System.Drawing.Font("Arial", 8F);
      this.txtPesquisa.ForeColor = System.Drawing.Color.Black;
      this.txtPesquisa.Location = new System.Drawing.Point(5, 68);
      this.txtPesquisa.Name = "txtPesquisa";
      this.txtPesquisa.PromptChar = ' ';
      this.txtPesquisa.PrtAceitaValorNegativo = false;
      this.txtPesquisa.PrtAtivaPesquisa = false;
      this.txtPesquisa.PrtAtivarUpperCase = true;
      this.txtPesquisa.PrtAtivaValidacao = true;
      this.txtPesquisa.PrtCampoObrigatorio = false;
      this.txtPesquisa.PrtDesabilitarControle = false;
      this.txtPesquisa.PrtGravaParametroTela = false;
      this.txtPesquisa.PrtIniciaFocusControle = true;
      this.txtPesquisa.PrtLabelDescricao = null;
      this.txtPesquisa.PrtManterAlinhamentoLeft = false;
      this.txtPesquisa.PrtMensagemCampoObrigatorio = "Campo não pode ser vazio !";
      this.txtPesquisa.PrtMontaTelaAutomatico = true;
      this.txtPesquisa.PrtNaoLimparControle = false;
      this.txtPesquisa.PrtNomeCampoBD = null;
      this.txtPesquisa.PrtNomeTabelaBD = null;
      this.txtPesquisa.PrtQtdCasaDecimal = 2;
      this.txtPesquisa.PrtQtdeCaracteresPermitido = 0;
      this.txtPesquisa.PrtTabEnter = false;
      this.txtPesquisa.PrtTipoCampo = Controles.Enums.TipoCampo.TEXTO;
      this.txtPesquisa.PrtToolTipMensagem = null;
      this.txtPesquisa.PrtValidaCampo = true;
      this.txtPesquisa.PrtValorMaximoPermitido = new decimal(new int[] {
            60,
            0,
            0,
            0});
      this.txtPesquisa.PrtValorPadrao = null;
      this.txtPesquisa.Size = new System.Drawing.Size(640, 25);
      this.txtPesquisa.TabIndex = 3;
      this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
      this.txtPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyDown_1);
      this.txtPesquisa.Validating += new System.ComponentModel.CancelEventHandler(this.txtPesquisa_Validating);
      // 
      // btnTipoBusca
      // 
      this.btnTipoBusca.BackColor = System.Drawing.Color.Transparent;
      this.btnTipoBusca.FlatAppearance.BorderSize = 2;
      this.btnTipoBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnTipoBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
      this.btnTipoBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnTipoBusca.Location = new System.Drawing.Point(5, 13);
      this.btnTipoBusca.Name = "btnTipoBusca";
      this.btnTipoBusca.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.btnTipoBusca.PrtDesabilitarControle = false;
      this.btnTipoBusca.PrtEstiloBotao = Controles.Enums.TipoEstiloBotao.Nenhum;
      this.btnTipoBusca.PrtImagemAlinhamento = Controles.Enums.ImagemAlignmento.MiddleLeft;
      this.btnTipoBusca.PrtIniciaFocusControle = false;
      this.btnTipoBusca.PrtToolTipMensagem = null;
      this.btnTipoBusca.Size = new System.Drawing.Size(251, 28);
      this.btnTipoBusca.TabIndex = 4;
      this.btnTipoBusca.Text = "Contenha";
      this.btnTipoBusca.UseVisualStyleBackColor = false;
      this.btnTipoBusca.Click += new System.EventHandler(this.btnTipoBusca_Click);
      // 
      // chkPesquisaDigito
      // 
      this.chkPesquisaDigito.AutoSize = true;
      this.chkPesquisaDigito.BackColor = System.Drawing.Color.Transparent;
      this.chkPesquisaDigito.Font = new System.Drawing.Font("Arial", 8F);
      this.chkPesquisaDigito.ForeColor = System.Drawing.Color.Black;
      this.chkPesquisaDigito.Location = new System.Drawing.Point(8, 44);
      this.chkPesquisaDigito.Name = "chkPesquisaDigito";
      this.chkPesquisaDigito.PrtAceitaValorNulo = false;
      this.chkPesquisaDigito.PrtAtivaValidacao = true;
      this.chkPesquisaDigito.PrtDesabilitarControle = true;
      this.chkPesquisaDigito.PrtGravaParametroTela = false;
      this.chkPesquisaDigito.PrtIniciaFocusControle = false;
      this.chkPesquisaDigito.PrtLabelDescricao = null;
      this.chkPesquisaDigito.PrtMensagemCampoObrigatorio = "Campo não pode ser vazio !";
      this.chkPesquisaDigito.PrtMontaTelaAutomatico = true;
      this.chkPesquisaDigito.PrtNaoLimparControle = false;
      this.chkPesquisaDigito.PrtNomeCampoBD = null;
      this.chkPesquisaDigito.PrtNomeTabelaBD = null;
      this.chkPesquisaDigito.PrtOcultarAlertaErro = false;
      this.chkPesquisaDigito.PrtTabEnter = true;
      this.chkPesquisaDigito.PrtToolTipMensagem = null;
      this.chkPesquisaDigito.PrtValorPadrao = null;
      this.chkPesquisaDigito.Size = new System.Drawing.Size(134, 18);
      this.chkPesquisaDigito.TabIndex = 5;
      this.chkPesquisaDigito.Text = "Pesquisa a cada dígito";
      this.chkPesquisaDigito.UseVisualStyleBackColor = false;
      // 
      // labelEdit2
      // 
      this.labelEdit2.AutoSize = true;
      this.labelEdit2.BackColor = System.Drawing.Color.Transparent;
      this.labelEdit2.Font = new System.Drawing.Font("Arial", 8F);
      this.labelEdit2.ForeColor = System.Drawing.Color.Black;
      this.labelEdit2.Location = new System.Drawing.Point(453, 3);
      this.labelEdit2.Name = "labelEdit2";
      this.labelEdit2.PrtMontaTelaAutomatico = false;
      this.labelEdit2.PrtNaoLimparControle = true;
      this.labelEdit2.PrtNomeCampoBD = "";
      this.labelEdit2.PrtValorPadrao = null;
      this.labelEdit2.Size = new System.Drawing.Size(30, 14);
      this.labelEdit2.TabIndex = 10;
      this.labelEdit2.Text = "Filtro";
      this.labelEdit2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // labelEdit1
      // 
      this.labelEdit1.AutoSize = true;
      this.labelEdit1.BackColor = System.Drawing.Color.Transparent;
      this.labelEdit1.Font = new System.Drawing.Font("Arial", 8F);
      this.labelEdit1.ForeColor = System.Drawing.Color.Black;
      this.labelEdit1.Location = new System.Drawing.Point(259, 2);
      this.labelEdit1.Name = "labelEdit1";
      this.labelEdit1.PrtMontaTelaAutomatico = false;
      this.labelEdit1.PrtNaoLimparControle = true;
      this.labelEdit1.PrtNomeCampoBD = "";
      this.labelEdit1.PrtValorPadrao = null;
      this.labelEdit1.Size = new System.Drawing.Size(74, 14);
      this.labelEdit1.TabIndex = 8;
      this.labelEdit1.Text = "Pesquisar por";
      this.labelEdit1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // cboFiltro
      // 
      this.cboFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.cboFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.cboFiltro.BackColor = System.Drawing.Color.White;
      this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboFiltro.Font = new System.Drawing.Font("Arial", 8F);
      this.cboFiltro.ForeColor = System.Drawing.Color.Black;
      this.cboFiltro.FormattingEnabled = true;
      this.cboFiltro.Location = new System.Drawing.Point(456, 19);
      this.cboFiltro.Name = "cboFiltro";
      this.cboFiltro.PrtAceitaEspaco = false;
      this.cboFiltro.PrtAceitaNumeros = false;
      this.cboFiltro.PrtAtivaPesquisa = false;
      this.cboFiltro.PrtAtivaValidacao = true;
      this.cboFiltro.PrtCampoObrigatorio = false;
      this.cboFiltro.PrtCaracteresEspeciais = null;
      this.cboFiltro.PrtDesabilitarControle = true;
      this.cboFiltro.PrtGravaParametroTela = false;
      this.cboFiltro.PrtIniciaFocusControle = false;
      this.cboFiltro.PrtLabelDescricao = null;
      this.cboFiltro.PrtMensagemCampoObrigatorio = "Campo não pode ser vazio !";
      this.cboFiltro.PrtMontaTelaAutomatico = true;
      this.cboFiltro.PrtNaoLimparControle = false;
      this.cboFiltro.PrtNomeCampoBD = null;
      this.cboFiltro.PrtNomeTabelaBD = null;
      this.cboFiltro.PrtOcultarAlertaErro = false;
      this.cboFiltro.PrtTabEnter = true;
      this.cboFiltro.PrtTipoTexto = Controles.Enums.TipoTexto.TEXTO_MAIUSCULO;
      this.cboFiltro.PrtToolTipMensagem = null;
      this.cboFiltro.PrtValorPadrao = null;
      this.cboFiltro.Size = new System.Drawing.Size(189, 22);
      this.cboFiltro.TabIndex = 9;
      // 
      // cboPesquisa
      // 
      this.cboPesquisa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.cboPesquisa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.cboPesquisa.BackColor = System.Drawing.Color.White;
      this.cboPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboPesquisa.Font = new System.Drawing.Font("Arial", 8F);
      this.cboPesquisa.ForeColor = System.Drawing.Color.Black;
      this.cboPesquisa.FormattingEnabled = true;
      this.cboPesquisa.Location = new System.Drawing.Point(262, 19);
      this.cboPesquisa.Name = "cboPesquisa";
      this.cboPesquisa.PrtAceitaEspaco = false;
      this.cboPesquisa.PrtAceitaNumeros = false;
      this.cboPesquisa.PrtAtivaPesquisa = false;
      this.cboPesquisa.PrtAtivaValidacao = true;
      this.cboPesquisa.PrtCampoObrigatorio = false;
      this.cboPesquisa.PrtCaracteresEspeciais = null;
      this.cboPesquisa.PrtDesabilitarControle = true;
      this.cboPesquisa.PrtGravaParametroTela = false;
      this.cboPesquisa.PrtIniciaFocusControle = false;
      this.cboPesquisa.PrtLabelDescricao = null;
      this.cboPesquisa.PrtMensagemCampoObrigatorio = "Campo não pode ser vazio !";
      this.cboPesquisa.PrtMontaTelaAutomatico = true;
      this.cboPesquisa.PrtNaoLimparControle = false;
      this.cboPesquisa.PrtNomeCampoBD = null;
      this.cboPesquisa.PrtNomeTabelaBD = null;
      this.cboPesquisa.PrtOcultarAlertaErro = false;
      this.cboPesquisa.PrtTabEnter = true;
      this.cboPesquisa.PrtTipoTexto = Controles.Enums.TipoTexto.TEXTO_MAIUSCULO;
      this.cboPesquisa.PrtToolTipMensagem = null;
      this.cboPesquisa.PrtValorPadrao = null;
      this.cboPesquisa.Size = new System.Drawing.Size(189, 22);
      this.cboPesquisa.TabIndex = 7;
      this.cboPesquisa.SelectedValueChanged += new System.EventHandler(this.cboPesquisa_SelectedValueChanged);
      // 
      // dgvGrid
      // 
      this.dgvGrid.AllowUserToOrderColumns = true;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.MintCream;
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
      this.dgvGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvGrid.BackgroundColor = System.Drawing.SystemColors.Control;
      this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8F);
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Khaki;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvGrid.DefaultCellStyle = dataGridViewCellStyle2;
      this.dgvGrid.Font = new System.Drawing.Font("Arial", 8F);
      this.dgvGrid.Location = new System.Drawing.Point(6, 99);
      this.dgvGrid.Name = "dgvGrid";
      this.dgvGrid.PrtDesabilitarControle = false;
      this.dgvGrid.PrtIniciaFocusControle = false;
      this.dgvGrid.PrtTipoSelecaoLinha = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Khaki;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
      this.dgvGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
      this.dgvGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvGrid.Size = new System.Drawing.Size(639, 284);
      this.dgvGrid.TabIndex = 11;
      this.dgvGrid.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvGrid_ColumnWidthChanged);
      this.dgvGrid.DoubleClick += new System.EventHandler(this.dgvGrid_DoubleClick);
      this.dgvGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvGrid_KeyDown);
      this.dgvGrid.Leave += new System.EventHandler(this.dgvGrid_Leave);
      // 
      // ssrConsulta
      // 
      this.ssrConsulta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.ssrQtdReg});
      this.ssrConsulta.Location = new System.Drawing.Point(0, 394);
      this.ssrConsulta.Name = "ssrConsulta";
      this.ssrConsulta.Size = new System.Drawing.Size(653, 22);
      this.ssrConsulta.TabIndex = 12;
      this.ssrConsulta.Text = "statusStripEdit1";
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(136, 17);
      this.toolStripStatusLabel1.Text = "Quantidade de Registros";
      // 
      // ssrQtdReg
      // 
      this.ssrQtdReg.Name = "ssrQtdReg";
      this.ssrQtdReg.Size = new System.Drawing.Size(25, 17);
      this.ssrQtdReg.Text = "999";
      // 
      // frmBaseConsulta
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
      this.ClientSize = new System.Drawing.Size(663, 450);
      this.Name = "frmBaseConsulta";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "frmBaseConsulta";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBaseConsulta_FormClosing);
      this.Shown += new System.EventHandler(this.frmBaseConsulta_Shown);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBaseConsulta_KeyDown);
      this.pnlTopo.ResumeLayout(false);
      this.pnlTopo.PerformLayout();
      this.pnlBase.ResumeLayout(false);
      this.pnlBase.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
      this.ssrConsulta.ResumeLayout(false);
      this.ssrConsulta.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        protected Controles.MaskedTextBoxEdit txtPesquisa;
        protected Controles.ButtonEdit btnTipoBusca;
        protected Controles.CheckBoxEdit chkPesquisaDigito;
        protected Controles.DataGridViewEdit dgvGrid;
        protected Controles.LabelEdit labelEdit2;
        protected Controles.LabelEdit labelEdit1;
        protected Controles.ComboBoxEdit cboFiltro;
        protected Controles.ComboBoxEdit cboPesquisa;
        protected Controles.StatusStripEdit ssrConsulta;
        protected System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        protected System.Windows.Forms.ToolStripStatusLabel ssrQtdReg;
    }
}