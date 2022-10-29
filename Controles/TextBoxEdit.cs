using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Controles
{

  public class TextBoxEdit : TextBox
  {
    private bool aceitaNumeros; //= false;
    private bool aceitaEspaco = false;
    private Enums.TipoTexto tipoTexto = Enums.TipoTexto.TEXTO_MAIUSCULO;
    private bool naoLimparControle = false;
    private string mensagemCampoObrigatorio = "Campo não pode ser vazio !";
    private bool campoObrigatorio = false;
    private bool gravaParametroTela = false;
    private string nomeTabelaBD = null;
    private Label labelDescricao = null;
    private bool ativaValidacao = true; //faz validação do campo se tiver true
    private bool ativaPesquisa = false; //ativa pesquisa quando pressionada a tecla
    private bool montaTelaAutomatico = true;
    private string nomeCampoBD = null;
    private bool tabEnter = true;
    private string valorPadrao = null;
    private string toolTipMensagem = null;
    //quando passar pelo campo e tiver algo errado será alertado o cliente com icone no campo e depois com aviso ao clicar no aceitar
    private ErrorProvider erroProvider;
    private bool ocultarAlertaErro = false;
    private bool desabilitarControle = false;
    private bool iniciarFocusControle = false;
    private string caracteresEspeciais = null;
    private bool campoValidado = true;
    private int tamanhoMaximo = 0;


    public TextBoxEdit()
    {
      /*
       //linha libera textbox para ter fundo transparente, sem ela da erro
       this.SetStyle(ControlStyles.SupportsTransparentBackColor |
                  ControlStyles.OptimizedDoubleBuffer |
                  ControlStyles.AllPaintingInWmPaint |
                  ControlStyles.ResizeRedraw |
                  ControlStyles.UserPaint, true);
       //this.BackColor = Color.Transparent;
      */
      this.aceitaNumeros = this.PrtAceitaNumeros;
      this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
      this.BackColorExt();
      erroProvider = new ErrorProvider();
      this.Height = Tipos.Constantes.ControleHeight;
      this.Width = 100;
      this.AutoSize = false;
      this.ForeColorExt();
      this.FontExtPadrao();
    }


    #region PROPRIEDADES CRIADAS NO COMPONENTE QUE NÃO APARECEM NA BARRA DO VISUAL APENAS VIA CODIGO É POSSÍVEL UTILIZAR.

    /// <summary>
    /// criei propriedade que guarda a cor da fonte do controle pra devolver ao perder o foco
    /// </summary>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Color PrtForeColorPadrao { get; set; }
    /// <summary>
    /// criei propriedade que guarda a cor de fundo incial do controle pra devolver ao perder o foco
    /// </summary>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Color PrtBackColorPadrao { get; set; }

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

    [Description("Propriedade identifica se campo passou foi validado corretamente retornando True, caso contrário uma mensagem é mostrada.")]//  (opcional)
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string PrtMensagemErroProvider
    {
      get => erroProvider.GetError(this);
      set => erroProvider.SetError(this, value);
    }

    #endregion


    #region PROPRIEDADES CRIADAS NO COMPONENTE


    [Description("Tipo de texto, define o tipo de texto aceito pelo campo.")]//  (opcional)
    [TypeConverter(typeof(Enums.TipoTexto)), Category("EditControls")]
    public Enums.TipoTexto PrtTipoTexto
    {
      get { return tipoTexto; }
      set
      {
        tipoTexto = value;
        if (tipoTexto == Enums.TipoTexto.NUMERICO)
          tamanhoMaximo = 5;
        else if (tamanhoMaximo == 0)
        {
          tamanhoMaximo = 50;
        }

        this.UseSystemPasswordChar = false;
        this.TextAlign = HorizontalAlignment.Right;
        switch (tipoTexto)
        {
          case Enums.TipoTexto.SENHA:
            this.UseSystemPasswordChar = true;
            this.TextAlign = HorizontalAlignment.Left;
            this.CharacterCasing = CharacterCasing.Normal;
            break;
          case Enums.TipoTexto.TEXTO_NORMAL:
            this.CharacterCasing = CharacterCasing.Normal;
            this.TextAlign = HorizontalAlignment.Left;
            break;
          default:
            this.CharacterCasing = CharacterCasing.Upper;
            this.TextAlign = HorizontalAlignment.Left;
            break;
        }
      }
    }


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


    [Description("Se propriedade igual True, será permitido digitos numéricos. Quando PrtTipoTexto = TEXTO_ESPECIAL ou SENHA")] //  (opcional)
    [TypeConverter(typeof(bool)), Category("EditControls")]
    public bool PrtAceitaNumeros
    {
      get { return aceitaNumeros; }
      set { aceitaNumeros = value; }
    }

    [Description("Se propriedade igual True, será permitido teclar espaço. Quando PrtTipoTexto = TEXTO_ESPECIAL ou SENHA")]//  (opcional)
    [TypeConverter(typeof(bool)), Category("EditControls")]
    public bool PrtAceitaEspaco
    {
      get { return aceitaEspaco; }
      set { aceitaEspaco = value; }
    }

    [Description("Informar caracteres especiais que podem ser digitados no campo. Quando PrtTipoTexto = TEXTO_ESPECIAL ou SENHA")]//  (opcional)
    [TypeConverter(typeof(string)), Category("EditControls")]
    public string PrtCaracteresEspeciais
    {
      get { return caracteresEspeciais; }
      set { caracteresEspeciais = value; }
    }

    [Description("Chama formulário de pesquisa ao pressionar F3.")]//  (opcional)
    [TypeConverter(typeof(bool)), Category("EditControls")]
    public bool PrtAtivaPesquisa
    {
      get { return ativaPesquisa; }
      set { ativaPesquisa = value; }
    }

    [Description("Determina se o valor do campo será validado.")]//  (opcional)
    [TypeConverter(typeof(bool)), Category("EditControls")]
    public bool PrtAtivaValidacao
    {
      get { return ativaValidacao; }
      set { ativaValidacao = value; }
    }

    [Description("Informamos o controle do tipo Label que irá ficar vinculado a este campo, para mostrar uma descrição.")]//  (opcional)
    [TypeConverter(typeof(Label)), Category("EditControls")]
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


    [Description("Mostra mensagem para usuário se propriedade PrtCampoObrigatorio igual a true e campo estiver vazio.")]//  (opcional)
    [TypeConverter(typeof(string)), Category("EditControls")]
    public string PrtMensagemCampoObrigatorio
    {
      get { return mensagemCampoObrigatorio; }
      set { mensagemCampoObrigatorio = value; }
    }

    [Description("Quantidade Máxima de caracteres que poderá ser inserido no campo.")]//  (opcional)
    [TypeConverter(typeof(int)), Category("Pratic")]
    public int PrtTamanhoMaximo
    {
      get { return tamanhoMaximo; }
      set
      {
        tamanhoMaximo = value;
        this.MaxLength = tamanhoMaximo;
      }
    }


    [Description("Define se campo é de preenchimento obrigatório.")]
    [TypeConverter(typeof(bool)), Category("EditControls")]
    public bool PrtCampoObrigatorio
    {
      get { return campoObrigatorio; }
      set { campoObrigatorio = value; }
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
      this.PrtBackColorPadrao = this.BackColor;
      this.PrtForeColorPadrao = this.ForeColor;
      this.BackColorOnFocusExt();
      this.SelectAll();

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
      this.BackColor = this.PrtBackColorPadrao;
      this.ForeColor = this.PrtForeColorPadrao;
    }

    //Evento onKeyDown - travamos edição do campo
    protected override void OnKeyDown(KeyEventArgs e)
    {
      //18/04/16 - bloqueia edição do controle quando propriedade igual a true
      if (desabilitarControle == true)
      {
        e.SuppressKeyPress = true;
        return;
      }
      base.OnKeyDown(e);
    }

    protected override void OnKeyPress(KeyPressEventArgs e)
    {
      try
      {
        //Valida quantidade de digitos
        int tamanho = string.IsNullOrEmpty(this.Text) ? 0 : this.TextLength + (e.KeyChar == 08 ? -1 : +1); //numero 1 represente ao e.keychar digitado
        if (e.KeyChar == 08) //vamos ver se é o backspace, antes de verificar a quantidade de caracteres digitados
        {
          return;
        }

        if (tamanho > this.MaxLength && this.SelectionLength == 0) //só cancela o caracter digitado se der a quantidade e não tiver nada selecionado
        {
          e.Handled = true;
          return;
        }
        switch (PrtTipoTexto)
        {
          case Enums.TipoTexto.NUMERICO:
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && !char.IsControl(e.KeyChar))
            {
              //Atribui True no Handled para cancelar o evento
              e.Handled = true;
            }
            break;
          case Enums.TipoTexto.TEXTO_MAIUSCULO:
            break;
          case Enums.TipoTexto.TEXTO_ESPECIAL:
          case Enums.TipoTexto.SENHA:
            // quando caracteres especiais faremos algumas verificações
            if (char.IsNumber(e.KeyChar))
            {
              if (aceitaNumeros == false)//numeros
              {
                e.Handled = true; //cancela não pode
                erroProvider.SetError(this, "Não é permitido dígitos numéricos");
              }
              return;
            }
            else if (e.KeyChar == 32) //espaço
            {
              if (aceitaEspaco == false)
              {
                e.Handled = true;
                erroProvider.SetError(this, "Não é permitido caracter espaço");
              }
              return;

            }
            else if (e.KeyChar == 13)
            {
              //mais abaixo segue execução, aqui não faz nada
            }
            else if (char.IsLetter(e.KeyChar) == false) // diferente de letras
            {
              if (string.IsNullOrEmpty(caracteresEspeciais)) // verifica caracteres especiais
              {
                e.Handled = true; // nao permiti caracteres especiais
                return;
              }
              else //verifica se caracter digitado consta na lista permitida
              {
                if (caracteresEspeciais.IndexOf(e.KeyChar) == -1) //nao encontrou
                {
                  e.Handled = true;
                  return;
                }

              }
            }
            break;
        }

      }
      catch
      {

      }
      finally
      {
        base.OnKeyPress(e);
        this.Refresh();
      }

    }


    //quando objeto estiver perdendo o foco passa aqui, e faz verificações e validações
    protected override void OnValidating(CancelEventArgs e)
    {
      if (string.IsNullOrEmpty(this.Text) && campoObrigatorio == true)
        PrtMensagemErroProvider = PrtMensagemCampoObrigatorio;
      else
        PrtMensagemErroProvider = "";

      base.OnValidating(e);
      this.Refresh();
    }

    //evento Refresh
    public override void Refresh()
    {
      base.Text = this.Text;
      base.Refresh();
    }


    #endregion

    #region <<<<< Metodos Criados >>>>>>>


    //Metodo captura o valor informado na propriedade valor padrao
    public void GetValorPadrao()
    {
      this.Text = valorPadrao;
    }


/*    public void AtualizaErroProvider(string mensagem)
    {
      erroProvider.SetError(this, mensagem); //atualiza componente errorProvider

    }
*/

    #endregion   <<<<<<< fim dos metodos >>>>>>>>>>

  }
}
