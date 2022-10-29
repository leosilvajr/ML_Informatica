using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Controles
{
  public class CheckedListBoxEdit : CheckedListBox
  {
    private bool aceitaValorNulo = false;
    private bool naoLimparControle = false;
    private string mensagemCampoObrigatorio = "Campo não pode ser vazio !";
    private bool gravaParametroTela = false;
    private Color corCampo;
    private Color corFonte;
    private string nomeTabelaBD = null;
    private Label labelDescricao = null;
    private bool ativaValidacao = true; //faz validação do campo se tiver true
    private bool montaTelaAutomatico = true;
    private string nomeCampoBD = null;
    private bool tabEnter = true;
    private string valorPadrao = null;
    private string toolTipMensagem = null;
    //quando passar pelo campo e tiver algo errado será alertado o cliente com icone no campo e depois com aviso ao clicar no aceitar
    private ErrorProvider erroProvider;
    private bool ocultarAlertaErro = false;
    private bool desabilitarControle = true;
    private bool iniciarFocusControle = false;
    private bool campoValidado = true;

    public CheckedListBoxEdit()
    {
      erroProvider = new ErrorProvider();
      this.BackColorExt();
      this.ForeColorExt();
      this.FontExtPadrao();

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

    [Description("Se propriedade igual a True, alerta piscando de erro não será mostrado na tela.")]//  (opcional)
    [TypeConverter(typeof(bool)), Category("Pratic")]
    public bool PrtOcultarAlertaErro
    {
      get { return ocultarAlertaErro; }
      set { ocultarAlertaErro = value; }
    }

    [Description("Determina se o cursor mudará de controle ao pressionar Tab/Enter")]//  (opcional)
    [TypeConverter(typeof(bool)), Category("EditControls")]
    public bool PrtTabEnter
    {
      get { return tabEnter; }
      set { tabEnter = value; }
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


    [Description("Determina se o valor do campo será validado.")]//  (opcional)
    [TypeConverter(typeof(string)), Category("EditControls")]
    public bool PrtAtivaValidacao
    {
      get { return ativaValidacao; }
      set { ativaValidacao = value; }
    }

    [Description("Informamos o controle do tipo Label que irá ficar vinculado a este campo, para mostrar uma descrição.")]//  (opcional)
    [TypeConverter(typeof(string)), Category("EditControls")]
    public Label PrtLabelDescricao
    {
      get { return labelDescricao; }
      set { labelDescricao = value; }
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


    [Description("Define se campo poderá ficar nulo.")]//  (opcional)
    [TypeConverter(typeof(bool)), Category("EditControls")]
    public bool PrtAceitaValorNulo
    {
      get { return aceitaValorNulo; }
      set { aceitaValorNulo = value; }
    }


    #endregion

    //Propriedades que estamos Sobrescrevendo
    #region PROPRIEDADES (SOBRESCREVER)
    
    //estamos liberando a propriedade AutoSize ser mostrada na barra, e colocando valor false como padrão
    //com isso podemos alterar a altura do controle na tela.
    [DefaultValue(false)]
    [Browsable(true)]
    public override bool AutoSize
    {
      get
      {
        return base.AutoSize;
      }
      set
      {
        base.AutoSize = value;
      }
    }
    
    //Sobrescrever o evento ao receber o foco
    protected override void OnGotFocus(EventArgs e)
    {
      base.OnGotFocus(e);
      corCampo = this.BackColor;
      corFonte = this.ForeColor;
      this.BackColorOnFocusExt();

    }
    
    protected override void OnTextChanged(EventArgs e)
    {
      base.OnTextChanged(e);
      erroProvider.Clear();
    }


    //Sobrescrever o evento ao perder o foco
    protected override void OnLostFocus(EventArgs e)
    {
      base.OnLostFocus(e);
      this.BackColor = corCampo; //Color.White;
      this.ForeColor = corFonte;
    }

    //Evento onKeyDown - travamos edição do campo
    protected override void OnKeyDown(KeyEventArgs e)
    {
      //18/04/16 - bloqueia edição do controle quando propriedade igual a false
      if (desabilitarControle == false)
      {
        e.SuppressKeyPress = true;
        return;
      }
      base.OnKeyDown(e);
    }


    #endregion

    #region <<<<< Metodos Criados >>>>>>>


    public void AtualizaErroProvider(string mensagem)
    {
      erroProvider.SetError(this, mensagem); //atualiza componente errorProvider

    }


    #endregion   <<<<<<< fim dos metodos >>>>>>>>>>

  }

}
