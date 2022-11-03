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
  public partial class frmConsultaServico : frmBaseConsulta
  {
    //aqui declaramos uma variavel do delegate no form proprietario, que enviara o retorno para outro formulario
    public Util.DelegateRetornoConsulta<ServicosEntidade> SetRetornoConsultaCallback;
    internal ServicosNegocio ServicosNegocio;
    private IList<ServicosEntidade> lista;

    public frmConsultaServico()
    {
      InitializeComponent();
      ServicosNegocio = new ServicosNegocio();
      lblTituloForm.Text = "Consulta Serviços";
      //uso aqui o MontaTela para que seja capturado o nome da consulta para gravar no arquivo Json
      //obs: não usar no formulario base.
      base.MontaTela();

    }

    /// Metodo de retorno envia o resultado da pesquisa para nosso form Pre-Venda, para o assinante do nosso delegate
    public void RetornoConsulta(ServicosEntidade entidade)
    {
      SetRetornoConsultaCallback(entidade);
    }

    public override bool Func_PegaRegistroSelecionado()
    {
      try
      {
        ServicosEntidade ent = new ServicosEntidade();
        int? codigo = dgvGrid.CurrentRow.Cells["CODIGO"].Value.ToString().GetToIntExt();
        ent = lista.Where(m => m.CodigoServico == codigo).FirstOrDefault();

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
        dgvGrid.DataSource = null;
        dgvGrid.Refresh();
        ssrQtdReg.Text = "0";
        int valueComboPesquisa = int.Parse(cboPesquisa.GetText);  //cboPesquisa.GetValueItemComboBoxExt()
        ServicosEntidade param = new ServicosEntidade();

        string valorPesquisa;

        valorPesquisa = string.IsNullOrEmpty(txtPesquisa.Text) ? null : txtPesquisa.Text;

        if (valueComboPesquisa == 01) //Codigo do Municipio
          param.CodigoServico = !string.IsNullOrEmpty(valorPesquisa) ? valorPesquisa.GetToIntExt() : null;
        else if (valueComboPesquisa == 02) // Nome Municipio
          param.NomeServico = valorPesquisa;

        string whereFiltro = null;


        lista = ServicosNegocio.PesquisaLista(param, false, TipoBuscaDal, whereFiltro);

        var display = lista
          .Select(d => new
          {
            Codigo = d.CodigoServico,
            Nome = d.NomeServico,
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
