using System.ComponentModel;
using System.Windows.Forms;

namespace Controles
{ 
  public class LabelEdit : Label
  {
    private string valorPadrao = null;
    private bool naoLimparControle = true;
    private bool montaTelaAutomatico = false;
    private string nomeCampoBD = "";

    public LabelEdit()
    {
      //OBS:não consegui fazer o label iniciar com AutoSize = false

      this.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.Height = Tipos.Constantes.ControleHeight;
      this.Width = 100;
      this.BackColorExt();
      this.ForeColorExt();
      this.FontExtPadrao();
    }

/*    [DefaultValue(false)]
    public override bool AutoSize
    {
      get => base.AutoSize;
      set
      {
        base.AutoSize = value;
      }
    }
*/
    [Description("Defini um valor padrao para o objeto.")]
    [TypeConverter(typeof(string)), Category("EditControls")]
    public string PrtValorPadrao { get => valorPadrao; set => valorPadrao = value; }

    [Description("Quando igual a true método LimpaControles não vai apagar valor do campo.")]//  (opcional)
    [TypeConverter(typeof(bool)), Category("EditControls")]
    public bool PrtNaoLimparControle
    {
      get { return naoLimparControle; }
      set { naoLimparControle = value; }
    }

    [Description("Identifica o nome do campo que está criado no banco de dados.")]//  (opcional)
    [TypeConverter(typeof(string)), Category("EditControls")]
    public string PrtNomeCampoBD
    {
      get { return nomeCampoBD; }
      set { nomeCampoBD = value; }
    }

    [Description("Determina que campo será valorado no metodo MontaTela automaticamente.")]//  (opcional)
    [TypeConverter(typeof(bool)), Category("EditControls")]
    public bool PrtMontaTelaAutomatico
    {
      get { return montaTelaAutomatico; }
      set { montaTelaAutomatico = value; }
    }


  }
}
