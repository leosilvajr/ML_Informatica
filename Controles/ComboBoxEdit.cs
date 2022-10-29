using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Controles
{
  public class ComboBoxEdit : ComboBox
  {
    private bool aceitaNumeros = false;
    private bool aceitaEspaco = false;
    private Enums.TipoTexto tipoTexto = Enums.TipoTexto.TEXTO_MAIUSCULO;
    private bool naoLimparControle = false;
    private string mensagemCampoObrigatorio = "Campo não pode ser vazio !";
    private bool campoObrigatorio = false;
    private bool gravaParametroTela = false;
    //private Color corCampo;
    //private Color corFonte;
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
    private bool desabilitarControle = true;
    private bool iniciarFocusControle = false;
    private string caracteresEspeciais = null;
    private bool campoValidado = true;

    // private StringAlignment _textAlign = StringAlignment.Center;
    // private int _textYOffset = 0;

    public ComboBoxEdit()
    {

      //// Set OwnerDrawVariable to indicate we will manually draw all elements.
      //this.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
      //// DropDownList style required for selected item to respect our DrawItem customizations.
      //this.DropDownStyle = ComboBoxStyle.DropDownList;
      //// Hook into our DrawItem & MeasureItem events
      //this.DrawItem +=
      //    new DrawItemEventHandler(ComboBox_DrawItem);
      //this.MeasureItem +=
      //    new MeasureItemEventHandler(ComboBox_MeasureItem);

      this.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
      this.AutoCompleteSource = AutoCompleteSource.ListItems;

      //27/10/2021 - combo ao navegar na lista e selecionar um item, perdia a cor de fundo que tinha sido definida
      //as duas propriedades abaixo, ajustam isso, fiz o teste funcionou.
      this.DropDownStyle = ComboBoxStyle.DropDownList;
      this.FlatStyle = FlatStyle.Standard;

      erroProvider = new ErrorProvider();
      //this.Height = Tipos.Constantes.ControleHeight;
      this.Width = 200;
      this.BackColorExt();
      this.ForeColorExt();
      this.FontExtPadrao();

    }


    #region PROPRIEDADES CRIADAS NO COMPONENTE QUE NÃO APARECEM NA BARRA DO VISUAL APENAS VIA CODIGO É POSSÍVEL UTILIZAR.

    //[Description("String Alignment")]
    //[Category("CustomFonts")]
    //[DefaultValue(typeof(StringAlignment))]
    //public StringAlignment TextAlign
    //{
    //  get { return _textAlign; }
    //  set
    //  {
    //    _textAlign = value;
    //  }
    //}

    //[Description("When using a non-centered TextAlign, you may want to use TextYOffset to manually center the Item text.")]
    //[Category("CustomFonts")]
    //[DefaultValue(typeof(int))]
    //public int TextYOffset
    //{
    //  get { return _textYOffset; }
    //  set
    //  {
    //    _textYOffset = value;
    //  }
    //}

    //// Allow Combo Box to center aligned and manually draw our items
    //private void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
    //{


    //  // Draw the background
    //  e.DrawBackground();

    //  // Draw the items
    //  if (e.Index >= 0)
    //  {
    //    // Set the string format to our desired format (Center, Near, Far)
    //    StringFormat sf = new StringFormat();
    //    sf.LineAlignment = _textAlign;
    //    sf.Alignment = _textAlign;

    //    // Set the brush the same as our ForeColour
    //    Brush brush = new SolidBrush(this.ForeColor);

    //    // If this item is selected, draw the highlight
    //    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
    //      brush = SystemBrushes.HighlightText;


    //    // Draw our string including our offset.
    //    e.Graphics.DrawString(this.Items[e.Index].ToString(), this.Font, brush,
    //        new RectangleF(e.Bounds.X, e.Bounds.Y + _textYOffset, e.Bounds.Width, e.Bounds.Height), sf);
    //  }

    //}


    //// If you set the Draw property to DrawMode.OwnerDrawVariable, 
    //// you must handle the MeasureItem event. This event handler 
    //// will set the height and width of each item before it is drawn. 
    //private void ComboBox_MeasureItem(object sender, System.Windows.Forms.MeasureItemEventArgs e)
    //{
    //  // Custom heights per item index can be done here.
    //}

    [Description("Propriedade identifica se campo passou foi validado corretamente retornando True, caso contrário uma mensagem é mostrada.")]//  (opcional)
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string PrtMensagemErroProvider
    {
      get => erroProvider.GetError(this);
      set => erroProvider.SetError(this, value);
    }

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

    /*   [TypeConverter(typeof(int)), Category("EditControls")]
       [Browsable(false)]
       [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
       public int GetToInt
       {
         get { return Util.GetToInt(this.Text); }
       }

       [TypeConverter(typeof(long)), Category("EditControls")]
       [Browsable(false)]
       [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
       public long GetToLong
       {
         get { return Util.GetToLong(this.Text); }
       }

       */
    #endregion


    #region PROPRIEDADES CRIADAS NO COMPONENTE

    [Description("Tipo de texto, define o tipo de texto aceito pelo campo.")]//  (opcional)
    [TypeConverter(typeof(Enums.TipoTexto)), Category("Pratic")]
    public Enums.TipoTexto PrtTipoTexto
    {
      get
      {
        return tipoTexto;
      }
      set
      {
        if (tipoTexto == value)
        {
          return;
        }
        tipoTexto = value;
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
    [TypeConverter(typeof(String)), Category("EditControls")]
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
    [TypeConverter(typeof(String)), Category("EditControls")]
    public string PrtNomeCampoBD
    {
      get { return nomeCampoBD; }
      set { nomeCampoBD = value; }
    }

    [Description("Determina que campo será valorado no metodo MontaTela automaticamente.")]//  (opcional)
    [TypeConverter(typeof(Boolean)), Category("EditControls")]
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
    [TypeConverter(typeof(bool)), Category("EditControls")]
    public string PrtCaracteresEspeciais
    {
      get { return caracteresEspeciais; }
      set { caracteresEspeciais = value; }
    }

    [Description("Chama formulário de pesquisa ao pressionar F3.")]//  (opcional)
    [TypeConverter(typeof(Boolean)), Category("EditControls")]
    public bool PrtAtivaPesquisa
    {
      get { return ativaPesquisa; }
      set { ativaPesquisa = value; }
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


    [Description("Mostra mensagem para usuário se propriedade PrtCampoObrigatorio igual a true e campo estiver vazio.")]//  (opcional)
    [TypeConverter(typeof(string)), Category("EditControls")]
    public string PrtMensagemCampoObrigatorio
    {
      get { return mensagemCampoObrigatorio; }
      set { mensagemCampoObrigatorio = value; }
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
    /*
    //sobrescrevi metodo para poder usar DrawMode = OwnerDrawVariable, sem isso os itens não apareciam na lista suspensa.
    protected override void OnDrawItem(DrawItemEventArgs e)
    {
      base.OnDrawItem(e);
      e.DrawBackground();
      Brush myBrush = Brushes.Black;
      Font ft = this.Font;
      e.Graphics.DrawString(this.Items[e.Index].ToString(), ft, myBrush, e.Bounds, StringFormat.GenericDefault);
      e.DrawFocusRectangle();
    }
    */

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
      this.BackColor = this.PrtBackColorPadrao; //Color.White;
      this.ForeColor = this.PrtForeColorPadrao;
    }

    //Evento onKeyDown - travamos edição do campo
    protected override void OnKeyDown(KeyEventArgs e)
    {
      try
      {

        //18/04/16 - bloqueia edição do controle quando propriedade igual a true
        if (desabilitarControle == true)
        {
          e.SuppressKeyPress = true;
          return;
        }
        else if (ModifierKeys == Keys.Control)
        {
          e.SuppressKeyPress = true;
          return;
        }
        base.OnKeyDown(e);
      }
      catch (Exception)
      {

        throw;
      }
    }

    /*  COMENTEI CASO PRECISE DESSE EVENTO EU VOLTO
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
          try
          {
            if (ModifierKeys == Keys.Control)
            {
              e.Handled = true;
              return;
            }
            // e.KeyChar = Char.ToUpper(e.KeyChar);
            base.OnKeyPress(e);
          }
          catch (Exception)
          {

            throw;
          }

        }
    */


    #endregion

    #region <<<<< Metodos Criados >>>>>>>

    /// <summary>
    /// Propriedade retorna valor selecionado, já fazendo as verificações para evitar erro.
    /// </summary>
    public string GetText
    {
      get
      {
        if (this.SelectedValue == null) return null;
        else if (string.IsNullOrEmpty(this.SelectedValue.ToString())) return null;
        else return this.SelectedValue.ToString();

      }
    }


    /// <summary>
    /// Método procura item que contenha valor da propriedade Text;
    /// </summary>
    /// <param name="cb"> não precisa ser passado já que utilizamos a palavra this.(compilador entende como um metodo de extensão.)</param>
    /// <param name="valor">valor a ser procurado no ComboBox</param>
    /// <param name="tipo">defini se busca exata ou aproximada </param>
    /// <returns></returns>
    public void ProcurarItem(ComboBoxEdit cb, string valor, Enums.TipoBuscaConsulta tipo = Enums.TipoBuscaConsulta.EXATA)
    {
      int id = -1;
      switch (tipo)
      {
        case Enums.TipoBuscaConsulta.EXATA:
          {
            id = cb.FindStringExact(valor);
            break;
          }
        case Enums.TipoBuscaConsulta.INICIA:
          {
            id = cb.FindString(valor); //busca o primeiro registro que inicia com valor da string
            break;
          }
        case Enums.TipoBuscaConsulta.CONTEM:
          {
            break;
          }

      }

      if (id >= 0)
      {
        this.SelectedIndex = id;
      }

    }


    #endregion   <<<<<<< fim dos metodos >>>>>>>>>>

  }

}
