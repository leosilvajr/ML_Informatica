using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Controles
{
  public class TabControlEdit: TabControl
  {

    public TabControlEdit()
    {
      this.ForeColorExt();
      this.FontExtPadrao();
      
    }

    /* FUNCIONCOU ABAIXO O CODIGO, MAS OS BOTOES QUE MUDAM DE TAB, NÃO FICARAM TRANSPARENTES
     * O METODO ABAIXO TEM QUE SER CHAMADO NO LOAD DO FORM PARA FUNCIONAR.
     * 
    public void MakeTransparent()
    {
      if (TabCount == 0) throw new InvalidOperationException();
      var height = GetTabRect(0).Bottom;
      // Move controls to panels
      for (int tab = 0; tab < TabCount; ++tab)
      {
        var page = new Panel
        {
          Left = this.Left,
          Top = this.Top + height,
          Width = this.Width,
          Height = this.Height - height,
          BackColor = Color.Transparent,
          Visible = tab == this.SelectedIndex
        };
        for (int ix = TabPages[tab].Controls.Count - 1; ix >= 0; --ix)
        {
          TabPages[tab].Controls[ix].Parent = page;
        }
        pages.Add(page);
        this.Parent.Controls.Add(page);
      }
      this.Height = height;
    }

    protected override void OnSelectedIndexChanged(EventArgs e)
    {
      base.OnSelectedIndexChanged(e);
      for (int tab = 0; tab < pages.Count; ++tab)
      {
        pages[tab].Visible = tab == SelectedIndex;
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing) foreach (var page in pages) page.Dispose();
      base.Dispose(disposing);
    }
    */
  }
}
