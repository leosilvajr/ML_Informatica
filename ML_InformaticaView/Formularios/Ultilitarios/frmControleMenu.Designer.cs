namespace ML_InformaticaView.Formularios.Ultilitarios
{
  partial class frmControleMenu
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
      this.btnCarregar = new Controles.ButtonEdit();
      this.treeView1 = new Controles.TreeViewEdit();
      this.pnlTopo.SuspendLayout();
      this.pnlBase.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlTopo
      // 
      this.pnlTopo.Size = new System.Drawing.Size(333, 29);
      // 
      // pnlBase
      // 
      this.pnlBase.Controls.Add(this.treeView1);
      this.pnlBase.Controls.Add(this.btnCarregar);
      this.pnlBase.Size = new System.Drawing.Size(333, 416);
      // 
      // btnSair
      // 
      this.btnSair.FlatAppearance.BorderSize = 0;
      this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
      this.btnSair.Location = new System.Drawing.Point(309, 0);
      // 
      // btnMinimizar
      // 
      this.btnMinimizar.FlatAppearance.BorderSize = 0;
      this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
      this.btnMinimizar.Location = new System.Drawing.Point(285, 0);
      // 
      // btnCarregar
      // 
      this.btnCarregar.BackColor = System.Drawing.Color.Transparent;
      this.btnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCarregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnCarregar.Location = new System.Drawing.Point(15, 19);
      this.btnCarregar.Name = "btnCarregar";
      this.btnCarregar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.btnCarregar.PrtDesabilitarControle = false;
      this.btnCarregar.PrtEstiloBotao = Controles.Enums.TipoEstiloBotao.Nenhum;
      this.btnCarregar.PrtImagemAlinhamento = Controles.Enums.ImagemAlignmento.MiddleLeft;
      this.btnCarregar.PrtIniciaFocusControle = false;
      this.btnCarregar.PrtToolTipMensagem = null;
      this.btnCarregar.Size = new System.Drawing.Size(142, 23);
      this.btnCarregar.TabIndex = 0;
      this.btnCarregar.Text = "Carregar";
      this.btnCarregar.UseVisualStyleBackColor = true;
      this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
      // 
      // treeView1
      // 
      this.treeView1.Location = new System.Drawing.Point(15, 48);
      this.treeView1.Name = "treeView1";
      this.treeView1.Size = new System.Drawing.Size(300, 353);
      this.treeView1.TabIndex = 1;
      this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
      // 
      // frmControleMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(343, 450);
      this.Name = "frmControleMenu";
      this.Text = "frmControleMenu";
      this.pnlTopo.ResumeLayout(false);
      this.pnlTopo.PerformLayout();
      this.pnlBase.ResumeLayout(false);
      this.ResumeLayout(false);

    }

        #endregion

        private Controles.ButtonEdit btnCarregar;
        private Controles.TreeViewEdit treeView1;
    }
}