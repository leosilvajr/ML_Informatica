using Controles;
using Funcionarios;
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

namespace ML_InformaticaView.Formularios.Principal
{
  public partial class frmLogin : frmBase
  {
    public Util.DelegateRetornoConsulta<long?> SetRetornoLoginCallback;
    public frmLogin()
    {
      InitializeComponent();
      lblTituloForm.Text = "";
      btnSair.Visible = false;
      btnMinimizar.Visible = false;
    }
    private void RetornoLogin(long? result)
    {
      try
      {

        SetRetornoLoginCallback(result);
      }
      catch (Exception ex)
      {

        Mensagem.MostraErro(ex.Message);
      }

    }

    private void buttonEdit1_Click(object sender, EventArgs e)
    {
      if ((txtUsuario.Text.Equals("admin", StringComparison.InvariantCultureIgnoreCase)) && txtSenha.Text.Equals("admin", StringComparison.InvariantCultureIgnoreCase))
      {
        Program.codigoEmpresaAtiva = 1;
        RetornoLogin(1);
        Close();
      }
      else
      {
        MessageBox.Show("Senha incorreta.", "Confirmação!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      RetornoLogin(-1);
      Application.Exit();
    }

    private void frmLogin_KeyDown(object sender, KeyEventArgs e)
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
