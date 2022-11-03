using Controles;
using ML_InformaticaEntidades;
using ML_InformaticaNegocios;
using ML_InformaticaView.Formularios.Base;
using ML_InformaticaView.Formularios.Consultas;
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

namespace ML_InformaticaView.Formularios.Cadastros
{
  public partial class frmCadServico : frmBaseCadastro
  {
    ServicosEntidade servico;
    ServicosNegocio negocio;
    public frmCadServico()
    {
      InitializeComponent();
      lblTituloForm.Text = "Cadastro de Serviço";
      servico = new ServicosEntidade();
      negocio = new ServicosNegocio();
    }

    public override void Func_PesquisaById(int? codigo)
    {
      try
      {
        servico = negocio.PesquisaById((int)codigo, true);
        base.MontaTela(servico);
      }
      catch (Exception ex)
      {
        Mensagem.MostraErro(ex.Message);
      }
    }


    /// função recebe o retorno da consulta de produto, utilizando delegate
    private void RetornoConsultaCallbackFn(ServicosEntidade entidade)
    {
      try
      {
        servico = entidade; // guardo produto pesquisado para usar depois se precisar as informações.
        base.MontaTela(servico);
      }
      catch (Exception ex)
      {

        Mensagem.MostraErro(ex.Message);
      }

    }

    public override bool Func_AcaoIncluir()
    {
      servico = null;
      return base.Func_AcaoIncluir();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override bool Func_AcaoExcluir()
    {
      try
      {

        servico.CodigoServico = int.Parse(txtCodigoServico.Text);
        var continuar = base.Func_AcaoExcluir();
        if (continuar)
        {
          var ret = negocio.Faz_Servico(servico, EnumsEntidade.TipoAcaoProcedure.EXCLUIR);
          if (ret.Count > 0)
          {
            if (ret.First().Key > 0)
            {
              MontaTela();
              Mensagem.MostraAviso("Registro excluído com sucesso!");
            }
            else
              Mensagem.MostraAviso("Não foi possível excluir registro!");
          }
          return true;

        }
        return true;
      }
      catch (Exception ex)
      {
        Mensagem.MostraErro(ex.Message);
        return false;
      }
    }

    public override bool Func_AcaoProcurar()
    {
      base.Func_AcaoProcurar();
      frmConsultaServico consultaservico = new frmConsultaServico();
      consultaservico.SetRetornoConsultaCallback = new Util.DelegateRetornoConsulta<ServicosEntidade>(RetornoConsultaCallbackFn);
      Util.AbreForm(this, consultaservico);
      return true;
    }

    public override bool Func_AcaoGravar()
    {
      servico = servico ?? new ServicosEntidade();
      servico.CodigoServico = txtCodigoServico.GetToIntEx();
      servico.NomeServico = txtNomeServico.Text;

      if (base.ValidaTela(this.Controls))
      {

        var ret = negocio.Faz_Servico(servico, EnumsEntidade.TipoAcaoProcedure.INCLUIR);
        if (ret.Count > 0)
        {
          Mensagem.MostraAviso(ret.First().Value);
          if (ret.First().Key > 0)
            Status = Enums.AcaoTelaStatus.Navegando;
          return true;
        }
      }
      return false;
    }

    public override bool Func_AcaoCancelar()
    {
      return base.Func_AcaoCancelar();
    }

    private void txtCodservico_Validating(object sender, CancelEventArgs e)
    {
      try
      {
        if (txtCodigoServico.GetToIntEx() > 0 && Status != Enums.AcaoTelaStatus.Incluindo)
        {

          Func_PesquisaById(txtCodigoServico.GetToIntEx());
          if (servico == null)
            e.Cancel = true;
          // else
          //   this.SetFocusProximoControle();

        }
      }
      catch (Exception ex)
      {
        Mensagem.MostraErro(ex.Message);
      }
    }

    private void txtCodservico_TextChanged(object sender, EventArgs e)
    {
      //if (this.ActiveControl == txtCodservico)
      //{
      //  txtCodservico.PrtNaoLimparControle = true;
      //  this.LimpaControles(this.Controls);
      //  txtCodservico.PrtNaoLimparControle = false;
      //}
    }

    private void txtCodservico_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F3)
      {
        frmConsultaServico consultaservico = new frmConsultaServico();
        consultaservico.SetRetornoConsultaCallback = new Util.DelegateRetornoConsulta<ServicosEntidade>(RetornoConsultaCallbackFn);
        Util.AbreForm(this, consultaservico);
      }
    }
  }
}
