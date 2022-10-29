using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static Controles.Enums;


namespace Controles
{
  public class MaskedTextBoxEdit : MaskedTextBox
  {
    private bool aceitaValorNulo = false;
    private bool aceitaValorNegativo = false;
    private bool validaCampo = true; // campos como cnpj, cpf, pis...etc
    private Enums.TipoCampo tipoCampo = Enums.TipoCampo.DECIMAL;
    private bool naoLimparControle = false;
    private string mensagemCampoObrigatorio = "Campo não pode ser vazio !";
    private bool campoObrigatorio = false;
    private bool gravaParametroTela = false;
    private Color corCampo;
    private Color corFonte;
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
    private int qtdCasaDecimal = 2;
    private decimal valorMaximoPermitido = 0;
    private int qtdeCaracteresPermitido = 0;
    private bool desabilitarControle = true;
    private bool iniciarFocusControle = false;
    private bool manterAlinhamentoLeft = false;
    private bool ativarUpperCase = false;
    private bool abortarEventKeyUp = false; //criei variavel para não deixar continuar ação no evento KeyUp se no KeyDown for abortado (estou usando na telas de consulta)

    public MaskedTextBoxEdit()
    {
      this.PromptChar = ' '; //remove linha underline da mascara
                             //09/11/15 - OBSERVACAO IMPORTANTE:
                             //componente foi criado aqui para que cada campo tenha seu objeto errorProvider, evitando o problema que estava acontecendo 
                             //onde todos os objetos da tela tremiam por estar sendo atualizado o componente errorProvider.
      erroProvider = new ErrorProvider();
      this.Width = 100;
      this.Height = Tipos.Constantes.ControleHeight;
      this.BackColorExt();
      this.ForeColorExt();
      this.FontExtPadrao();
      this.AutoSize = false;
      this.Text = "";
    }


    #region PROPRIEDADES CRIADAS NO COMPONENTE QUE NÃO APARECEM NA BARRA DO VISUAL APENAS VIA CODIGO É POSSÍVEL UTILIZAR.

    /*
    //CONVETE TEXTO EM DOUBLE
    [TypeConverter(typeof(double)), Category("EditControls")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public double GetToDouble
    {
      get { return Util.GetToDouble(this.Text); }
    }

    [TypeConverter(typeof(int)), Category("EditControls")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public decimal GetToInt
    {
      get { return Util.GetToInt(this.Text); }
    }

    //CONVERTE TEXTO EM DECIMAL
    [TypeConverter(typeof(decimal)), Category("EditControls")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public decimal GetToDecimal
    {
      get { return Util.GetToDecimal(this.Text); }
    }
    */

