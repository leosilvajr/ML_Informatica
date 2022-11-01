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
using System.Security;
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

    }
    private int borderWidth = 5; //Exemplo apenas para teste
    private new Padding Padding = new Padding(50); //Exemplo apenas para teste (Pode ser especificado direto nas propriedades do Form)

    private WinApi.HitTest HitTestNCA(IntPtr lparam)
    {
      Point vPoint = new Point((Int16)lparam, (Int16)((int)lparam >> 16));
      int vPadding = Math.Max(Padding.Right, Padding.Bottom);

      if (RectangleToScreen(new Rectangle(ClientRectangle.Width - vPadding, ClientRectangle.Height - vPadding, vPadding, vPadding)).Contains(vPoint))
        return WinApi.HitTest.HTBOTTOMRIGHT;

      if (RectangleToScreen(new Rectangle(borderWidth, borderWidth, ClientRectangle.Width - 2 * borderWidth, 50)).Contains(vPoint))
        return WinApi.HitTest.HTCAPTION;

      return WinApi.HitTest.HTCLIENT;
    }

    protected override void WndProc(ref Message m)
    {
      if (DesignMode)
      {
        base.WndProc(ref m);
        return;
      }

      switch (m.Msg)
      {
        case (int)WinApi.Messages.WM_NCHITTEST:
          WinApi.HitTest ht = HitTestNCA(m.LParam);
          if (ht != WinApi.HitTest.HTCLIENT)
          {
            m.Result = (IntPtr)ht;
            return;
          }
          break;
      }

      base.WndProc(ref m);
    }

    [SuppressUnmanagedCodeSecurity]
    internal static class WinApi
    {
      public enum Messages : uint
      {
        WM_NCHITTEST = 0x84,
      }

      public enum HitTest
      {
        HTCLIENT = 1,
        HTBOTTOMRIGHT = 17,
        HTCAPTION = 2
      }
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

    private void toolStripMenuItem2_Click(object sender, EventArgs e)
    {
      frmCadClientes cadClientes = new frmCadClientes();
      Util.AbreForm(pnlBase, cadClientes);
    }

    private void timer_Tick(object sender, EventArgs e)
    {
      lblData.Text = "Data: " + DateTime.Today.ToString("dd/MM/yyyy");
      lblHorario.Text = "Horário: " + DateTime.Now.ToString("HH:mm:ss");
    }
  }
}
