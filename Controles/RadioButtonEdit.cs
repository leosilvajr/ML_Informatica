using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Controles
{
  public class RadioButtonEdit : RadioButton
  {
    private bool naoLimparControle = false;
    private string mensagemCampoObrigatorio = "Campo não pode ser vazio !";
    private bool gravaParametroTela = false;
    //private Color corCampo;
    //private Color corFonte;
    private string nomeTabelaBD = null;
    private bool ativaValidacao = true; //faz validação do campo se tiver true
    private bool montaTelaAutomatico = true;
    private string nomeCampoBD = null;
    private bool tabEnter = true;
    private string valorPadrao = null;
    private string toolTipMensagem = null;
    private bool desabilitarControle = true;
    private bool iniciarFocusControle = false;
    private bool campoValidado = true;
    //private string fontePadrao;
    private float tamanhoFontePadrao = 0;
    //private FontStyle estiloPadrao;

    public RadioButtonEdit()
    {
      this.ForeColorExt();
      this.FontExtPadrao();
      PrtTamanhoFontePadrao = PrtTamanhoFontePadrao == 0 ? this.Font.Size: PrtTamanhoFontePadrao; //tamanho fonte padrao
      //PrtEstiloPadrao = this.Font.Style; // estilo padrao se está negrito
    }



    #region PROPRIEDADES CRIADAS NO COMPONENTE QUE NÃO APARECEM NA BARRA DO VISUAL APENAS VIA CODIGO É POSSÍVEL UTILIZAR.

    [Description("Propriedade identifica se campo passou foi validado corretamente retornando True, caso contrário uma mensagem é mostrada.")]//  (opcional)
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool PrtCampoValidado
    {
      get
      {
        return campoValidado;
      }
      set
      {
        campoValidado = value;
      }

    }


    #endregion


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

    [Description("Defini um valor padrao para o objeto.")]//  (opcional)
    [TypeConverter(typeof(string)), Category("EditControls")]
    public string PrtValorPadrao
    {
      get { return valorPadrao; }
      set { valorPadrao = value; }

    }


    [Description("Determina se o cursor mudará de controle ao pressionar Tab/Enter")]//  (opcional)
    [TypeConverter(typeof(bool)), Category("EditControls")]
    public bool PrtTabEnter
    {
      get { return tabEnter; }
      set { tabEnter = value; }
    }

    [Description("Identifica o nome do campo que está criado no banco de dados.")]//  (opcional)
    [TypeConverter(typeof(bool)), Category("EditControls")]
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




    [Description("Determina se o valor do campo será validado.")]//  (opcional)
    [TypeConverter(typeof(string)), Category("EditControls")]
    public bool PrtAtivaValidacao
    {
      get { return ativaValidacao; }
      set { ativaValidacao = value; }
    }


    [Description("Informe o nome da Tabela criada no banco a que este campo pertence.")]//  (opcional)
    [TypeConverter(typeof(string)), Category("EditControls")]
    public string PrtNomeTabelaBD
    {
      get { return nomeTabelaBD; }
      set { nomeTabelaBD = value; }
    }


    [Description("Quando igual a true valor do campo fica armazenado para ser mostrado ao carregar Tela.")]
    [TypeConverter(typeof(bool)), Category("EditControls")]
    public bool PrtGravaParametroTela
    {
      get { return gravaParametroTela; }
      set { gravaParametroTela = value; }
    }

    [Description("Quando igual a true método LimpaControles não vai apagar valor do campo.")]//  (opcional)
    [TypeConverter(typeof(bool)), Category("EditControls")]
    public bool PrtNaoLimparControle
    {
      get { return naoLimparControle; }
      set { naoLimparControle = value; }
    }


    [Description("Mostra mensagem para usuário se propriedade PrtAceitaValorNulo igual a false e campo estiver vazio.")]//  (opcional)
    [TypeConverter(typeof(string)), Category("EditControls")]
    public string PrtMensagemCampoObrigatorio
    {
      get { return mensagemCampoObrigatorio; }
      set { mensagemCampoObrigatorio = value; }
    }

    //[Description("Opção definir uma Fonte para quando controle receber o foco")]//  (opcional)
    //[TypeConverter(typeof(string)), Category("EditControls")]
    //public string PrtFontePadrao { get => fontePadrao; set => fontePadrao = value; }

    [Description("Defini o tamanho da fonte quando controle receber o foco")]
    [TypeConverter(typeof(string)), Category("EditControls")]
    public float PrtTamanhoFontePadrao { get => tamanhoFontePadrao; set => tamanhoFontePadrao = value; }

    //[Description("Define o estilo da fonte quando controle receber o foco")]
    //[TypeConverter(typeof(string)), Category("EditControls")]
    //public FontStyle PrtEstiloPadrao { get => estiloPadrao; set => estiloPadrao = value; }



    #endregion

    //Propriedades que estamos Sobrescrevendo
    #region PROPRIEDADES (SOBRESCREVER)

    //Evento clique  - alteramos cor de fundo, da fonte e o tamanho para destacar o Radio Button
    protected override void OnClick(EventArgs e)
    {
      try
      {
        base.OnClick(e);
        if (this.Checked == true)
        {
          //coloquei aqui, no construtor a cor da font não pegava corretamente.
          //corCampo = this.BackColor; //guarda a cor padrão ao iniciar componente
          //corFonte = this.ForeColor;   //guarda a cor da fonte padrao
          //PrtFontePadrao = this.Font.Name; //fonte de letra padrao
          //PrtTamanhoFontePadrao = this.Font.Size; //tamanho fonte padrao
          //PrtEstiloPadrao = this.Font.Style; // estilo padrao se está negrito
          //this.BackColor = Tipos.Constantes.BackColorControle;
          this.Font = new Font(this.Font.Name, this.Font.Size, FontStyle.Bold);
          //this.ForeColor = Tipos.Constantes.ForeColorControle;
        }
      }
      catch
      {

        throw;
      }
    }

    //Evento OnValidating - voltamos a configuração padrão do objeto ao perder o foco
    protected override void OnValidating(System.ComponentModel.CancelEventArgs e)
    {
      try
      {

        base.OnValidating(e);
        //this.BackColor = corCampo; //devolve a cor padrão.
        //this.ForeColor = corFonte;
        //this.Font = new Font(PrtFontePadrao, PrtTamanhoFontePadrao, PrtEstiloPadrao);
        //this.Font = new Font(this.Font.FontFamily, PrtTamanhoFontePadrao, this.Font.Style);
        this.Font = new Font(this.Font.Name, this.Font.Size, FontStyle.Regular);

      }
      catch
      {

        throw;
      }
    }

/*
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

    #endregion

  }
}