    // ocultar a propriedade Mask   (opcional) (essa nossa propriedade nova identica a do MaskedTextBox,  que vai atribuiro valor a Ele.
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new string Mask
    {
      get
      {
        return base.Mask;
      }
      set
      {
        base.Mask = value;
      }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool AbortarEventKeyUp { get => abortarEventKeyUp; set => abortarEventKeyUp = value; }


    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string PrtMensagemErroProvider
    {
      get => erroProvider.GetError(this);
      set => erroProvider.SetError(this, value);
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string PrtValorDigitado { get; set; }

    #endregion


    #region PROPRIEDADES CRIADAS NO COMPONENTE

    /*
		 * Para identificarmos o tipo de validação foi necessário criar uma propriedade “TipoValidacao” 
		 * usando os operadores “Get” e “Set”, pois através deles que podemos recuperar e atribuir os valores 
		 * descritos acima. Graças a esta propriedade que conseguimos manipular as configurações propostas pelo desenvolvedor.
		 * */

    //    [DisplayName("EditMask")]// para exibir em propriedades com o nome 'Mask'  (opcional)
    [Description("Propriedade Tipo de Campo importante para definir comportamento do controle. \n Criado por Samuel")]//  (opcional)
    [RefreshProperties(RefreshProperties.All)]//  (opcional)
    [TypeConverter(typeof(Enums.TipoCampo)), Category("EditControls")]
    public Enums.TipoCampo PrtTipoCampo
    {
      get
      {
        return tipoCampo;
      }
      set
      {
        if (tipoCampo == value)
        {
          return;
        }
        this.TextAlign = HorizontalAlignment.Left; //defino alinhamento padrão, depois será alterado se necessário
        this.Text = "";
        tipoCampo = value;
        this.Refresh();
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


    [Description("Quando igual a true grava valor do campo no arquivo ConfigSis.ini.")]
    [TypeConverter(typeof(bool)), Category("EditControls")]
    public bool PrtGravaParametroTela
    {
      get { return gravaParametroTela; }
      set { gravaParametroTela = value; }
    }

    [Description("Quando igual a true método LimpaControles não vai apagar valor do campo.")]
    [TypeConverter(typeof(bool)), Category("EditControls")]
    public bool PrtNaoLimparControle
    {
      get { return naoLimparControle; }
      set { naoLimparControle = value; }
    }

    [Description("Quando campo for do tipo TEXTO, esta propriedade será validada.")]
    [TypeConverter(typeof(int)), Category("EditControls")]
    public int PrtQtdeCaracteresPermitido
    {
      get { return qtdeCaracteresPermitido; }
      set { qtdeCaracteresPermitido = value; }
    }

    [Description("Quando campo for do tipo DECIMAL, esta propriedade será validada.")]
    [TypeConverter(typeof(decimal)), Category("EditControls")]
    public decimal PrtValorMaximoPermitido
    {
      get { return valorMaximoPermitido; }
      set { valorMaximoPermitido = value; }
    }

    //apenas para mostrar em tela o valor formatado bonitinho no errorprovider
    public string PrtValorMaximoPermitidoFormatado
    {
      get
      {
        if (tipoCampo == TipoCampo.DECIMAL)
          return String.Format("{0:N" + qtdCasaDecimal.ToString() + "}", this.PrtValorMaximoPermitido);
        else
          return "";
      }
    }

    [Description("Quando campo for do tipo DECIMAL, propriedade será utilizada na formatação do valor.")]//  (opcional)
    [TypeConverter(typeof(int)), Category("EditControls")]
    public int PrtQtdCasaDecimal
    {
      get { return qtdCasaDecimal; }
      set
      {
        qtdCasaDecimal = value;
        Refresh();

      }
    }

    [Description("Mostra mensagem para usuário se propriedade PrtCampoObrigatorio igual a true e campo estiver vazio.")]//  (opcional)
    [TypeConverter(typeof(string)), Category("EditControls")]
    public string PrtMensagemCampoObrigatorio
    {
      get { return mensagemCampoObrigatorio; }
      set { mensagemCampoObrigatorio = value; }
    }

    [Description("Define se campo passará pelo metódo ValidaCamposTela")]
    [TypeConverter(typeof(bool)), Category("EditControls")]
    public bool PrtValidaCampo
    {
      get { return validaCampo; }
      set { validaCampo = value; }
    }

    [Description("Define se campo é de preenchimento obrigatório.")]
    //[TypeConverter(typeof(PrtLibrary.Componentes.AceitaValorNulo)), Category("EditControls")]
    [TypeConverter(typeof(bool)), Category("EditControls")]
    public bool PrtCampoObrigatorio
    {
      get { return campoObrigatorio; }
      set { campoObrigatorio = value; }
    }

    [Description("Defini se campo aceita valores negativos, quando tipo igual a DECIMAL ou INTEIRO")]
    //[TypeConverter(typeof(PrtLibrary.Componentes.AceitaValorNegativo)), Category("EditControls")]
    [TypeConverter(typeof(bool)), Category("EditControls")]
    public bool PrtAceitaValorNegativo
    {
      get { return aceitaValorNegativo; }
      set { aceitaValorNegativo = value; }
    }

    [Description("Mantém o alinhamento do campo a esquerda independente do tipo. (ex: usamos na tela de consulta).")]//  (opcional)
    [TypeConverter(typeof(bool)), Category("EditControls")]
    public bool PrtManterAlinhamentoLeft
    {
      get { return manterAlinhamentoLeft; }
      set { manterAlinhamentoLeft = value; }
    }

    [Description("Ativa letras maiúsculas quando PrtTipoCampo = TEXTO, se valor igual a True")]//  (opcional)
    [TypeConverter(typeof(bool)), Category("EditControls")]
    public bool PrtAtivarUpperCase
    {
      get { return ativarUpperCase; }
      set { ativarUpperCase = value; }
    }

    #endregion

    //Propriedades que estamos Sobrescrevendo
    #region PROPRIEDADES MASKEDTEXTBOX (SOBRESCREVER)

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
      this.SelectAll();
     // this.Select(0, 0);
     // this.SelectionLength = 0;

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
      abortarEventKeyUp = false;
      //18/04/16 - bloqueia edição do controle quando propriedade igual a false
      if (desabilitarControle == true)
      {
        e.SuppressKeyPress = true;
        abortarEventKeyUp = true;
        return;
      }
      else if (e.KeyCode == Keys.Back && string.IsNullOrEmpty(this.Text))
      {
        e.SuppressKeyPress = true;
        abortarEventKeyUp = true; // vou interromper, evitando ações em tela desnecessarias (27/10/2021 - colocado para teste)
        return;
      }
      else if (ativaPesquisa == true && !char.IsLetterOrDigit((char)e.KeyCode)) //bloqueia teclas diferente de numeros e letras se tiver ativado pesquisa no campo
      {
        e.SuppressKeyPress = true;
        abortarEventKeyUp = true;

      }
      base.OnKeyDown(e);
    }

    protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
    {
      try
      {

        if (e.KeyChar == 08) //vamos ver se é o backspace, antes de verificar a quantidade de caracteres digitados
          return;
        else if (e.KeyChar == (char)Keys.Enter) //se enter sai fora e continua
          return;

        switch (tipoCampo)
        {
          case TipoCampo.DECIMAL:
            if (char.IsNumber(e.KeyChar))
              break;
            else if (e.KeyChar == ',' || e.KeyChar == '.')
            {
              e.KeyChar = ','; //força para virgula caso digite ponto
              if (base.Text.Contains(e.KeyChar.ToString()) == true) // se ja digitou uma vez não deixa continuar
              {
                e.Handled = true;
                abortarEventKeyUp = true;
              }
            }
            else { e.Handled = true; }
            break;
          case TipoCampo.INTEIRO:
            if (!char.IsNumber(e.KeyChar))
            {
              e.Handled = true;
              abortarEventKeyUp = true;
            }
            break;
          case TipoCampo.TEXTO:
            if (PrtQtdeCaracteresPermitido > 0)
            {
              if (base.Text.Length >= PrtQtdeCaracteresPermitido)
              {
                e.Handled = true;
                abortarEventKeyUp = true;

              }
            }
            if (ativarUpperCase)
              e.KeyChar = char.ToUpper(e.KeyChar);
            break;
          default:  //outros tipos de mascara passa aqui e aceita 
            break;
        }

      }
      finally
      {
        if (e.Handled == false)
          base.OnKeyPress(e);
        // this.Refresh();  //nao pode executar o Refresh aqui, ex: campo decimal, quando digitava ele zicava. (não descomentar)
      }

    }

    protected override void OnKeyUp(KeyEventArgs e)
    {
      if (abortarEventKeyUp == true)
      {
        e.SuppressKeyPress = true;
        return;
      }
      base.OnKeyUp(e);
    }

    //quando objeto estiver perdendo o foco passa aqui, e faz verificações e validações
    protected override void OnValidating(System.ComponentModel.CancelEventArgs e)
    {
      if (string.IsNullOrEmpty(this.Text) && campoObrigatorio == true)
        PrtMensagemErroProvider = PrtMensagemCampoObrigatorio;
      else
        PrtMensagemErroProvider = "";

      base.OnValidating(e);
      this.Refresh();
      PrtValorDigitado = this.Text; 
    }

    //evento Refresh
    public override void Refresh()
    {
      ColocaMascaraCampo();
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
      //_MensagemErroProvider = mensagem; //atualiza propriedade do objeto
      erroProvider.SetError(this, mensagem); //atualiza componente errorProvider

    }
*/
    //Valida se aceita valor negativo
    public bool ValidaAceitaValorNegativo()
    {
      try
      {
        bool status = false;
        switch (tipoCampo)
        {
          case TipoCampo.DECIMAL:
          case TipoCampo.INTEIRO:
            if (string.IsNullOrEmpty(this.Text.Trim())) return true;
            if (aceitaValorNegativo == false && this.GetToDecimalEx() < 0)
              status = false;
            else status = true;
            break;
          default:
            status = true;
            break;
        }
        return status;
      }
      catch
      {
        return false;
      }
    }

    //Valida se campo pode aceitar valor Nulo ou vazio
    public bool ValidaAceitaValorNulo()
    {
      try
      {
        this.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        string valor = this.Text.Trim();
        this.TextMaskFormat = MaskFormat.IncludeLiterals;
        if (aceitaValorNulo == false && string.IsNullOrEmpty(valor))
          return false;
        else
          return true;

      }
      catch
      {
        return false;
      }
    }

    private void ColocaMascaraCampo()
    {
      try
      {
        switch (tipoCampo)
        {
          case TipoCampo.CEP:
            this.Mask = "00000-000"; //virgula funciona como separador mostra ponto na tela (removi o , porque no banco usa sem)
            break;
          case TipoCampo.DATA:
            this.Mask = "00/00/0000";
            break;
          case TipoCampo.INTEIRO:
            this.Mask = ""; //deixar sem mascara porque vamos colocar na hora vamos usar o propriedade ValorMaximo
            if (manterAlinhamentoLeft == false)
              this.TextAlign = HorizontalAlignment.Right;
            //this.Text = Util.FormatarInteiro(this.Text, this.PrtValorMaximoPermitido.ToString().Length);
            this.GetToIntFormatadoEx(this.PrtValorMaximoPermitido.ToString().Length);
            break;
          case TipoCampo.DECIMAL:
            this.Mask = "";
            if (manterAlinhamentoLeft == false)
              this.TextAlign = HorizontalAlignment.Right;
            //            this.Text = Util.FormatarDecimal(this.Text, this.PrtQtdCasaDecimal);
            this.GetToStringFormatadoExt();
            break;
          case TipoCampo.CNPJ:
            this.Mask = "99,999,999/9999-99"; //virgula funciona como separador mostra ponto na tela
            break;
          case TipoCampo.CPF:
            this.Mask = "000,000,000-00"; //virgula funciona como separador mostra ponto na tela
            break;
          case TipoCampo.FONE:
            this.Mask = "(00)0000-0000";
            break;
          case TipoCampo.CELULAR:
            this.Mask = "(00)#0000-0000";
            break;
          case TipoCampo.NCM:
            this.Mask = "99999999999999";
            break;
          case TipoCampo.PIS:
            this.Mask = "000,00000,00-00"; //virgula funciona como separador mostra ponto na tela
            break;
          case TipoCampo.PLACA:
            this.Mask = ">LLL-0>A00";  //> converte para maiusculo ? caracter opcional, L - caracter requerido
            break;
          case TipoCampo.TEXTO:
            this.Mask = "";
            this.TextAlign = HorizontalAlignment.Left;
            break;
          default:
            this.Mask = "";
            break;

        }

      }
      catch (Exception)
      {

        throw;
      }
    }

    #endregion   <<<<<<< fim dos metodos >>>>>>>>>>

  }
}