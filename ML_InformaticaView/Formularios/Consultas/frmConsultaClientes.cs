using ML_InformaticaEntidades;
using ML_InformaticaNegocios;
using ML_InformaticaView.Formularios.Base;
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

namespace ML_InformaticaView.Formularios.Consultas
{
  public partial class frmConsultaClientes : frmBaseConsulta
  {
    //aqui declaramos uma variavel do delegate no form proprietario, que enviara o retorno para outro formulario
    public Util.DelegateRetornoConsulta<ClientesEntidade> SetRetornoConsultaCallback;
    internal ClientesNegocio clientesNegocio;
    private IList<ClientesEntidade> lista;

    public frmConsultaClientes()
    {
      InitializeComponent();
      clientesNegocio = new ClientesNegocio();
      base.MontaTela();

    }

    /// Metodo de retorno envia o resultado da pesquisa para nosso form Pre-Venda, para o assinante do nosso delegate
    public void RetornoConsulta(ClientesEntidade entidade)
    {
      SetRetornoConsultaCallback(entidade);
    }

    public override bool Func_PegaRegistroSelecionado()
    {
      try
      {
        ClientesEntidade ent = new ClientesEntidade();
        int? codigo = dgvGrid.CurrentRow.Cells["CODIGO"].Value.ToString().GetToIntExt();
        ent = lista.Where(m => m.CodigoMunicipio == codigo).FirstOrDefault();

        RetornoConsulta(ent); //aciona metodo responsavel por enviar retorno para requerente.
        return true;
      }
      catch (Exception ex)
      {

        Mensagem.MostraErro(ex.Message);
        return false;
      }

    }

    public override bool Func_FazPesquisa()
    {
      try
      {
        base.Func_FazPesquisa();

        dgvGrid.DataSource = null;
        dgvGrid.Refresh();
        ssrQtdReg.Text = "0";
        int valueComboPesquisa = int.Parse(cboPesquisa.GetText);  //cboPesquisa.GetValueItemComboBoxExt()
        ClientesEntidade param = new ClientesEntidade();

        string valorPesquisa;
        valorPesquisa = string.IsNullOrEmpty(txtPesquisa.Text) ? null : txtPesquisa.Text;


        if (valueComboPesquisa == 01) //Codigo 
          param.CodigoCliente = !string.IsNullOrEmpty(valorPesquisa) ? valorPesquisa.GetToIntExt() : null;
        else if (valueComboPesquisa == 02) // Nome
          param.Nome = valorPesquisa;

        string whereFiltro = null;


        lista = clientesNegocio.PesquisaLista(param, false, TipoBuscaDal, whereFiltro);

        var display = lista
          .Select(d => new
          {
            Codigo = d.CodigoCliente,
            Nome = d.Nome,
            Apelido = d.Apelido,
            Telefone = d.Telefone,
            Celular = d.Celular,
          }).ToList();

        dgvGrid.DataSource = display;
        ssrQtdReg.Text = display.Count().ToString();

        base.Func_FazPesquisa(); //executa o que é comum para todos

        return true;
      }
      catch (Exception ex)
      {
        Mensagem.MostraErro(ex.Message);
        return false;
      }
    }
  }
}
