
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Controles
{
    public class ButtonEdit : Button
    {
        private bool desabilitarControle = false;
        private string toolTipMensagem = null;
        private bool iniciarFocusControle = false;
        private Enums.TipoEstiloBotao estiloBotao = Enums.TipoEstiloBotao.Nenhum;
        private Enums.ImagemAlignmento imagemAlinhamento = Enums.ImagemAlignmento.MiddleLeft;
        private Color backColorOriginalEventEnabled;

        public ButtonEdit()
        {

            this.TextAlign = ContentAlignment.MiddleCenter;
            this.TextImageRelation = TextImageRelation.Overlay;
            this.FlatStyle = FlatStyle.Flat;

            this.PrtBackColorPadrao = Color.Transparent; //servira de flag
            corFonte = Color.Transparent;
            //this.BackColor = Color.PowderBlue;
        }


        #region PROPRIEDADES CRIADAS NO COMPONENTE
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

        private Color corFonte;

        [Description("Define que controle iniciará com o foco quando tela for carregada).")]//  (opcional)
        [TypeConverter(typeof(bool)), Category("EditControls")]
        public bool PrtIniciaFocusControle
        {
            get { return iniciarFocusControle; }
            set { iniciarFocusControle = value; }
        }

        [Description("Informe uma mensagem para ser mostrada ao usuário, quando passar o cursor sobre o controle.")]//  (opcional)
        [TypeConverter(typeof(string)), Category("EditControls")]
        public string PrtToolTipMensagem
        {
            get { return toolTipMensagem; }
            set { toolTipMensagem = value; }
        }

        [Description("Se propriedade igual a True, campo não poderá ser editado).")]//  (opcional)
        [TypeConverter(typeof(bool)), Category("EditControls")]
        public bool PrtDesabilitarControle
        {
            get { return desabilitarControle; }
            set { desabilitarControle = value; }
        }

        [Description("Tipo Estilo de Botão, define cor de fundo e cor da letra .")]//  (opcional)
        [TypeConverter(typeof(Enums.TipoEstiloBotao)), Category("EditControls")]
        public Enums.TipoEstiloBotao PrtEstiloBotao

        {
            get { return estiloBotao; }
            set
            {
                estiloBotao = value;
                Padding pad = new Padding();
                pad.Left = 5;
                pad.Right = 5;
                this.Padding = pad;

                switch (estiloBotao)
                {
                    case Enums.TipoEstiloBotao.PowerBlue:
                        this.BackColor = Color.PowderBlue;
                        this.ForeColor = Color.Black;
                        break;
                    case Enums.TipoEstiloBotao.SteelBlue:
                        this.BackColor = Color.SteelBlue;
                        this.ForeColor = Color.WhiteSmoke;
                        break;
                    case Enums.TipoEstiloBotao.MediumTurquoise:
                        this.BackColor = Color.MediumTurquoise;
                        this.ForeColor = Color.Black;
                        break;
                    case Enums.TipoEstiloBotao.Nenhum:
                        this.BackColor = Color.Transparent;
                        //this.ForeColorExt();
                        break;
                }
            }
        }


        [Description("Defini o alinhamento da Imagem .")]
        [TypeConverter(typeof(Enums.ImagemAlignmento)), Category("EditControls")]
        public Enums.ImagemAlignmento PrtImagemAlinhamento
        {
            get { return imagemAlinhamento; }
            set
            {
                imagemAlinhamento = value;
                this.ImageAlign = (ContentAlignment)imagemAlinhamento;
            }
        }

        #endregion

        #region EVENTOS OVERRIDE (SOBRESCRITOS)

        /// <summary>
        /// A resposta do fuex pode remover a fronteira em teoria, mas há um bug que às vezes o botão 
        /// ainda terá uma sugestão de foco após você alterar o status de habilitação do botão. 
        /// (Encontrei esse bug no.Net 4.0 e não sei se o bug foi corrigido ou não nas versões posteriores).
        /// Para contornar esse bug, você deve desativar a ShowFocusCuespropriedade:
        /// </summary>
        protected override bool ShowFocusCues => false; // return base.ShowFocusCues;

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            if (this.Enabled == false)
            {
                backColorOriginalEventEnabled = this.BackColor;
                this.BackColor = Color.LightGray;
            }
            else
                this.BackColor = backColorOriginalEventEnabled;
        }

        //Ocorre quando o ponteiro do mouse fica no controle.
        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
           // this.PrtBackColorPadrao = this.PrtBackColorPadrao == Color.Transparent ? this.BackColor : this.PrtBackColorPadrao;
           // corFonte = corFonte == Color.Transparent ? this.ForeColor : corFonte;
        }

        //Ocorre quando o ponteiro do mouse é movido sobre o controle.
        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            base.OnMouseMove(mevent);
           // this.PrtBackColorPadrao = this.PrtBackColorPadrao == Color.Transparent ? this.BackColor : this.PrtBackColorPadrao;
           // corFonte = corFonte == Color.Transparent ? this.ForeColor : corFonte;

        }

        //Ocorre quando o ponteiro do mouse deixa o controle.
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
           // this.BackColor = this.PrtBackColorPadrao;
           // this.ForeColor = corFonte;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);

        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            //this.PrtBackColorPadrao = this.PrtBackColorPadrao == Color.Transparent ? this.BackColor : this.PrtBackColorPadrao;
            //corFonte = corFonte == Color.Transparent ? this.ForeColor : corFonte;
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
           // this.BackColor = this.PrtBackColorPadrao;
           // this.ForeColor = corFonte;
        }

        //aqui defino posição da imagem no botão com base se tem texto ou não
        public override string Text
        {
            get
            {
                // PosicionaImagem();
                return base.Text;
            }
            set
            {
                base.Text = value;
                // PosicionaImagem();
            }

        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
          //  this.PrtBackColorPadrao = this.PrtBackColorPadrao == Color.Transparent ? this.BackColor : this.PrtBackColorPadrao;
          //  corFonte = corFonte == Color.Transparent ? this.ForeColor : corFonte;
          //  this.BackColorOnFocusExt();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
         //   this.BackColor = this.PrtBackColorPadrao;
         //   this.ForeColor = corFonte;
        }
        #endregion

        #region METODOS CRIADOS


        /*
            //metodo criado para alterar a posição da imagem no botão.
            private void PosicionaImagem()
            {
              //OBS: problema deste metodo é que se o usuario mudar a propriedade manualmente ele não vai permitir, deixando uma das opções abaixo.
              //27-07/21 - NAO ESTOU USANDO MAIS, RE-PENSAR.
              this.ImageAlign = string.IsNullOrEmpty(base.Text) ? ContentAlignment.MiddleCenter : ContentAlignment.MiddleLeft;
            }
        */

        #endregion
    }
}
