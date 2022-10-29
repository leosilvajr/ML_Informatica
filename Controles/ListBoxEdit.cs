using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Controles
{
  public class ListBoxEdit : ListBox
  {
    private bool _gravaParametroTela = true;
    private Color corCampo;
    private Color corFonte;
    bool desabilitarControle = false;
    private bool tabEnter = true;
    string toolTipMensagem = null;
    private bool iniciarFocusControle = false;


    public ListBoxEdit()
    {
      this.BackColorExt();
      this.ForeColorExt();
      this.FontExtPadrao();

    }

    #region PROPRIEDADES CRIADAS NO COMPONENTE

    [Description("Defina apenas um controle que vai iniciar com o foco quando tela for carregada).")]//  (opcional)
    [TypeConverter(typeof(bool)), Category("EditControls")]
    public bool PrtIniciaFocusControle
    {
      get { return iniciarFocusControle; }
      set { iniciarFocusControle = value; }
    }

    [Description("Se propriedade igual a True, campo não poderá ser editado).")]//  (opcional)
    [TypeConverter(typeof(bool)), Category("EditControls")]
    public bool PrtDesabilitarControle
    {
      get { return desabilitarControle; }
      set { desabilitarControle = value; }
    }

    [Description("Informe uma mensagem para ser mostrada ao usuário, quando passar o cursor sobre o controle.")]//  (opcional)
    [TypeConverter(typeof(string)), Category("EditControls")]
    public string PrtToolTipMensagem
    {
      get { return toolTipMensagem; }
      set { toolTipMensagem = value; }

    }

    [Description("Determina se o cursor mudará de controle ao pressionar Tab/Enter")]
    [TypeConverter(typeof(bool)), Category("EditControls")]
    public bool PrtTabEnter
    {
      get { return tabEnter; }
      set { tabEnter = value; }
    }


    [Description("Determina que campo será desabilitado ao executar rotina DesabilitarCamposTela.")]
    [TypeConverter(typeof(bool)), Category("EditControls")]
    public bool PrtGravaParametroTela
    {
      get { return _gravaParametroTela; }
      set { _gravaParametroTela = value; }
    }

    #endregion


    #region EVENTOS - OVERRIDE

/*    //Evento KeyPress
    protected override void OnKeyPress(KeyPressEventArgs e)
    {
      base.OnKeyPress(e);
      if (e.KeyChar == (char)13)
      {
        //this.Controls.ke ProcessTabKey(true); não consegui usar este metodo
        if (tabEnter == true)
          SendKeys.Send("{TAB}");
        else
          e.Handled = true;
      }

    }
*/

    //Sobrescrever o evento ao receber o foco
    protected override void OnGotFocus(EventArgs e)
    {
      base.OnGotFocus(e);
      corCampo = this.BackColor;
      corFonte = this.ForeColor;
      this.BackColorOnFocusExt();
    }

    //Sobrescrever o evento ao perder o foco
    protected override void OnLostFocus(EventArgs e)
    {
      base.OnLostFocus(e);
      this.BackColor = corCampo; //Color.White;
      this.ForeColor = corFonte;
    }

    #endregion


  }
}
