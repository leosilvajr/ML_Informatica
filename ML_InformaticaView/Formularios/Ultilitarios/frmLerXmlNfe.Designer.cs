namespace ML_InformaticaView.Formularios.Ultilitarios
{
  partial class frmLerXmlNfe
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
      this.panelEdit1 = new Controles.PanelEdit();
      this.labelEdit1 = new Controles.LabelEdit();
      this.labelEdit2 = new Controles.LabelEdit();
      this.lblNfNum = new Controles.LabelEdit();
      this.labelEdit4 = new Controles.LabelEdit();
      this.lblNfData = new Controles.LabelEdit();
      this.lblNaturezaOperacao = new Controles.LabelEdit();
      this.labelEdit5 = new Controles.LabelEdit();
      this.lblValorTotal = new Controles.LabelEdit();
      this.labelEdit6 = new Controles.LabelEdit();
      this.btnAbrir = new Controles.ButtonEdit();
      this.listView = new Controles.ListViewEdit();
      this.item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.qtde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.unitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.pnlTopo.SuspendLayout();
      this.pnlBase.SuspendLayout();
      this.panelEdit1.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlTopo
      // 
      this.pnlTopo.Size = new System.Drawing.Size(779, 29);
      // 
      // pnlBase
      // 
      this.pnlBase.Controls.Add(this.listView);
      this.pnlBase.Controls.Add(this.btnAbrir);
      this.pnlBase.Controls.Add(this.lblValorTotal);
      this.pnlBase.Controls.Add(this.labelEdit6);
      this.pnlBase.Controls.Add(this.lblNaturezaOperacao);
      this.pnlBase.Controls.Add(this.labelEdit5);
      this.pnlBase.Controls.Add(this.lblNfData);
      this.pnlBase.Controls.Add(this.labelEdit4);
      this.pnlBase.Controls.Add(this.lblNfNum);
      this.pnlBase.Controls.Add(this.labelEdit2);
      this.pnlBase.Controls.Add(this.panelEdit1);
      this.pnlBase.Size = new System.Drawing.Size(779, 416);
      // 
      // btnSair
      // 
      this.btnSair.FlatAppearance.BorderSize = 0;
      this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
      this.btnSair.Location = new System.Drawing.Point(755, 0);
      // 
      // btnMinimizar
      // 
      this.btnMinimizar.FlatAppearance.BorderSize = 0;
      this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
      this.btnMinimizar.Location = new System.Drawing.Point(731, 0);
      // 
      // panelEdit1
      // 
      this.panelEdit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.panelEdit1.Controls.Add(this.labelEdit1);
      this.panelEdit1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelEdit1.Location = new System.Drawing.Point(0, 0);
      this.panelEdit1.Name = "panelEdit1";
      this.panelEdit1.PrtBorderColor = System.Drawing.Color.Transparent;
      this.panelEdit1.Size = new System.Drawing.Size(779, 33);
      this.panelEdit1.TabIndex = 0;
      // 
      // labelEdit1
      // 
      this.labelEdit1.AutoSize = true;
      this.labelEdit1.BackColor = System.Drawing.Color.Transparent;
      this.labelEdit1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelEdit1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
      this.labelEdit1.Location = new System.Drawing.Point(305, 3);
      this.labelEdit1.Name = "labelEdit1";
      this.labelEdit1.PrtMontaTelaAutomatico = false;
      this.labelEdit1.PrtNaoLimparControle = true;
      this.labelEdit1.PrtNomeCampoBD = "";
      this.labelEdit1.PrtValorPadrao = null;
      this.labelEdit1.Size = new System.Drawing.Size(188, 25);
      this.labelEdit1.TabIndex = 0;
      this.labelEdit1.Text = "Lendo XML da NF-e";
      this.labelEdit1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // labelEdit2
      // 
      this.labelEdit2.AutoSize = true;
      this.labelEdit2.BackColor = System.Drawing.Color.Transparent;
      this.labelEdit2.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.labelEdit2.ForeColor = System.Drawing.Color.Black;
      this.labelEdit2.Location = new System.Drawing.Point(14, 45);
      this.labelEdit2.Name = "labelEdit2";
      this.labelEdit2.PrtMontaTelaAutomatico = false;
      this.labelEdit2.PrtNaoLimparControle = true;
      this.labelEdit2.PrtNomeCampoBD = "";
      this.labelEdit2.PrtValorPadrao = null;
      this.labelEdit2.Size = new System.Drawing.Size(81, 19);
      this.labelEdit2.TabIndex = 1;
      this.labelEdit2.Text = "Nº da NF-e:";
      this.labelEdit2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblNfNum
      // 
      this.lblNfNum.BackColor = System.Drawing.Color.Transparent;
      this.lblNfNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblNfNum.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.lblNfNum.ForeColor = System.Drawing.Color.Black;
      this.lblNfNum.Location = new System.Drawing.Point(101, 45);
      this.lblNfNum.Name = "lblNfNum";
      this.lblNfNum.PrtMontaTelaAutomatico = false;
      this.lblNfNum.PrtNaoLimparControle = true;
      this.lblNfNum.PrtNomeCampoBD = "";
      this.lblNfNum.PrtValorPadrao = null;
      this.lblNfNum.Size = new System.Drawing.Size(105, 21);
      this.lblNfNum.TabIndex = 2;
      this.lblNfNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // labelEdit4
      // 
      this.labelEdit4.AutoSize = true;
      this.labelEdit4.BackColor = System.Drawing.Color.Transparent;
      this.labelEdit4.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.labelEdit4.ForeColor = System.Drawing.Color.Black;
      this.labelEdit4.Location = new System.Drawing.Point(455, 45);
      this.labelEdit4.Name = "labelEdit4";
      this.labelEdit4.PrtMontaTelaAutomatico = false;
      this.labelEdit4.PrtNaoLimparControle = true;
      this.labelEdit4.PrtNomeCampoBD = "";
      this.labelEdit4.PrtValorPadrao = null;
      this.labelEdit4.Size = new System.Drawing.Size(113, 19);
      this.labelEdit4.TabIndex = 3;
      this.labelEdit4.Text = "Data da Emissão:";
      this.labelEdit4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblNfData
      // 
      this.lblNfData.BackColor = System.Drawing.Color.Transparent;
      this.lblNfData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblNfData.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.lblNfData.ForeColor = System.Drawing.Color.Black;
      this.lblNfData.Location = new System.Drawing.Point(574, 44);
      this.lblNfData.Name = "lblNfData";
      this.lblNfData.PrtMontaTelaAutomatico = false;
      this.lblNfData.PrtNaoLimparControle = true;
      this.lblNfData.PrtNomeCampoBD = "";
      this.lblNfData.PrtValorPadrao = null;
      this.lblNfData.Size = new System.Drawing.Size(190, 21);
      this.lblNfData.TabIndex = 4;
      this.lblNfData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblNaturezaOperacao
      // 
      this.lblNaturezaOperacao.BackColor = System.Drawing.Color.Transparent;
      this.lblNaturezaOperacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblNaturezaOperacao.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.lblNaturezaOperacao.ForeColor = System.Drawing.Color.Black;
      this.lblNaturezaOperacao.Location = new System.Drawing.Point(166, 79);
      this.lblNaturezaOperacao.Name = "lblNaturezaOperacao";
      this.lblNaturezaOperacao.PrtMontaTelaAutomatico = false;
      this.lblNaturezaOperacao.PrtNaoLimparControle = true;
      this.lblNaturezaOperacao.PrtNomeCampoBD = "";
      this.lblNaturezaOperacao.PrtValorPadrao = null;
      this.lblNaturezaOperacao.Size = new System.Drawing.Size(598, 21);
      this.lblNaturezaOperacao.TabIndex = 6;
      this.lblNaturezaOperacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // labelEdit5
      // 
      this.labelEdit5.AutoSize = true;
      this.labelEdit5.BackColor = System.Drawing.Color.Transparent;
      this.labelEdit5.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.labelEdit5.ForeColor = System.Drawing.Color.Black;
      this.labelEdit5.Location = new System.Drawing.Point(14, 79);
      this.labelEdit5.Name = "labelEdit5";
      this.labelEdit5.PrtMontaTelaAutomatico = false;
      this.labelEdit5.PrtNaoLimparControle = true;
      this.labelEdit5.PrtNomeCampoBD = "";
      this.labelEdit5.PrtValorPadrao = null;
      this.labelEdit5.Size = new System.Drawing.Size(146, 19);
      this.labelEdit5.TabIndex = 5;
      this.labelEdit5.Text = "Natureza da Operação";
      this.labelEdit5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblValorTotal
      // 
      this.lblValorTotal.BackColor = System.Drawing.Color.Transparent;
      this.lblValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblValorTotal.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.lblValorTotal.ForeColor = System.Drawing.Color.Black;
      this.lblValorTotal.Location = new System.Drawing.Point(101, 378);
      this.lblValorTotal.Name = "lblValorTotal";
      this.lblValorTotal.PrtMontaTelaAutomatico = false;
      this.lblValorTotal.PrtNaoLimparControle = true;
      this.lblValorTotal.PrtNomeCampoBD = "";
      this.lblValorTotal.PrtValorPadrao = null;
      this.lblValorTotal.Size = new System.Drawing.Size(105, 21);
      this.lblValorTotal.TabIndex = 8;
      this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // labelEdit6
      // 
      this.labelEdit6.AutoSize = true;
      this.labelEdit6.BackColor = System.Drawing.Color.Transparent;
      this.labelEdit6.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.labelEdit6.ForeColor = System.Drawing.Color.Black;
      this.labelEdit6.Location = new System.Drawing.Point(14, 378);
      this.labelEdit6.Name = "labelEdit6";
      this.labelEdit6.PrtMontaTelaAutomatico = false;
      this.labelEdit6.PrtNaoLimparControle = true;
      this.labelEdit6.PrtNomeCampoBD = "";
      this.labelEdit6.PrtValorPadrao = null;
      this.labelEdit6.Size = new System.Drawing.Size(76, 19);
      this.labelEdit6.TabIndex = 7;
      this.labelEdit6.Text = "Valor Total:";
      this.labelEdit6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btnAbrir
      // 
      this.btnAbrir.BackColor = System.Drawing.Color.Transparent;
      this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAbrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnAbrir.Location = new System.Drawing.Point(657, 378);
      this.btnAbrir.Name = "btnAbrir";
      this.btnAbrir.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.btnAbrir.PrtDesabilitarControle = false;
      this.btnAbrir.PrtEstiloBotao = Controles.Enums.TipoEstiloBotao.Nenhum;
      this.btnAbrir.PrtImagemAlinhamento = Controles.Enums.ImagemAlignmento.MiddleLeft;
      this.btnAbrir.PrtIniciaFocusControle = false;
      this.btnAbrir.PrtToolTipMensagem = null;
      this.btnAbrir.Size = new System.Drawing.Size(107, 23);
      this.btnAbrir.TabIndex = 9;
      this.btnAbrir.Text = "Abrir";
      this.btnAbrir.UseVisualStyleBackColor = true;
      this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
      // 
      // listView
      // 
      this.listView.BackColor = System.Drawing.Color.White;
      this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.item,
            this.id,
            this.descricao,
            this.qtde,
            this.unitario,
            this.valor});
      this.listView.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.listView.ForeColor = System.Drawing.Color.Black;
      this.listView.FullRowSelect = true;
      this.listView.HideSelection = false;
      this.listView.Location = new System.Drawing.Point(18, 111);
      this.listView.Name = "listView";
      this.listView.Size = new System.Drawing.Size(746, 255);
      this.listView.TabIndex = 10;
      this.listView.UseCompatibleStateImageBehavior = false;
      this.listView.View = System.Windows.Forms.View.Details;
      // 
      // item
      // 
      this.item.Text = "Item";
      this.item.Width = 40;
      // 
      // id
      // 
      this.id.Text = "ID";
      this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // descricao
      // 
      this.descricao.Text = "Descrição do Produto";
      this.descricao.Width = 310;
      // 
      // qtde
      // 
      this.qtde.Text = "Quantidade";
      this.qtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.qtde.Width = 100;
      // 
      // unitario
      // 
      this.unitario.Text = "Unitário";
      this.unitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.unitario.Width = 100;
      // 
      // valor
      // 
      this.valor.Text = "Valor";
      this.valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.valor.Width = 120;
      // 
      // frmLerXmlNfe
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(789, 450);
      this.Name = "frmLerXmlNfe";
      this.Text = "frmLerXmlNfe";
      this.pnlTopo.ResumeLayout(false);
      this.pnlTopo.PerformLayout();
      this.pnlBase.ResumeLayout(false);
      this.pnlBase.PerformLayout();
      this.panelEdit1.ResumeLayout(false);
      this.panelEdit1.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private Controles.LabelEdit lblNfNum;
        private Controles.LabelEdit labelEdit2;
        private Controles.PanelEdit panelEdit1;
        private Controles.LabelEdit labelEdit1;
        private Controles.ButtonEdit btnAbrir;
        private Controles.LabelEdit lblValorTotal;
        private Controles.LabelEdit labelEdit6;
        private Controles.LabelEdit lblNaturezaOperacao;
        private Controles.LabelEdit labelEdit5;
        private Controles.LabelEdit lblNfData;
        private Controles.LabelEdit labelEdit4;
        private Controles.ListViewEdit listView;
        private System.Windows.Forms.ColumnHeader item;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader descricao;
        private System.Windows.Forms.ColumnHeader qtde;
        private System.Windows.Forms.ColumnHeader unitario;
        private System.Windows.Forms.ColumnHeader valor;
    }
}