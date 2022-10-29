using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Controles
{
  public class PanelEdit: Panel
  {
    private Color colorBorder = Color.Transparent;

    public PanelEdit()
    {
    }

    #region PROPRIEDADES CRIADAS NO COMPONENTE

    [TypeConverter(typeof(Color)), Category("Pratic")]
    public Color PrtBorderColor
    {
      get
      {
        return colorBorder;
      }
      set
      {
        colorBorder = value;
        this.Refresh(); //dispara o evento OnPaint
      }
    }

    #endregion


    #region EVENTOS SOBRESCRITOS

    protected override void OnPaint(PaintEventArgs e)
    {
      try
      {
        base.OnPaint(e);
        e.Graphics.DrawRectangle(
            new Pen(
                new SolidBrush(colorBorder), 1),
                e.ClipRectangle);

      }
      catch 
      {
        throw;
      }
    }

    #endregion
  }
}
