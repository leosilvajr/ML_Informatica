using Controles;
using Funcionarios.Formularios;
using ML_InformaticaEntidades;
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
  public partial class frmBaseConsulta : frmBase
  {
    //provisorio informação deve vir do ususario logado
    int idUsuario = 1;
    string nomeUsuario = Util.GetNomeComputador();

    int linhaSelecionada;
    bool manterFoco;
    bool larguraColunaAlterada = false;

    private JsonGeneric<List<TelasConsultaEntidade>> json;
    private List<TelasConsultaEntidade> telaConsulta;
    private ParametrosTela paramTela;

    /// <summary>
    /// Propriedade retorna comando para ser usado no banco de dados na consulta 
    /// CONTAINING - Contenha
    /// STARTING WITH - Inicia
    /// vazio Exata
    /// </summary>
    /// <returns></returns>
    public string TipoBuscaDal
    {
      get
      {
        if (btnTipoBusca.Text == "Exata")
        {
          tipoBusca = "";
        }
        else if (btnTipoBusca.Text == "Inicia")
        {
          tipoBusca = "STARTING WITH";
        }
        else
        {
          tipoBusca = "CONTAINING";
        }


        return tipoBusca;
      }
    }



    private string tipoBusca;

    public frmBaseConsulta()
    {
      InitializeComponent();
      ssrQtdReg.Text = "0";
      this.TopLevel = true;
      //MontaTela(); //deve ser chamado da tela concreta para que nome parametro de tela seja gravado corretamente
    }
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
    /// <summary>
    /// Monta tela é chamado das consultas que herdam essa classe base, com isso o this.Name pega o nome certo.
    /// </summary>
    public override void MontaTela()
    {
      json = json ?? new JsonGeneric<List<TelasConsultaEntidade>>("ConfigTelaConsulta");
      base.MontaTela();
      Application.DoEvents();
      LimpaControles(this.Controls);
      Func_MontaComboCampoPesquisa();
      Func_MontaComboFiltro();
      telaConsulta = json.LeArquivoJson();
      telaConsulta = telaConsulta ?? new List<TelasConsultaEntidade>();
      var ret = telaConsulta.Find(u => u.IdUsuario == idUsuario && u.IdTela == this.Name);
      if (ret != null)
      {
        paramTela = paramTela ?? new ParametrosTela();
        paramTela = ret.ParametroTela;
        string[] tipoBusca = { "Inicia", "Contenha", "Exata" };
        chkPesquisaDigito.Checked = paramTela.PesquisaCadaDigitacao;
        cboFiltro.SelectedValue = int.Parse(paramTela.ValorComboFiltro);
        cboPesquisa.SelectedValue = int.Parse(paramTela.ValorComboPesquisa);
        btnTipoBusca.Text = tipoBusca.Contains(paramTela.TipoDeBusca) ? paramTela.TipoDeBusca : "Inicia";
        Func_SetLarguraColunasGrid();
      }
      else
      {
        telaConsulta = telaConsulta ?? new List<TelasConsultaEntidade>();
        cboPesquisa.SelectedValue = 1;
      }

    }

    /// <summary>
    /// função vai retornar o registro selecionado no grid
    /// </summary>
    public virtual bool Func_PegaRegistroSelecionado()
    {
      return true;
    }

    /// <summary>
    /// Metodo vai define campo que será usado para fitlrar os registros (ex: Codigo, Nome..etc) 
    /// </summary>
    public virtual void Func_MontaComboCampoPesquisa()
    {
      IList<ItensComboBoxEntidade> listaCampoPesquisa = new List<ItensComboBoxEntidade>
              {
                new ItensComboBoxEntidade {Value = 01, Descricao = "Código"},
                new ItensComboBoxEntidade {Value = 02, Descricao = "Nome"},
              };
      cboPesquisa.DisplayMember = "Descricao";
      cboPesquisa.ValueMember = "Value";
      cboPesquisa.DataSource = listaCampoPesquisa;

    }

    /// <summary>
    /// Metodo define o campo que será usado para filtrar os registros (ex: Somente Ativos/Inativos)
    /// </summary>
    public virtual void Func_MontaComboFiltro()
    {
      IList<ItensComboBoxEntidade> listaCampoFiltro = new List<ItensComboBoxEntidade>
              {
                new ItensComboBoxEntidade {Value = 01, Descricao = "Todos"},
              };
      cboFiltro.DisplayMember = "Descricao";
      cboFiltro.ValueMember = "Value";
      cboFiltro.DataSource = listaCampoFiltro;

    }

    /// <summary>
    /// metodo faz a consulta e atualiza o grid
    /// obs: deixei aqui na base metodos comuns para todos, que será executado no final da rotina da tela concreta
    /// </summary>
    public virtual bool Func_FazPesquisa()
    {
      //OBS: PRIMEIRO - faz a pesquisa na tela concreta e no final chama chama esse metodo para personalizar grid

      dgvGrid.AutosizeModePersonalizadoExt();
      dgvGrid.RemoverSelecaoLinhaExt();
      //dar apelido para colunas do grid
      //Func_RenomearColunasGrid();
      dgvGrid.FormatarColunasGrid();
      Func_SetLarguraColunasGrid();

      return true;
    }

    /// <summary>
    /// Grava parametro de tela 
    /// </summary>
    public virtual void Func_GravarParametroTela()
    {
      try
      {
        //encontra o item na lista e remove se existir, para gravaro novo
        var listaArquivo = json.LeArquivoJson();
        if (listaArquivo != null)
        {
          //aqui IdTela ainda será ajustado para gravar o codigo da tela
          listaArquivo.RemoveAll(l => l.IdUsuario == idUsuario && l.IdTela == this.Name);
          telaConsulta = listaArquivo;

        }
        paramTela = null;
        paramTela = paramTela ?? new ParametrosTela();
        paramTela.PesquisaCadaDigitacao = chkPesquisaDigito.Checked;
        paramTela.TipoDeBusca = btnTipoBusca.Text;
        paramTela.ValorComboPesquisa = cboPesquisa.GetText;
        paramTela.ValorComboFiltro = cboFiltro.GetText;
        paramTela.LarguraColsGrid = Func_GetLarguraColunasGrid();

        TelasConsultaEntidade tela = new TelasConsultaEntidade(idUsuario, nomeUsuario, this.Name, paramTela);
        telaConsulta.Add(tela);

        json.GravarAlterarArquivo(telaConsulta);
      }
      catch (Exception ex)
      {

        Mensagem.MostraErro(ex.Message);
      }

    }


    private void dgvGrid_DoubleClick(object sender, EventArgs e)
    {
      Func_PegaRegistroSelecionado();
      this.Close();

    }

    private void btnTipoBusca_Click(object sender, EventArgs e)
    {
      if (btnTipoBusca.Text == "Exata")
      {
        btnTipoBusca.Text = "Inicia";
      }
      else if (btnTipoBusca.Text == "Inicia")
      {
        btnTipoBusca.Text = "Contenha";
      }
      else
      {
        btnTipoBusca.Text = "Exata";
      }

    }

    private void cboPesquisa_SelectedValueChanged(object sender, EventArgs e)
    {
      try
      {
        txtPesquisa.Clear();
        txtPesquisa.Focus();
        dgvGrid.DataSource = null;
        dgvGrid.Refresh();

        Func_Define_Tipo_Campo_Pesquisa();
      }
      catch (Exception ex)
      {

        Mensagem.MostraErro(ex.Message);
      }

    }

    public virtual void Func_Define_Tipo_Campo_Pesquisa()
    {

      //aqui temos uma padrão que pode mudar de acordo com cada tela de consulta, se necessário fazer override
      int? valueCombo = cboPesquisa.GetText != null ? int.Parse(cboPesquisa.GetText) : (int?)null;
      if (valueCombo == 01)
        txtPesquisa.PrtTipoCampo = Enums.TipoCampo.INTEIRO;
      else
      {
        txtPesquisa.PrtTipoCampo = Enums.TipoCampo.TEXTO;
        txtPesquisa.PrtAtivarUpperCase = true;
      }


    }


    /// <summary>
    /// Metodo pega a larguda das colunas do grid em grava em um arquivo Json
    /// </summary>
    public Dictionary<string, string> Func_GetLarguraColunasGrid()
    {
      Dictionary<string, string> cols = new Dictionary<string, string>();
      try
      {
        foreach (DataGridViewColumn column in dgvGrid.Columns)
        {
          cols.Add("Col" + column.Index, column.Width.ToString());

        }
        return cols;
      }
      catch (Exception ex)
      {
        Mensagem.MostraErro(ex.Message);
        return cols;
      }
    }


    /// <summary>
    /// Metodo le arquivo Json com a largura das colunas do grid e atualiza o grid. 
    /// </summary>
    public void Func_SetLarguraColunasGrid()
    {
      try
      {
        if (paramTela == null) return;
        //so entra se tiver registros para evitar erro ao tentar alterar coluna, quando não existe
        if (dgvGrid.Rows.Count > 0)
        {
          Dictionary<string, string> cols = (Dictionary<string, string>)paramTela.LarguraColsGrid;

          if (cols.Count > 0)
          {
            int i = 0;
            foreach (var item in cols)
            {
              dgvGrid.Columns[i].Width = int.Parse(item.Value);
              i++;
            }
          }
        }
      }
      catch (Exception ex)
      {

        Mensagem.MostraErro(ex.Message);
      }

    }

    ///// <summary>
    ///// Metodo renomeia as coluans do grid, trocando o Underline por espaço
    ///// </summary>
    //public void Func_RenomearColunasGrid()
    //{
    //  foreach (DataGridViewColumn col in this.dgvGrid.Columns)
    //  {
    //    col.HeaderText = col.HeaderText.Replace("_", " ");
    //  }

    //}

    private void frmBaseConsulta_FormClosing(object sender, FormClosingEventArgs e)
    {
      Func_GravarParametroTela();
    }

    private void frmBaseConsulta_Shown(object sender, EventArgs e)
    {
      IniciarFocusControle(this.Controls);

    }


    private void dgvGrid_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        e.SuppressKeyPress = true;
        if (dgvGrid.SelectedRows.Count > 0)
        {
          Func_PegaRegistroSelecionado();
          this.Close();
        }
      }
      if (e.KeyCode == Keys.F3)
      {
        e.SuppressKeyPress = true;
        txtPesquisa.Focus();

      }

    }

    private void txtPesquisa_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
      if (manterFoco)
      {
        e.Cancel = true;
        txtPesquisa.Select(txtPesquisa.Text.Length, 0);
      }

    }


    //private void pnlSuperior_MouseMove(object sender, MouseEventArgs e)
    //{
    //  //linha necessária para identicar quando campo pesquisa pode perder o foco
    //  manterFoco = false;
    //}

    private void txtPesquisa_TextChanged(object sender, EventArgs e)
    {
      if (chkPesquisaDigito.Checked == false)
        dgvGrid.DataSource = null;
      else
      {
        Func_FazPesquisa();
      }

    }

    private void dgvGrid_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
    {
      if (this.ActiveControl == dgvGrid)
        larguraColunaAlterada = true;
    }

    private void dgvGrid_Leave(object sender, EventArgs e)
    {
      if (larguraColunaAlterada)
        Func_GravarParametroTela();
    }

    private void txtPesquisa_KeyDown_1(object sender, KeyEventArgs e)
    {
      try
      {
        manterFoco = true;

        if (e.KeyCode == Keys.Enter)
        {
          if (dgvGrid.Rows.Count == 0)
          {
            manterFoco = false;
            var ret = Func_FazPesquisa();
            e.SuppressKeyPress = true;
          }
          else if (dgvGrid.Rows.Count > 0)
          {
            Func_PegaRegistroSelecionado();
            this.Close();
          }

        }
        else if (e.KeyCode == Keys.Escape)
        {
          Func_GravarParametroTela();
          this.Close();
        }
        else if (e.KeyCode == Keys.Down)
        {
          if (dgvGrid.Rows.Count > 0)
          {
            dgvGrid.Focus();
            dgvGrid.ClearSelection();
            //seleciono a linha que está com o ponteiro, fiz isso caso volte o foco saia do grid ao voltar ele continua na linha selecionada
            dgvGrid.CurrentRow.DataGridView.Select();

            linhaSelecionada = dgvGrid.CurrentRow.Index + 1;
            if (linhaSelecionada >= 0 && linhaSelecionada <= dgvGrid.Rows.Count - 1)
              dgvGrid.CurrentCell = dgvGrid.Rows[linhaSelecionada].Cells[0];
            else
              dgvGrid.Rows[dgvGrid.Rows.Count - 1].Selected = true;
          }
          e.SuppressKeyPress = true;

        }
        else if (e.KeyCode == Keys.Up)
        {
          if (dgvGrid.Rows.Count > 0)
          {
            dgvGrid.Focus();
            dgvGrid.ClearSelection();
            dgvGrid.CurrentRow.DataGridView.Select();
            linhaSelecionada = dgvGrid.CurrentRow.Index - 1;

            if (linhaSelecionada >= 0)
              dgvGrid.CurrentCell = dgvGrid.Rows[linhaSelecionada].Cells[0];
            else
              dgvGrid.Rows[0].Selected = true;

          }
          e.SuppressKeyPress = true;

        }
      }


      catch (Exception ex)
      {

        Mensagem.MostraErro(ex.Message);
      }
    }
  }
}
