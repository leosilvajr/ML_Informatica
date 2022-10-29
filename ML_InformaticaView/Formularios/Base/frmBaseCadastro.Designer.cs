namespace ML_InformaticaView.Formularios.Base
{
    partial class frmBaseCadastro
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
            this.pnlBaseCadastro = new Controles.PanelEdit();
            this.pnlStatus = new Controles.PanelEdit();
            this.lblStatus = new Controles.LabelEdit();
            this.pnlBotoesTopo = new Controles.PanelEdit();
            this.btnExit = new Controles.ButtonEdit();
            this.btnCancelar = new Controles.ButtonEdit();
            this.btnGravar = new Controles.ButtonEdit();
            this.btnProcurar = new Controles.ButtonEdit();
            this.btnExcluir = new Controles.ButtonEdit();
            this.btnIncluir = new Controles.ButtonEdit();
            this.pnlTopo.SuspendLayout();
            this.pnlBase.SuspendLayout();
            this.pnlBaseCadastro.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlBotoesTopo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopo
            // 
            this.pnlTopo.Size = new System.Drawing.Size(665, 29);
            // 
            // pnlBase
            // 
            this.pnlBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pnlBase.Controls.Add(this.pnlBaseCadastro);
            this.pnlBase.Size = new System.Drawing.Size(665, 416);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(641, 0);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnMinimizar.Location = new System.Drawing.Point(617, 0);
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.Location = new System.Drawing.Point(4, 6);
            this.lblTituloForm.Size = new System.Drawing.Size(147, 17);
            this.lblTituloForm.Text = "Formulário de Cadastro";
            // 
            // pnlBaseCadastro
            // 
            this.pnlBaseCadastro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlBaseCadastro.Controls.Add(this.pnlStatus);
            this.pnlBaseCadastro.Controls.Add(this.pnlBotoesTopo);
            this.pnlBaseCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBaseCadastro.Location = new System.Drawing.Point(0, 0);
            this.pnlBaseCadastro.Name = "pnlBaseCadastro";
            this.pnlBaseCadastro.Padding = new System.Windows.Forms.Padding(2);
            this.pnlBaseCadastro.PrtBorderColor = System.Drawing.Color.Transparent;
            this.pnlBaseCadastro.Size = new System.Drawing.Size(665, 416);
            this.pnlBaseCadastro.TabIndex = 0;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlStatus.Controls.Add(this.lblStatus);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatus.Location = new System.Drawing.Point(2, 68);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.PrtBorderColor = System.Drawing.Color.Transparent;
            this.pnlStatus.Size = new System.Drawing.Size(661, 26);
            this.pnlStatus.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Navy;
            this.lblStatus.Location = new System.Drawing.Point(242, 5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.PrtMontaTelaAutomatico = false;
            this.lblStatus.PrtNaoLimparControle = true;
            this.lblStatus.PrtNomeCampoBD = "";
            this.lblStatus.PrtValorPadrao = null;
            this.lblStatus.Size = new System.Drawing.Size(80, 17);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "INCLUINDO";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBotoesTopo
            // 
            this.pnlBotoesTopo.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlBotoesTopo.Controls.Add(this.btnExit);
            this.pnlBotoesTopo.Controls.Add(this.btnCancelar);
            this.pnlBotoesTopo.Controls.Add(this.btnGravar);
            this.pnlBotoesTopo.Controls.Add(this.btnProcurar);
            this.pnlBotoesTopo.Controls.Add(this.btnExcluir);
            this.pnlBotoesTopo.Controls.Add(this.btnIncluir);
            this.pnlBotoesTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoesTopo.Location = new System.Drawing.Point(2, 2);
            this.pnlBotoesTopo.Name = "pnlBotoesTopo";
            this.pnlBotoesTopo.PrtBorderColor = System.Drawing.Color.Transparent;
            this.pnlBotoesTopo.Size = new System.Drawing.Size(661, 66);
            this.pnlBotoesTopo.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Image = global::ML_InformaticaView.Properties.Resources.logout1;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(569, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnExit.PrtDesabilitarControle = false;
            this.btnExit.PrtEstiloBotao = Controles.Enums.TipoEstiloBotao.Nenhum;
            this.btnExit.PrtImagemAlinhamento = Controles.Enums.ImagemAlignmento.TopCenter;
            this.btnExit.PrtIniciaFocusControle = false;
            this.btnExit.PrtToolTipMensagem = null;
            this.btnExit.Size = new System.Drawing.Size(92, 66);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Sair";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Image = global::ML_InformaticaView.Properties.Resources.close;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(400, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCancelar.PrtDesabilitarControle = false;
            this.btnCancelar.PrtEstiloBotao = Controles.Enums.TipoEstiloBotao.Nenhum;
            this.btnCancelar.PrtImagemAlinhamento = Controles.Enums.ImagemAlignmento.TopCenter;
            this.btnCancelar.PrtIniciaFocusControle = false;
            this.btnCancelar.PrtToolTipMensagem = null;
            this.btnCancelar.Size = new System.Drawing.Size(100, 66);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.Transparent;
            this.btnGravar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGravar.FlatAppearance.BorderSize = 0;
            this.btnGravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.ForeColor = System.Drawing.Color.Black;
            this.btnGravar.Image = global::ML_InformaticaView.Properties.Resources.file;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGravar.Location = new System.Drawing.Point(300, 0);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnGravar.PrtDesabilitarControle = false;
            this.btnGravar.PrtEstiloBotao = Controles.Enums.TipoEstiloBotao.Nenhum;
            this.btnGravar.PrtImagemAlinhamento = Controles.Enums.ImagemAlignmento.TopCenter;
            this.btnGravar.PrtIniciaFocusControle = false;
            this.btnGravar.PrtToolTipMensagem = null;
            this.btnGravar.Size = new System.Drawing.Size(100, 66);
            this.btnGravar.TabIndex = 3;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackColor = System.Drawing.Color.Transparent;
            this.btnProcurar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProcurar.FlatAppearance.BorderSize = 0;
            this.btnProcurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurar.ForeColor = System.Drawing.Color.Black;
            this.btnProcurar.Image = global::ML_InformaticaView.Properties.Resources.search;
            this.btnProcurar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProcurar.Location = new System.Drawing.Point(200, 0);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnProcurar.PrtDesabilitarControle = false;
            this.btnProcurar.PrtEstiloBotao = Controles.Enums.TipoEstiloBotao.Nenhum;
            this.btnProcurar.PrtImagemAlinhamento = Controles.Enums.ImagemAlignmento.TopCenter;
            this.btnProcurar.PrtIniciaFocusControle = false;
            this.btnProcurar.PrtToolTipMensagem = null;
            this.btnProcurar.Size = new System.Drawing.Size(100, 66);
            this.btnProcurar.TabIndex = 2;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Image = global::ML_InformaticaView.Properties.Resources.delete;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(100, 0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnExcluir.PrtDesabilitarControle = false;
            this.btnExcluir.PrtEstiloBotao = Controles.Enums.TipoEstiloBotao.Nenhum;
            this.btnExcluir.PrtImagemAlinhamento = Controles.Enums.ImagemAlignmento.TopCenter;
            this.btnExcluir.PrtIniciaFocusControle = false;
            this.btnExcluir.PrtToolTipMensagem = null;
            this.btnExcluir.Size = new System.Drawing.Size(100, 66);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.Transparent;
            this.btnIncluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIncluir.FlatAppearance.BorderSize = 0;
            this.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.ForeColor = System.Drawing.Color.Black;
            this.btnIncluir.Image = global::ML_InformaticaView.Properties.Resources.add1;
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIncluir.Location = new System.Drawing.Point(0, 0);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnIncluir.PrtDesabilitarControle = false;
            this.btnIncluir.PrtEstiloBotao = Controles.Enums.TipoEstiloBotao.Nenhum;
            this.btnIncluir.PrtImagemAlinhamento = Controles.Enums.ImagemAlignmento.TopCenter;
            this.btnIncluir.PrtIniciaFocusControle = false;
            this.btnIncluir.PrtToolTipMensagem = null;
            this.btnIncluir.Size = new System.Drawing.Size(100, 66);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // frmBaseCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Name = "frmBaseCadastro";
            this.Text = "frmBaseCadastro";
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.pnlBase.ResumeLayout(false);
            this.pnlBaseCadastro.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.pnlBotoesTopo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected Controles.PanelEdit pnlBaseCadastro;
        protected Controles.PanelEdit pnlBotoesTopo;
        protected Controles.ButtonEdit btnIncluir;
        protected Controles.ButtonEdit btnExit;
        protected Controles.ButtonEdit btnCancelar;
        protected Controles.ButtonEdit btnGravar;
        protected Controles.ButtonEdit btnProcurar;
        protected Controles.ButtonEdit btnExcluir;
        protected Controles.PanelEdit pnlStatus;
        protected Controles.LabelEdit lblStatus;
    }
}