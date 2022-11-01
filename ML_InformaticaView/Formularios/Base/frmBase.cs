using Controles;
using ML_InformaticaView.Funcoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionarios.Formularios
{
    public partial class frmBase : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;
        public frmBase()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.FormBorderStyle = FormBorderStyle.None;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private const int CS_DropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }
        }
        public virtual void MontaTela()
        {

        }
        public virtual void MontaTela<T>(T entidade, bool limparControles = true)
        {
            if (entidade == null) return;
            if (limparControles) LimpaControles(this.Controls);
            PreencheControles(this.Controls, entidade);
        }
        private void PreencheControles<T>(Control.ControlCollection ctrcol, T entidade)
        {
            try
            {

                foreach (Control ctl in ctrcol)
                {
                    try
                    {
                        if (ctl is TextBoxEdit txt)
                        {
                            if (txt.PrtMontaTelaAutomatico = true && txt.PrtNomeCampoBD.LengthExt() > 0)
                                txt.Text = entidade.GetType()
                                          .GetProperty(txt.PrtNomeCampoBD)
                                          .GetValue(entidade, null).ToStringExt();
                        }
                        else if (ctl is MaskedTextBoxEdit mtb)
                        {
                            if (mtb.PrtMontaTelaAutomatico = true && mtb.PrtNomeCampoBD.LengthExt() > 0)
                            {
                                mtb.Text = entidade.GetType()
                                          .GetProperty(mtb.PrtNomeCampoBD)
                                          .GetValue(entidade, null).ToStringExt();
                                mtb.PrtValorDigitado = mtb.GetTextSemMascara();
                            }

                        }

                        else if (ctl is LabelEdit lbl)
                        {
                            if (lbl.PrtMontaTelaAutomatico = true && lbl.PrtNomeCampoBD.LengthExt() > 0)
                                lbl.Text = entidade.GetType()
                                          .GetProperty(lbl.PrtNomeCampoBD)
                                          .GetValue(entidade, null).ToStringExt();
                        }
                        else if (ctl is CheckBoxEdit ckbe)
                        {
                            if (ckbe.PrtMontaTelaAutomatico = true && ckbe.PrtNomeCampoBD.LengthExt() > 0)
                                ckbe.Text = entidade.GetType()
                                          .GetProperty(ckbe.PrtNomeCampoBD)
                                          .GetValue(entidade, null).ToString();
                        }
                        else if (ctl is ComboBoxEdit cboe)
                        {
                            if (cboe.PrtMontaTelaAutomatico = true && cboe.PrtNomeCampoBD.LengthExt() > 0)
                            {
                                cboe.Text = entidade.GetType()
                                          .GetProperty(cboe.PrtNomeCampoBD)
                                          .GetValue(entidade, null).ToString();

                            }
                        }
                        else if (ctl is RadioButtonEdit rad)
                        {
                            if (rad.PrtMontaTelaAutomatico = true && rad.PrtNomeCampoBD.LengthExt() > 0)
                                rad.Checked = (bool)entidade.GetType()
                                          .GetProperty(rad.PrtNomeCampoBD)
                                          .GetValue(entidade, null);
                        }
                        else if (ctl.HasChildren)
                            PreencheControles(ctl.Controls, entidade);

                    }
                    catch (NullReferenceException)
                    {
                        //se for erro de propriedade nula continua sem mostrar mensagem
                        //throw;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public virtual void IniciarFocusControle(Control.ControlCollection ctrcol)
        {
            try
            {
                foreach (Control ctl in ctrcol)
                {
                    //correspondência de padrões (Pattern matching) - técnica em que você testa uma expressão para determinar se ela tem determinadas características, ja criando uma nova variavel
                    if (ctl is TextBoxEdit tbe)
                    {
                        if (tbe.PrtIniciaFocusControle == true)
                        {
                            tbe.Focus();
                            return;
                        }
                    }
                    else if (ctl is MaskedTextBoxEdit mtbe)
                    {
                        if (mtbe.PrtIniciaFocusControle == true)
                        {
                            mtbe.Focus();
                            return;
                        }
                    }
                    else if (ctl is ComboBoxEdit cbe)
                    {
                        if (cbe.PrtIniciaFocusControle == true)
                        {
                            cbe.Focus();
                            return;
                        }
                    }
                    else if (ctl is ListBoxEdit lbe)
                    {
                        if (lbe.PrtIniciaFocusControle == true)
                        {
                            lbe.Focus();
                            return;
                        }
                    }
                    else if (ctl is ButtonEdit btne)
                    {
                        if (btne.PrtIniciaFocusControle == true)
                        {
                            btne.Focus();
                            return;
                        }
                    }
                    else if (ctl is RadioButtonEdit rbe)
                    {
                        if (rbe.PrtIniciaFocusControle == true)
                        {
                            rbe.Focus();
                            return;
                        }
                    }
                    else if (ctl is CheckBoxEdit ckbe)
                    {
                        if (ckbe.PrtIniciaFocusControle == true)
                        {
                            ckbe.Focus();
                            return;
                        }
                    }
                    else if (ctl is DataGridViewEdit dgv)
                    {
                        if (dgv.PrtIniciaFocusControle == true)
                        {
                            dgv.Focus();
                            return;
                        }
                    }
                    else if (ctl is GroupBoxEdit group)
                    {
                        IniciarFocusControle(group.Controls);
                    }
                    else if (ctl is PanelEdit pnle)
                    {
                        IniciarFocusControle(pnle.Controls);
                    }
                    else if (ctl is Panel pnl)
                    {
                        IniciarFocusControle(pnl.Controls);
                    }
                    else if (ctl is TabControlEdit tce)
                    {
                        IniciarFocusControle(tce.Controls);
                    }
                    else if (ctl is TableLayoutPanel tlp)
                    {
                        IniciarFocusControle(tlp.Controls);
                    }
                }
            }
            catch (Exception ex)
            {

                Mensagem.MostraAviso(ex);
            }
        }
        public void LimpaControles(Control.ControlCollection ctrcol)
        {
            foreach (Control ctl in ctrcol)
            {
                if (ctl is TextBoxEdit tbe)
                {
                    if (tbe.PrtNaoLimparControle == false)
                    {
                        tbe.Text = string.IsNullOrEmpty(tbe.PrtValorPadrao) ? "" : tbe.PrtValorPadrao;
                        tbe.PrtMensagemErroProvider = ""; // tira o aviso do erroprovider do campo
                    }
                }
                else if (ctl is MaskedTextBoxEdit mtbe)
                {
                    if (mtbe.PrtNaoLimparControle == false)
                    {
                        mtbe.Text = string.IsNullOrEmpty(mtbe.PrtValorPadrao) ? "" : mtbe.PrtValorPadrao;
                        mtbe.PrtMensagemErroProvider = ""; // tira o aviso do erroprovider do campo
                    }
                }
                else if (ctl is LabelEdit lble)
                {
                    if (lble.PrtNaoLimparControle == false)
                    {
                        lble.Text = string.IsNullOrEmpty(lble.PrtValorPadrao) ? "" : lble.PrtValorPadrao;
                        //não implementado no label, comentei linha
                        //lble.AtualizaErroProvider(""); // tira o aviso do erroprovider do campo
                    }
                }
                else if (ctl is CheckBoxEdit ckbe)
                {
                    if (ckbe.PrtNaoLimparControle == false)
                    {
                        ckbe.Checked = false;
                    }
                }
                else if (ctl is ComboBoxEdit cboe)
                {
                    if (cboe.PrtNaoLimparControle == false)
                    {
                        cboe.Text = string.IsNullOrEmpty(cboe.PrtValorPadrao) ? "" : cboe.PrtValorPadrao;
                        cboe.SelectedIndex = -1;
                    }
                }
                else if (ctl is ListBoxEdit lste)
                    lste.SelectedIndex = -1;
                else if (ctl is DataGridViewEdit dgv)
                    dgv.DataSource = null;
                else if (ctl.HasChildren)
                    LimpaControles(ctl.Controls);
            }
        }
        public bool ValidaTela(Control.ControlCollection ctrcol)
        {
            bool _validaTela = true;
            try
            {
                foreach (Control ctl in ctrcol.Cast<Control>().OrderBy(c => c.TabIndex))
                {
                    if (ctl is TextBoxEdit txt)
                    {
                        if (txt.PrtAtivaValidacao == true)
                        {
                            if (txt.PrtMensagemErroProvider.Length > 0 ||
                              (string.IsNullOrEmpty(txt.Text) && txt.PrtCampoObrigatorio))
                            {
                                //se vazio mensagem de erro mostra a mensagem de campo obrigatorio
                                if (string.IsNullOrEmpty(txt.PrtMensagemErroProvider))
                                    txt.PrtMensagemErroProvider = txt.PrtMensagemCampoObrigatorio;

                                _validaTela = false;
                                txt.Focus();
                                break;
                            }
                            else if (txt.PrtAtivaPesquisa && string.IsNullOrEmpty(txt.PrtLabelDescricao.Text))
                            {
                                txt.PrtMensagemErroProvider = "Valor informado, não localizado!";
                                _validaTela = false;
                                txt.Focus();
                                break;


                            }
                        }
                    }
                    else if (ctl is MaskedTextBoxEdit mtb)
                    {
                        if (mtb.PrtAtivaValidacao == true)
                        {
                            if (mtb.PrtMensagemErroProvider.Length > 0 ||
                              (string.IsNullOrEmpty(mtb.Text) && mtb.PrtCampoObrigatorio))
                            {
                                if (string.IsNullOrEmpty(mtb.PrtMensagemErroProvider))
                                    mtb.PrtMensagemErroProvider = mtb.PrtMensagemCampoObrigatorio;

                                _validaTela = false;
                                mtb.Focus();
                                break;

                            }
                        }
                    }
                    else if (ctl is ComboBoxEdit cbo)
                    {
                        if (cbo.PrtAtivaValidacao == true)
                        {
                            if (cbo.PrtMensagemErroProvider.Length > 0 ||
                              (string.IsNullOrEmpty(cbo.Text) && cbo.PrtCampoObrigatorio))
                            {
                                if (string.IsNullOrEmpty(cbo.PrtMensagemErroProvider))
                                    cbo.PrtMensagemErroProvider = cbo.PrtMensagemCampoObrigatorio;

                                _validaTela = false;
                                cbo.Focus();
                                break;

                            }
                        }

                    }
                    else if (ctl.HasChildren)
                    {
                        _validaTela = ValidaTela(ctl.Controls);
                        if (_validaTela == false) break;
                    }
                }
                return _validaTela;

            }
            catch (Exception ex)
            {
                Mensagem.MostraErro(ex.Message);
                return false;
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlTopo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lblTituloForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void frmBase_Move(object sender, EventArgs e)
        {
            if (Parent == null) return;
            if ((this.Left < ((this.Width - 300) * -1))) this.Left = -300;
            if (this.Top < 0) this.Top = 25;
            if (Screen.GetBounds(Parent).Width - (this.Left + this.Width) < 0)
                this.Left = Screen.GetBounds(Parent).Width - this.Width;
            if (Screen.GetBounds(Parent).Height - (this.Top + this.Height) < 0)
                this.Top = Screen.GetBounds(Parent).Height - this.Height;
        }

        public virtual void SetFocusProximoControle()
        {
            SetFocusProximoControle(new KeyEventArgs(Keys.Enter), false);
            //SelectNextControl(pnlBase, true, true, true, true);
        }


        public void SetFocusProximoControle(KeyEventArgs e, bool shift)
        {
            //ctl Control - O Control no qual a pesquisa será iniciada.
            //forward - true para avançar na ordem de tabulação; false para voltar na ordem de tabulação.
            //tabStopOnly - true para ignorar os controles com a propriedade TabStop definida como false; caso contrário, false.
            //nested - true para incluir controles filho aninhados (filhos de controles filho); caso contrário, false.
            //wrap - true para continuar a pesquisa do primeiro controle na ordem de tabulação após o último controle ter sido atingido; caso contrário, false.
            this.SelectNextControl(this.ActiveControl, !shift, true, true, true);
        }

        private void frmBase_Shown(object sender, EventArgs e)
        {
            IniciarFocusControle(this.Controls);
        }
    }
}
