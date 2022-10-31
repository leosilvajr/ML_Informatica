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
  public partial class frmConsultaMunicipio : frmBaseConsulta
  {
    //aqui declaramos uma variavel do delegate no form proprietario, que enviara o retorno para outro formulario
    public Util.DelegateRetornoConsulta<MunicipioEntidade> SetRetornoConsultaCallback;
    internal MunicipioNegocio municipioNegocio;
    private IList<MunicipioEntidade> lista;

    public frmConsultaMunicipio()
    {
      InitializeComponent();
      municipioNegocio = new MunicipioNegocio();

      //uso aqui o MontaTela para que seja capturado o nome da consulta para gravar no arquivo Json
      //obs: não usar no formulario base.
      base.MontaTela();

    }

    /// Metodo de retorno envia o resultado da pesquisa para nosso form Pre-Venda, para o assinante do nosso delegate
    public void RetornoConsulta(MunicipioEntidade entidade)
    {
      SetRetornoConsultaCallback(entidade);
    }

    public override bool Func_PegaRegistroSelecionado()
    {
      try
      {
        MunicipioEntidade ent = new MunicipioEntidade();
        int? codigo = dgvGrid.CurrentRow.Cells["Codigo_Municipio"].Value.ToString().GetToIntExt();
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
        dgvGrid.DataSource = null;
        dgvGrid.Refresh();
        ssrQtdReg.Text = "0";
        int valueComboPesquisa = int.Parse(cboPesquisa.GetText);  //cboPesquisa.GetValueItemComboBoxExt()
        MunicipioEntidade param = new MunicipioEntidade();

        string valorPesquisa;

        valorPesquisa = string.IsNullOrEmpty(txtPesquisa.Text) ? null : txtPesquisa.Text;

        if (valueComboPesquisa == 01) //Codigo do Municipio
          param.CodigoMunicipio = !string.IsNullOrEmpty(valorPesquisa) ? valorPesquisa.GetToIntExt() : null;
        else if (valueComboPesquisa == 02) // Nome Municipio
          param.Nome = valorPesquisa;

        string whereFiltro = null;
        

        lista = municipioNegocio.PesquisaLista(param, false, TipoBuscaDal, whereFiltro);

        var display = lista
          .Select(d => new
          {
            Codigo_Municipio = d.CodigoMunicipio,
            Nome = d.Nome,
            Codigo_UF = d.CodigoUF,
            Nome_UF = d.NomeUF,
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
