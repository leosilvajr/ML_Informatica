using System;
using System.Drawing;
using System.Windows.Forms;

namespace Controles
{
  public class ListViewEdit: ListView
  {
    private Color corFundo;
    private Color corFonte;

    //OBS: FAREI AS IMPLEMENTAÇÕES A MEDIDA QUE FOR PRECISO.

    public ListViewEdit()
    {
      this.BackColorExt();
      this.ForeColorExt();
      this.FontExtPadrao();

    }

    protected override void OnGotFocus(EventArgs e)
    {
      base.OnGotFocus(e);
      corFundo = this.BackColor;
      corFonte = this.ForeColor;
      this.BackColorOnFocusExt();
    }

    protected override void OnLostFocus(EventArgs e)
    {
      base.OnLostFocus(e);
      this.BackColor = corFundo;
      this.ForeColor = corFonte;
    }
  }
}
