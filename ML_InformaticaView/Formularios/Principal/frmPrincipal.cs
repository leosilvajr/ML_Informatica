using Funcionarios.Formularios;
using ML_InformaticaView.Formularios.Cadastros;
using ML_InformaticaView.Formularios.Configuracoes;
using ML_InformaticaView.Funcoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ML_InformaticaView.Formularios.Principal
{
  public partial class frmPrincipal : frmBase
  {
    bool painelMenu = true;
    public frmPrincipal()
    {
      InitializeComponent();
      lblTituloForm.Visible = false;
    }
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
    public void AlterarCorBotao(Control.ControlCollection menu)
    {
      foreach (Control item in menu)
      {
        if (item is Button botao)
        {
          if (botao.ContainsFocus)
            botao.BackColor = Color.FromArgb(112, 128, 144);
          else
            botao.BackColor = Color.FromArgb(35, 40, 45); //Cor padrao
        }
      }
    }
    private void sidebarTimer_Tick(object sender, EventArgs e)
    {
      if (!painelMenu)
        pnlMenu.Width -= 10;
      else
        pnlMenu.Width += 10;
      if (pnlMenu.Width == pnlMenu.MinimumSize.Width || pnlMenu.Width == pnlMenu.MaximumSize.Width)
      {
        sidebarTimer.Stop();
      }
    }

    private void picMenu_Click(object sender, EventArgs e)
    {
      painelMenu = pnlMenu.Width <= pnlMenu.MinimumSize.Width ? true : false;
      sidebarTimer.Start();
    }

    private void pnlMenu_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        ReleaseCapture();
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
      }
    }


    private void btnInicio_Click(object sender, EventArgs e)
    {
      AlterarCorBotao(pnlMenu.Controls);
      menuStripCadastros.Visible = false;
      menuStripRelatorios.Visible = false;
      menuStripConfiguracoes.Visible = false;
      menuStripUltilitarios.Visible = false;
    }

    private void btnCadastros_Click(object sender, EventArgs e)
    {
      AlterarCorBotao(pnlMenu.Controls);
      menuStripCadastros.Visible = true;
      menuStripRelatorios.Visible = false;
      menuStripConfiguracoes.Visible = false;
      menuStripUltilitarios.Visible = false;

    }

    private void btnRelatorios_Click(object sender, EventArgs e)
    {
      AlterarCorBotao(pnlMenu.Controls);
      menuStripCadastros.Visible = false;
      menuStripRelatorios.Visible = true;
      menuStripConfiguracoes.Visible = false;
      menuStripUltilitarios.Visible = false;
    }
    private void btnConfiguracoes_Click(object sender, EventArgs e)
    {
      AlterarCorBotao(pnlMenu.Controls);
      menuStripCadastros.Visible = false;
      menuStripRelatorios.Visible = false;
      menuStripConfiguracoes.Visible = true;
      menuStripUltilitarios.Visible = false;
    }

    private void btnUltilitarios_Click(object sender, EventArgs e)
    {
      AlterarCorBotao(pnlMenu.Controls);
      menuStripCadastros.Visible = false;
      menuStripRelatorios.Visible = false;
      menuStripConfiguracoes.Visible = false;
      menuStripUltilitarios.Visible = true;
    }
    private void btnEncerrar_Click(object sender, EventArgs e)
    {
      AlterarCorBotao(pnlMenu.Controls);
      Application.Exit();
    }

    private void toolStripMenuItem6_Click(object sender, EventArgs e)
    {
      Process.Start("Calc.exe");
    }
    private void configurarToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
      frmConfigBanco configBanco = new frmConfigBanco();
      Util.AbreForm(pnlBase, configBanco);
    }

    private void municípiosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmCadMunicipio cadMunicipio = new frmCadMunicipio();
      Util.AbreForm(pnlBase, cadMunicipio);
    }
  }
}
