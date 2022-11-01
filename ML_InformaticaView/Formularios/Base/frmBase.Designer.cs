namespace Funcionarios.Formularios
{
  partial class frmBase
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
            this.pnlBase = new Controles.PanelEdit();
            this.pnlTopo = new Controles.PanelEdit();
            this.lblTituloForm = new Controles.LabelEdit();
            this.btnMinimizar = new Controles.ButtonEdit();
            this.btnSair = new Controles.ButtonEdit();
            this.pnlTopo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBase
            // 
            this.pnlBase.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBase.Location = new System.Drawing.Point(5, 29);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.PrtBorderColor = System.Drawing.Color.Transparent;
            this.pnlBase.Size = new System.Drawing.Size(874, 527);
            this.pnlBase.TabIndex = 1;
            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pnlTopo.Controls.Add(this.lblTituloForm);
            this.pnlTopo.Controls.Add(this.btnMinimizar);
            this.pnlTopo.Controls.Add(this.btnSair);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(5, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.PrtBorderColor = System.Drawing.Color.Transparent;
            this.pnlTopo.Size = new System.Drawing.Size(874, 29);
            this.pnlTopo.TabIndex = 0;
            this.pnlTopo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopo_MouseDown);
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloForm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloForm.ForeColor = System.Drawing.Color.White;
            this.lblTituloForm.Location = new System.Drawing.Point(3, 6);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.PrtMontaTelaAutomatico = false;
            this.lblTituloForm.PrtNaoLimparControle = true;
            this.lblTituloForm.PrtNomeCampoBD = "";
            this.lblTituloForm.PrtValorPadrao = null;
            this.lblTituloForm.Size = new System.Drawing.Size(127, 17);
            this.lblTituloForm.TabIndex = 2;
            this.lblTituloForm.Text = "Titulo do Formulário";
            this.lblTituloForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTituloForm_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::ML_InformaticaView.Properties.Resources.icons8_subtract_16;
            this.btnMinimizar.Location = new System.Drawing.Point(826, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnMinimizar.PrtDesabilitarControle = false;
            this.btnMinimizar.PrtEstiloBotao = Controles.Enums.TipoEstiloBotao.Nenhum;
            this.btnMinimizar.PrtImagemAlinhamento = Controles.Enums.ImagemAlignmento.MiddleCenter;
            this.btnMinimizar.PrtIniciaFocusControle = false;
            this.btnMinimizar.PrtToolTipMensagem = null;
            this.btnMinimizar.Size = new System.Drawing.Size(24, 29);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = global::ML_InformaticaView.Properties.Resources.icons8_close_162;
            this.btnSair.Location = new System.Drawing.Point(850, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSair.PrtDesabilitarControle = false;
            this.btnSair.PrtEstiloBotao = Controles.Enums.TipoEstiloBotao.Nenhum;
            this.btnSair.PrtImagemAlinhamento = Controles.Enums.ImagemAlignmento.MiddleCenter;
            this.btnSair.PrtIniciaFocusControle = false;
            this.btnSair.PrtToolTipMensagem = null;
            this.btnSair.Size = new System.Drawing.Size(24, 29);
            this.btnSair.TabIndex = 0;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pnlBase);
            this.Controls.Add(this.pnlTopo);
            this.Name = "frmBase";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Text = "frmBase";
            this.Shown += new System.EventHandler(this.frmBase_Shown);
            this.Move += new System.EventHandler(this.frmBase_Move);
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.ResumeLayout(false);

    }

        #endregion

        protected Controles.PanelEdit pnlTopo;
        protected Controles.PanelEdit pnlBase;
        protected Controles.ButtonEdit btnSair;
        protected Controles.ButtonEdit btnMinimizar;
        protected Controles.LabelEdit lblTituloForm;
    }
}