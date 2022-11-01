using Controles;
using Funcionarios.Formularios;
using ML_InformaticaView.Funcoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ML_InformaticaView.Formularios.Base
{
  public partial class frmBaseCadastro : frmBase
  {
    private Enums.AcaoTelaStatus? _status;

    public Enums.AcaoTelaStatus? Status
    {
      get { return _status; }
      set
      {
        _status = value;
        switch (_status)
        {
          case Enums.AcaoTelaStatus.Incluindo:
            lblStatus.Text = "INCLUINDO";
            break;
          case Enums.AcaoTelaStatus.Alterando:
            lblStatus.Text = "ALTERANDO";
            break;
          case Enums.AcaoTelaStatus.Navegando:
            lblStatus.Text = "NAVEGANDO";
            break;
          case Enums.AcaoTelaStatus.Excluindo:
            lblStatus.Text = "EXCLUINDO";
            break;
          default:
            break;
        }
        Func_AtualizaBotoes();
      }
    }

    public frmBaseCadastro()
    {
      InitializeComponent();
      this.TopLevel = false; //necessario para inserir form dentro de um panel
      this.StartPosition = FormStartPosition.CenterScreen;
      this.MontaTela();
    }

    public override void MontaTela()
    {
      LimpaControles(this.Controls);
      base.MontaTela();
      //IniciarFocusControle(this.Controls);
      //Status = Enums.AcaoTelaStatus.Navegando;
    }
    public virtual bool Func_AcaoIncluir()
    {
      this.LimpaControles(this.Controls);
      Status = Enums.AcaoTelaStatus.Incluindo;
      return true;

    }

    /// <summary>
    /// Metodo Base mostra a pergunta e retorna True se deve continuar
    /// a implementação do código deve ser feita na classe concreta.
    /// </summary>
    /// <returns></returns>
    public virtual bool Func_AcaoExcluir()
    {
      if (Mensagem.MostraPergunta("Registro será excluído!", "Deseja continuar?") == DialogResult.Yes)
      {
        Status = Enums.AcaoTelaStatus.Excluindo;
        return true;
      }
      else
      {
        Status = Enums.AcaoTelaStatus.Navegando;
        return false;
      }

    }
    /// <summary>
    /// Metodo abre consulta e procura um registro, se retornar o registro então  
    /// devemos alterar propriedade Status para Enums.AcaoTelaStatus.Alterando, caso 
    /// contrário Enums.AcaoTelaStatus.Navegando
    /// </summary>
    /// <returns></returns>
    public virtual bool Func_AcaoProcurar()
    {
      Status = Enums.AcaoTelaStatus.Navegando;
      return true;

    }
    public virtual bool Func_AcaoGravar()
    {
      Status = Enums.AcaoTelaStatus.Navegando;
      return true;

    }
    public virtual bool Func_AcaoCancelar()
    {
      Status = Enums.AcaoTelaStatus.Navegando;
      this.LimpaControles(this.Controls);
      IniciarFocusControle(this.Controls);

      return true;

    }

    //public virtual bool Func_AcaoSair()
    //{
    //  this.Close();
    //  return true;

    //}

    private void Func_AtualizaBotoes()
    {
      switch (_status)
      {
        case Enums.AcaoTelaStatus.Incluindo:
          btnIncluir.Enabled = false;
          btnCancelar.Enabled = true;
          btnExcluir.Enabled = false;
          btnProcurar.Enabled = false;
          btnGravar.Enabled = true;
          break;
        case Enums.AcaoTelaStatus.Alterando:
          btnIncluir.Enabled = false;
          btnCancelar.Enabled = true;
          btnExcluir.Enabled = true;
          btnProcurar.Enabled = false;
          btnGravar.Enabled = true;
          break;
        case Enums.AcaoTelaStatus.Navegando:
        case null:

          btnIncluir.Enabled = true;
          btnCancelar.Enabled = true;
          btnExcluir.Enabled = true;
          btnProcurar.Enabled = true;
          btnGravar.Enabled = true;

          break;
        case Enums.AcaoTelaStatus.Excluindo:
          btnIncluir.Enabled = false;
          btnCancelar.Enabled = false;
          btnExcluir.Enabled = true;
          btnProcurar.Enabled = false;
          btnGravar.Enabled = false;
          break;
        default:
          break;
      }
    }

    /// <summary>
    /// faz pesquisa pelo código PK
    /// </summary>
    /// <param name="codigo"></param>
    public virtual void Func_PesquisaById(int? codigo)
    {

    }
    /// <summary>
    /// pesquisa pelo codigo do tipo String
    /// </summary>
    /// <param name="codigo"></param>
    public virtual void Func_PesquisaById(string codigo)
    {

    }

    private void btnIncluir_Click(object sender, EventArgs e)
    {
      Func_AcaoIncluir();
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
      Func_AcaoExcluir();
      Status = Enums.AcaoTelaStatus.Navegando;
    }

    private void btnProcurar_Click(object sender, EventArgs e)
    {
      Func_AcaoProcurar();
    }

    private void btnGravar_Click(object sender, EventArgs e)
    {
      var ret = Func_AcaoGravar();
      if (ret) btnIncluir.Focus();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      Func_AcaoCancelar();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btnSair_Click(object sender, EventArgs e)
    {
      Close();
    }

        private void frmBaseCadastro_KeyDown(object sender, KeyEventArgs e)
        {
      bool _shift = e.Shift;
      //ENTER  -move para o proximo controle
      //SHIFT + ENTER - move para controle anterior
      if (this.ActiveControl is DataGridViewEdit dgv)
        return;
      if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
      {
        //vou cair fora se os controles estiverem definidos para não fazer nada no enter
        if (this.ActiveControl is MaskedTextBoxEdit mtb)
        {
          if (mtb.PrtTabEnter == false) return;
        }
        else if (this.ActiveControl is TextBoxEdit txt)
        {
          if (txt.PrtTabEnter == false) return;
        }
        else if (this.ActiveControl is ComboBoxEdit cbo)
        {
          //faço isso para navegar na lista do combobox, em vez de mudar de controle
          if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            return;

        }
        if (e.KeyCode == Keys.Up)
          _shift = true;
        SetFocusProximoControle(e, _shift);
      }
      else if (e.KeyCode == Keys.Escape)
        this.Close();
    }
    }
}
