using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Controles
{

  public class GroupBoxEdit: GroupBox
  {
    private bool desabilitarControle = true;
    private Color corFundo;
    private Color corFonte;

    public GroupBoxEdit()
    {
      this.BackColorExt();
      this.ForeColorExt();
      this.FontExtPadrao();

    }

    [Description("Se propriedade igual a True, campo não poderá ser editado).")]//  (opcional)
    [TypeConverter(typeof(bool)), Category("EditControls")]
    public bool PrtDesabilitarControle
    {
      get { return desabilitarControle; }
      set { desabilitarControle = value; }
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
