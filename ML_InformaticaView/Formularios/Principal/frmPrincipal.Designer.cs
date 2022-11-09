namespace ML_InformaticaView.Formularios.Principal
{
    partial class frmPrincipal
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
      this.pnlMenu = new Controles.PanelEdit();
      this.btnEncerrar = new Controles.ButtonEdit();
      this.btnUltilitarios = new Controles.ButtonEdit();
      this.btnConfiguracoes = new Controles.ButtonEdit();
      this.btnRelatorios = new Controles.ButtonEdit();
      this.btnCadastros = new Controles.ButtonEdit();
      this.btnInicio = new Controles.ButtonEdit();
      this.pnlArtMenu = new Controles.PanelEdit();
      this.lblMenu = new Controles.LabelEdit();
      this.picMenu = new Controles.PictureBoxEdit();
      this.pnlBarraDireita = new Controles.PanelEdit();
      this.pnlRodape = new Controles.PanelEdit();
      this.lblHorario = new Controles.LabelEdit();
      this.lblData = new Controles.LabelEdit();
      this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
      this.menuStripConfiguracoes = new Controles.MenuStripEdit();
      this.bancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.configurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.controleDeAcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.habilitarDesabilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStripCadastros = new Controles.MenuStripEdit();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.municípiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStripRelatorios = new Controles.MenuStripEdit();
      this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.movimentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStripUltilitarios = new Controles.MenuStripEdit();
      this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
      this.nFeSEFAZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.leituraXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.timer = new System.Windows.Forms.Timer(this.components);
      this.pnlTopo.SuspendLayout();
      this.pnlBase.SuspendLayout();
      this.pnlMenu.SuspendLayout();
      this.pnlArtMenu.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
      this.pnlRodape.SuspendLayout();
      this.menuStripConfiguracoes.SuspendLayout();
      this.menuStripCadastros.SuspendLayout();
      this.menuStripRelatorios.SuspendLayout();
      this.menuStripUltilitarios.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlTopo
      // 
      this.pnlTopo.Location = new System.Drawing.Point(200, 0);
      this.pnlTopo.Size = new System.Drawing.Size(990, 29);
      // 
      // pnlBase
      // 
      this.pnlBase.Controls.Add(this.menuStripCadastros);
      this.pnlBase.Controls.Add(this.menuStripRelatorios);
      this.pnlBase.Controls.Add(this.menuStripUltilitarios);
      this.pnlBase.Controls.Add(this.menuStripConfiguracoes);
      this.pnlBase.Location = new System.Drawing.Point(200, 29);
      this.pnlBase.Size = new System.Drawing.Size(990, 643);
      // 
      // btnSair
      // 
      this.btnSair.FlatAppearance.BorderSize = 0;
      this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
      this.btnSair.Location = new System.Drawing.Point(966, 0);
      // 
      // btnMinimizar
      // 
      this.btnMinimizar.FlatAppearance.BorderSize = 0;
      this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
      this.btnMinimizar.Location = new System.Drawing.Point(942, 0);
      // 
      // lblTituloForm
      // 
      this.lblTituloForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTituloForm.Size = new System.Drawing.Size(126, 21);
      this.lblTituloForm.Text = "ML Informática";
      // 
      // pnlMenu
      // 
      this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
      this.pnlMenu.Controls.Add(this.btnEncerrar);
      this.pnlMenu.Controls.Add(this.btnUltilitarios);
      this.pnlMenu.Controls.Add(this.btnConfiguracoes);
      this.pnlMenu.Controls.Add(this.btnRelatorios);
      this.pnlMenu.Controls.Add(this.btnCadastros);
      this.pnlMenu.Controls.Add(this.btnInicio);
      this.pnlMenu.Controls.Add(this.pnlArtMenu);
      this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnlMenu.Location = new System.Drawing.Point(5, 0);
      this.pnlMenu.MaximumSize = new System.Drawing.Size(195, 750);
      this.pnlMenu.MinimumSize = new System.Drawing.Size(55, 750);
      this.pnlMenu.Name = "pnlMenu";
      this.pnlMenu.PrtBorderColor = System.Drawing.Color.Transparent;
      this.pnlMenu.Size = new System.Drawing.Size(195, 750);
      this.pnlMenu.TabIndex = 2;
      this.pnlMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMenu_MouseDown);
      // 
      // btnEncerrar
      // 
      this.btnEncerrar.BackColor = System.Drawing.Color.Transparent;
      this.btnEncerrar.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnEncerrar.FlatAppearance.BorderSize = 0;
      this.btnEncerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
      this.btnEncerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
      this.btnEncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnEncerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEncerrar.ForeColor = System.Drawing.Color.White;
      this.btnEncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnEncerrar.Image")));
      this.btnEncerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnEncerrar.Location = new System.Drawing.Point(0, 340);
      this.btnEncerrar.Name = "btnEncerrar";
      this.btnEncerrar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.btnEncerrar.PrtDesabilitarControle = false;
      this.btnEncerrar.PrtEstiloBotao = Controles.Enums.TipoEstiloBotao.Nenhum;
      this.btnEncerrar.PrtImagemAlinhamento = Controles.Enums.ImagemAlignmento.MiddleLeft;
      this.btnEncerrar.PrtIniciaFocusControle = false;
      this.btnEncerrar.PrtToolTipMensagem = null;
      this.btnEncerrar.Size = new System.Drawing.Size(195, 48);
      this.btnEncerrar.TabIndex = 13;
      this.btnEncerrar.Text = "              Sair";
      this.btnEncerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnEncerrar.UseVisualStyleBackColor = true;
      this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
      // 
      // btnUltilitarios
      // 
      this.btnUltilitarios.BackColor = System.Drawing.Color.Transparent;
      this.btnUltilitarios.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnUltilitarios.FlatAppearance.BorderSize = 0;
      this.btnUltilitarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
      this.btnUltilitarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
      this.btnUltilitarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnUltilitarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnUltilitarios.ForeColor = System.Drawing.Color.White;
      this.btnUltilitarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUltilitarios.Image")));
      this.btnUltilitarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnUltilitarios.Location = new System.Drawing.Point(0, 292);
      this.btnUltilitarios.Name = "btnUltilitarios";
      this.btnUltilitarios.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.btnUltilitarios.PrtDesabilitarControle = false;
      this.btnUltilitarios.PrtEstiloBotao = Controles.Enums.TipoEstiloBotao.Nenhum;
      this.btnUltilitarios.PrtImagemAlinhamento = Controles.Enums.ImagemAlignmento.MiddleLeft;
      this.btnUltilitarios.PrtIniciaFocusControle = false;
      this.btnUltilitarios.PrtToolTipMensagem = null;
      this.btnUltilitarios.Size = new System.Drawing.Size(195, 48);
      this.btnUltilitarios.TabIndex = 12;
      this.btnUltilitarios.Tag = "Menu Ultilitários";
      this.btnUltilitarios.Text = "             Ultilitários";
      this.btnUltilitarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnUltilitarios.UseVisualStyleBackColor = true;
      this.btnUltilitarios.Click += new System.EventHandler(this.btnUltilitarios_Click);
      // 
      // btnConfiguracoes
      // 
      this.btnConfiguracoes.BackColor = System.Drawing.Color.Transparent;
      this.btnConfiguracoes.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnConfiguracoes.FlatAppearance.BorderSize = 0;
      this.btnConfiguracoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
      this.btnConfiguracoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
      this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnConfiguracoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnConfiguracoes.ForeColor = System.Drawing.Color.White;
      this.btnConfiguracoes.Image = ((System.Drawing.Image)(resources.GetObject("btnConfiguracoes.Image")));
      this.btnConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnConfiguracoes.Location = new System.Drawing.Point(0, 244);
      this.btnConfiguracoes.Name = "btnConfiguracoes";
      this.btnConfiguracoes.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.btnConfiguracoes.PrtDesabilitarControle = false;
      this.btnConfiguracoes.PrtEstiloBotao = Controles.Enums.TipoEstiloBotao.Nenhum;
      this.btnConfiguracoes.PrtImagemAlinhamento = Controles.Enums.ImagemAlignmento.MiddleLeft;
      this.btnConfiguracoes.PrtIniciaFocusControle = false;
      this.btnConfiguracoes.PrtToolTipMensagem = null;
      this.btnConfiguracoes.Size = new System.Drawing.Size(195, 48);
      this.btnConfiguracoes.TabIndex = 11;
      this.btnConfiguracoes.Tag = "Menu Configurações";
      this.btnConfiguracoes.Text = "             Configurações";
      this.btnConfiguracoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnConfiguracoes.UseVisualStyleBackColor = true;
      this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
      // 
      // btnRelatorios
      // 
      this.btnRelatorios.BackColor = System.Drawing.Color.Transparent;
      this.btnRelatorios.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnRelatorios.FlatAppearance.BorderSize = 0;
      this.btnRelatorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
      this.btnRelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
      this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnRelatorios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnRelatorios.ForeColor = System.Drawing.Color.White;
      this.btnRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorios.Image")));
      this.btnRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnRelatorios.Location = new System.Drawing.Point(0, 196);
      this.btnRelatorios.Name = "btnRelatorios";
      this.btnRelatorios.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.btnRelatorios.PrtDesabilitarControle = false;
      this.btnRelatorios.PrtEstiloBotao = Controles.Enums.TipoEstiloBotao.Nenhum;
      this.btnRelatorios.PrtImagemAlinhamento = Controles.Enums.ImagemAlignmento.MiddleLeft;
      this.btnRelatorios.PrtIniciaFocusControle = false;
      this.btnRelatorios.PrtToolTipMensagem = null;
      this.btnRelatorios.Size = new System.Drawing.Size(195, 48);
      this.btnRelatorios.TabIndex = 10;
      this.btnRelatorios.Tag = "Menu Relatórios";
      this.btnRelatorios.Text = "             Relatórios";
      this.btnRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnRelatorios.UseVisualStyleBackColor = true;
      this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
      // 
      // btnCadastros
      // 
      this.btnCadastros.BackColor = System.Drawing.Color.Transparent;
      this.btnCadastros.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnCadastros.FlatAppearance.BorderSize = 0;
      this.btnCadastros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
      this.btnCadastros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
      this.btnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCadastros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCadastros.ForeColor = System.Drawing.Color.White;
      this.btnCadastros.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastros.Image")));
      this.btnCadastros.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
      this.btnCadastros.Location = new System.Drawing.Point(0, 148);
      this.btnCadastros.Name = "btnCadastros";
      this.btnCadastros.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.btnCadastros.PrtDesabilitarControle = false;
      this.btnCadastros.PrtEstiloBotao = Controles.Enums.TipoEstiloBotao.Nenhum;
      this.btnCadastros.PrtImagemAlinhamento = Controles.Enums.ImagemAlignmento.TopLeft;
      this.btnCadastros.PrtIniciaFocusControle = false;
      this.btnCadastros.PrtToolTipMensagem = null;
      this.btnCadastros.Size = new System.Drawing.Size(195, 48);
      this.btnCadastros.TabIndex = 9;
      this.btnCadastros.Tag = "Menu Cadastros";
      this.btnCadastros.Text = "             Cadastros";
      this.btnCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnCadastros.UseVisualStyleBackColor = false;
      this.btnCadastros.Click += new System.EventHandler(this.btnCadastros_Click);
      // 
      // btnInicio
      // 
      this.btnInicio.BackColor = System.Drawing.Color.Transparent;
      this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnInicio.FlatAppearance.BorderSize = 0;
      this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
      this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
      this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnInicio.ForeColor = System.Drawing.Color.White;
      this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
      this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnInicio.Location = new System.Drawing.Point(0, 100);
      this.btnInicio.Name = "btnInicio";
      this.btnInicio.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.btnInicio.PrtDesabilitarControle = false;
      this.btnInicio.PrtEstiloBotao = Controles.Enums.TipoEstiloBotao.Nenhum;
      this.btnInicio.PrtImagemAlinhamento = Controles.Enums.ImagemAlignmento.MiddleLeft;
      this.btnInicio.PrtIniciaFocusControle = false;
      this.btnInicio.PrtToolTipMensagem = null;
      this.btnInicio.Size = new System.Drawing.Size(195, 48);
      this.btnInicio.TabIndex = 8;
      this.btnInicio.Text = "             Início";
      this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnInicio.UseVisualStyleBackColor = true;
      this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
      // 
      // pnlArtMenu
      // 
      this.pnlArtMenu.Controls.Add(this.lblMenu);
      this.pnlArtMenu.Controls.Add(this.picMenu);
      this.pnlArtMenu.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlArtMenu.Location = new System.Drawing.Point(0, 0);
      this.pnlArtMenu.Name = "pnlArtMenu";
      this.pnlArtMenu.PrtBorderColor = System.Drawing.Color.Transparent;
      this.pnlArtMenu.Size = new System.Drawing.Size(195, 100);
      this.pnlArtMenu.TabIndex = 0;
      // 
      // lblMenu
      // 
      this.lblMenu.AutoSize = true;
      this.lblMenu.BackColor = System.Drawing.Color.Transparent;
      this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblMenu.ForeColor = System.Drawing.Color.White;
      this.lblMenu.Location = new System.Drawing.Point(60, 43);
      this.lblMenu.Name = "lblMenu";
      this.lblMenu.PrtMontaTelaAutomatico = false;
      this.lblMenu.PrtNaoLimparControle = true;
      this.lblMenu.PrtNomeCampoBD = "";
      this.lblMenu.PrtValorPadrao = null;
      this.lblMenu.Size = new System.Drawing.Size(64, 25);
      this.lblMenu.TabIndex = 1;
      this.lblMenu.Text = "Menu";
      this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // picMenu
      // 
      this.picMenu.Cursor = System.Windows.Forms.Cursors.Hand;
      this.picMenu.Image = ((System.Drawing.Image)(resources.GetObject("picMenu.Image")));
      this.picMenu.Location = new System.Drawing.Point(5, 28);
      this.picMenu.Name = "picMenu";
      this.picMenu.Size = new System.Drawing.Size(42, 50);
      this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picMenu.TabIndex = 0;
      this.picMenu.TabStop = false;
      this.picMenu.Click += new System.EventHandler(this.picMenu_Click);
      // 
      // pnlBarraDireita
      // 
      this.pnlBarraDireita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
      this.pnlBarraDireita.Dock = System.Windows.Forms.DockStyle.Right;
      this.pnlBarraDireita.Location = new System.Drawing.Point(1190, 0);
      this.pnlBarraDireita.Name = "pnlBarraDireita";
      this.pnlBarraDireita.PrtBorderColor = System.Drawing.Color.Transparent;
      this.pnlBarraDireita.Size = new System.Drawing.Size(5, 695);
      this.pnlBarraDireita.TabIndex = 3;
      // 
      // pnlRodape
      // 
      this.pnlRodape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
      this.pnlRodape.Controls.Add(this.lblHorario);
      this.pnlRodape.Controls.Add(this.lblData);
      this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pnlRodape.Location = new System.Drawing.Point(200, 672);
      this.pnlRodape.Name = "pnlRodape";
      this.pnlRodape.PrtBorderColor = System.Drawing.Color.Transparent;
      this.pnlRodape.Size = new System.Drawing.Size(990, 23);
      this.pnlRodape.TabIndex = 4;
      // 
      // lblHorario
      // 
      this.lblHorario.AutoSize = true;
      this.lblHorario.BackColor = System.Drawing.Color.Transparent;
      this.lblHorario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblHorario.ForeColor = System.Drawing.Color.White;
      this.lblHorario.Location = new System.Drawing.Point(174, 2);
      this.lblHorario.Name = "lblHorario";
      this.lblHorario.PrtMontaTelaAutomatico = false;
      this.lblHorario.PrtNaoLimparControle = true;
      this.lblHorario.PrtNomeCampoBD = "";
      this.lblHorario.PrtValorPadrao = null;
      this.lblHorario.Size = new System.Drawing.Size(72, 21);
      this.lblHorario.TabIndex = 5;
      this.lblHorario.Text = "Horário:";
      this.lblHorario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblData
      // 
      this.lblData.AutoSize = true;
      this.lblData.BackColor = System.Drawing.Color.Transparent;
      this.lblData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblData.ForeColor = System.Drawing.Color.White;
      this.lblData.Location = new System.Drawing.Point(3, 2);
      this.lblData.Name = "lblData";
      this.lblData.PrtMontaTelaAutomatico = false;
      this.lblData.PrtNaoLimparControle = true;
      this.lblData.PrtNomeCampoBD = "";
      this.lblData.PrtValorPadrao = null;
      this.lblData.Size = new System.Drawing.Size(54, 21);
      this.lblData.TabIndex = 3;
      this.lblData.Text = "Data: ";
      this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // sidebarTimer
      // 
      this.sidebarTimer.Interval = 10;
      this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
      // 
      // menuStripConfiguracoes
      // 
      this.menuStripConfiguracoes.BackColor = System.Drawing.SystemColors.ControlLight;
      this.menuStripConfiguracoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bancoDeDadosToolStripMenuItem,
            this.controleDeAcessoToolStripMenuItem});
      this.menuStripConfiguracoes.Location = new System.Drawing.Point(0, 0);
      this.menuStripConfiguracoes.Name = "menuStripConfiguracoes";
      this.menuStripConfiguracoes.Size = new System.Drawing.Size(990, 24);
      this.menuStripConfiguracoes.TabIndex = 0;
      this.menuStripConfiguracoes.Text = "menuStripEdit1";
      this.menuStripConfiguracoes.Visible = false;
      // 
      // bancoDeDadosToolStripMenuItem
      // 
      this.bancoDeDadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarToolStripMenuItem});
      this.bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
      this.bancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
      this.bancoDeDadosToolStripMenuItem.Tag = "Banco de Dados";
      this.bancoDeDadosToolStripMenuItem.Text = "Banco de Dados";
      // 
      // configurarToolStripMenuItem
      // 
      this.configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
      this.configurarToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
      this.configurarToolStripMenuItem.Tag = "Configurar";
      this.configurarToolStripMenuItem.Text = "Configurar";
      this.configurarToolStripMenuItem.Click += new System.EventHandler(this.configurarToolStripMenuItem_Click_1);
      // 
      // controleDeAcessoToolStripMenuItem
      // 
      this.controleDeAcessoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
      this.controleDeAcessoToolStripMenuItem.Name = "controleDeAcessoToolStripMenuItem";
      this.controleDeAcessoToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
      this.controleDeAcessoToolStripMenuItem.Tag = "Controle de Acesso";
      this.controleDeAcessoToolStripMenuItem.Text = "Controle de Acesso";
      // 
      // menuToolStripMenuItem
      // 
      this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.habilitarDesabilitarToolStripMenuItem});
      this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
      this.menuToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
      this.menuToolStripMenuItem.Tag = "Menu";
      this.menuToolStripMenuItem.Text = "Menu";
      // 
      // habilitarDesabilitarToolStripMenuItem
      // 
      this.habilitarDesabilitarToolStripMenuItem.Name = "habilitarDesabilitarToolStripMenuItem";
      this.habilitarDesabilitarToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
      this.habilitarDesabilitarToolStripMenuItem.Tag = "Habilitar/Desabilitar";
      this.habilitarDesabilitarToolStripMenuItem.Text = "Habilitar/Desabilitar";
      this.habilitarDesabilitarToolStripMenuItem.Click += new System.EventHandler(this.habilitarDesabilitarToolStripMenuItem_Click);
      // 
      // menuStripCadastros
      // 
      this.menuStripCadastros.BackColor = System.Drawing.SystemColors.ControlLight;
      this.menuStripCadastros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
      this.menuStripCadastros.Location = new System.Drawing.Point(0, 0);
      this.menuStripCadastros.Name = "menuStripCadastros";
      this.menuStripCadastros.Size = new System.Drawing.Size(990, 24);
      this.menuStripCadastros.TabIndex = 1;
      this.menuStripCadastros.Text = "menuStripEdit1";
      this.menuStripCadastros.Visible = false;
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.municípiosToolStripMenuItem,
            this.serviçosToolStripMenuItem});
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
      this.toolStripMenuItem1.Tag = "Cadastros";
      this.toolStripMenuItem1.Text = "Cadastros";
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
      this.toolStripMenuItem2.Tag = "Clientes";
      this.toolStripMenuItem2.Text = "Clientes";
      this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
      // 
      // municípiosToolStripMenuItem
      // 
      this.municípiosToolStripMenuItem.Name = "municípiosToolStripMenuItem";
      this.municípiosToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
      this.municípiosToolStripMenuItem.Tag = "Municípios";
      this.municípiosToolStripMenuItem.Text = "Municípios";
      this.municípiosToolStripMenuItem.Click += new System.EventHandler(this.municípiosToolStripMenuItem_Click);
      // 
      // serviçosToolStripMenuItem
      // 
      this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
      this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
      this.serviçosToolStripMenuItem.Tag = "Serviços";
      this.serviçosToolStripMenuItem.Text = "Serviços";
      this.serviçosToolStripMenuItem.Click += new System.EventHandler(this.serviçosToolStripMenuItem_Click);
      // 
      // menuStripRelatorios
      // 
      this.menuStripRelatorios.BackColor = System.Drawing.SystemColors.ControlLight;
      this.menuStripRelatorios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatóriosToolStripMenuItem,
            this.movimentaçõesToolStripMenuItem});
      this.menuStripRelatorios.Location = new System.Drawing.Point(0, 0);
      this.menuStripRelatorios.Name = "menuStripRelatorios";
      this.menuStripRelatorios.Size = new System.Drawing.Size(990, 24);
      this.menuStripRelatorios.TabIndex = 2;
      this.menuStripRelatorios.Tag = "";
      this.menuStripRelatorios.Text = "menuStripEdit1";
      this.menuStripRelatorios.Visible = false;
      // 
      // relatóriosToolStripMenuItem
      // 
      this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem});
      this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
      this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
      this.relatóriosToolStripMenuItem.Tag = "Relatórios";
      this.relatóriosToolStripMenuItem.Text = "Relatórios";
      // 
      // clientesToolStripMenuItem
      // 
      this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
      this.clientesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
      this.clientesToolStripMenuItem.Tag = "Clientes";
      this.clientesToolStripMenuItem.Text = "Clientes";
      // 
      // movimentaçõesToolStripMenuItem
      // 
      this.movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
      this.movimentaçõesToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
      this.movimentaçõesToolStripMenuItem.Tag = "Movimentações";
      this.movimentaçõesToolStripMenuItem.Text = "Movimentações";
      // 
      // menuStripUltilitarios
      // 
      this.menuStripUltilitarios.BackColor = System.Drawing.SystemColors.ControlLight;
      this.menuStripUltilitarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.nFeSEFAZToolStripMenuItem});
      this.menuStripUltilitarios.Location = new System.Drawing.Point(0, 0);
      this.menuStripUltilitarios.Name = "menuStripUltilitarios";
      this.menuStripUltilitarios.Size = new System.Drawing.Size(990, 24);
      this.menuStripUltilitarios.TabIndex = 3;
      this.menuStripUltilitarios.Text = "menuStripEdit1";
      this.menuStripUltilitarios.Visible = false;
      // 
      // toolStripMenuItem5
      // 
      this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6});
      this.toolStripMenuItem5.Name = "toolStripMenuItem5";
      this.toolStripMenuItem5.Size = new System.Drawing.Size(75, 20);
      this.toolStripMenuItem5.Tag = "Acessórios";
      this.toolStripMenuItem5.Text = "Acessórios";
      // 
      // toolStripMenuItem6
      // 
      this.toolStripMenuItem6.Name = "toolStripMenuItem6";
      this.toolStripMenuItem6.Size = new System.Drawing.Size(137, 22);
      this.toolStripMenuItem6.Tag = "Calculadora";
      this.toolStripMenuItem6.Text = "Calculadora";
      this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
      // 
      // nFeSEFAZToolStripMenuItem
      // 
      this.nFeSEFAZToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leituraXMLToolStripMenuItem});
      this.nFeSEFAZToolStripMenuItem.Name = "nFeSEFAZToolStripMenuItem";
      this.nFeSEFAZToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
      this.nFeSEFAZToolStripMenuItem.Tag = "Arquivo";
      this.nFeSEFAZToolStripMenuItem.Text = "Arquivo";
      // 
      // leituraXMLToolStripMenuItem
      // 
      this.leituraXMLToolStripMenuItem.Name = "leituraXMLToolStripMenuItem";
      this.leituraXMLToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
      this.leituraXMLToolStripMenuItem.Tag = "Ler XML NF-e";
      this.leituraXMLToolStripMenuItem.Text = "Ler XML NF-e";
      this.leituraXMLToolStripMenuItem.Click += new System.EventHandler(this.leituraXMLToolStripMenuItem_Click);
      // 
      // timer
      // 
      this.timer.Enabled = true;
      this.timer.Tick += new System.EventHandler(this.timer_Tick);
      // 
      // frmPrincipal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
      this.ClientSize = new System.Drawing.Size(1200, 700);
      this.Controls.Add(this.pnlRodape);
      this.Controls.Add(this.pnlBarraDireita);
      this.Controls.Add(this.pnlMenu);
      this.MaximumSize = new System.Drawing.Size(1390, 800);
      this.MinimumSize = new System.Drawing.Size(1100, 600);
      this.Name = "frmPrincipal";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "frmPrincipal";
      this.Controls.SetChildIndex(this.pnlMenu, 0);
      this.Controls.SetChildIndex(this.pnlBarraDireita, 0);
      this.Controls.SetChildIndex(this.pnlRodape, 0);
      this.Controls.SetChildIndex(this.pnlTopo, 0);
      this.Controls.SetChildIndex(this.pnlBase, 0);
      this.pnlTopo.ResumeLayout(false);
      this.pnlTopo.PerformLayout();
      this.pnlBase.ResumeLayout(false);
      this.pnlBase.PerformLayout();
      this.pnlMenu.ResumeLayout(false);
      this.pnlArtMenu.ResumeLayout(false);
      this.pnlArtMenu.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
      this.pnlRodape.ResumeLayout(false);
      this.pnlRodape.PerformLayout();
      this.menuStripConfiguracoes.ResumeLayout(false);
      this.menuStripConfiguracoes.PerformLayout();
      this.menuStripCadastros.ResumeLayout(false);
      this.menuStripCadastros.PerformLayout();
      this.menuStripRelatorios.ResumeLayout(false);
      this.menuStripRelatorios.PerformLayout();
      this.menuStripUltilitarios.ResumeLayout(false);
      this.menuStripUltilitarios.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion
        private Controles.PanelEdit pnlBarraDireita;
        private Controles.PanelEdit pnlRodape;
        private Controles.PanelEdit pnlArtMenu;
        private Controles.PictureBoxEdit picMenu;
        private Controles.LabelEdit lblMenu;
        private System.Windows.Forms.ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem municípiosToolStripMenuItem;
        private Controles.LabelEdit lblHorario;
        private Controles.LabelEdit lblData;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nFeSEFAZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leituraXMLToolStripMenuItem;
        public System.Windows.Forms.Timer sidebarTimer;
        public Controles.MenuStripEdit menuStripConfiguracoes;
        public Controles.MenuStripEdit menuStripUltilitarios;
        public Controles.MenuStripEdit menuStripRelatorios;
        public Controles.MenuStripEdit menuStripCadastros;
        private System.Windows.Forms.ToolStripMenuItem controleDeAcessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habilitarDesabilitarToolStripMenuItem;
        public Controles.ButtonEdit btnUltilitarios;
        public Controles.ButtonEdit btnConfiguracoes;
        public Controles.ButtonEdit btnRelatorios;
        public Controles.ButtonEdit btnCadastros;
        public Controles.ButtonEdit btnInicio;
        public Controles.ButtonEdit btnEncerrar;
        protected Controles.PanelEdit pnlMenu;
    }
}