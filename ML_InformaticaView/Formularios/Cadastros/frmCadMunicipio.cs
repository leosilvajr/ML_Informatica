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
  public partial class frmCadMunicipio : frmBaseCadastro
  {
    MunicipioEntidade municipio;
    MunicipioNegocio negocio;
    public frmCadMunicipio()
    {
      InitializeComponent();
      municipio = new MunicipioEntidade();
      negocio = new MunicipioNegocio();
      MontaComboEstado();
    }
    private void MontaComboEstado()
    {
      cboEstado.DisplayMember = "Descricao";
      cboEstado.ValueMember = "Value";
      cboEstado.PreencheComboEstadosBrasil();
      cboEstado.SelectedIndex = -1;
    }

    public override void Func_PesquisaById(int? codigo)
    {
      try
      {
        municipio = negocio.PesquisaById((int)codigo, true);
        base.MontaTela(municipio);
      }
      catch (Exception ex)
      {
        Mensagem.MostraErro(ex.Message);
      }
    }



    /*    public override void MontaTela()
        {
          base.MontaTela(municipio);
          if (municipio != null)
          {
            //preencher campos de tela, ver se vai chamar monta tela passando a entidade
            txtCodMunicipio.Text = municipio.CodigoMunicipio.ToString();
            txtNomeMunicipio.Text = municipio.Nome;
            cboEstado.Text = municipio.NomeUF;

          }
        }
      */

    /// função recebe o retorno da consulta de produto, utilizando delegate
    private void RetornoConsultaCallbackFn(MunicipioEntidade entidade)
    {
      try
      {
        municipio = entidade; // guardo produto pesquisado para usar depois se precisar as informações.
        base.MontaTela(municipio);
      }
      catch (Exception ex)
      {

        Mensagem.MostraErro(ex.Message);
      }

    }

    public override bool Func_AcaoIncluir()
    {
      municipio = null;
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

        municipio.CodigoMunicipio = int.Parse(txtCodMunicipio.Text);
        var continuar = base.Func_AcaoExcluir();
        if (continuar)
        {
          var ret = negocio.Faz_Municipio(municipio, EnumsEntidade.TipoAcaoProcedure.EXCLUIR);
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
      frmConsultaMunicipio consultaMunicipio = new frmConsultaMunicipio();
      consultaMunicipio.SetRetornoConsultaCallback = new Util.DelegateRetornoConsulta<MunicipioEntidade>(RetornoConsultaCallbackFn);
      Util.AbreForm(this, consultaMunicipio);
      return true;
    }

    public override bool Func_AcaoGravar()
    {
      municipio = municipio ?? new MunicipioEntidade();
      municipio.CodigoMunicipio = txtCodMunicipio.GetToIntEx();
      municipio.Nome = txtNomeMunicipio.Text;
      municipio.CodigoUF = (int?)cboEstado.SelectedValue;
      municipio.NomeUF = cboEstado.Text;

      if (base.ValidaTela(this.Controls))
      {

        var ret = negocio.Faz_Municipio(municipio, EnumsEntidade.TipoAcaoProcedure.INCLUIR);
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

    public override bool Func_AcaoSair()
    {
      return base.Func_AcaoSair();
    }

    private void txtCodMunicipio_Validating(object sender, CancelEventArgs e)
    {
      try
      {
        if (txtCodMunicipio.GetToIntEx() > 0 && Status != Enums.AcaoTelaStatus.Incluindo)
        {

          Func_PesquisaById(txtCodMunicipio.GetToIntEx());
          if (municipio == null)
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

    private void txtCodMunicipio_TextChanged(object sender, EventArgs e)
    {
      if (this.ActiveControl == txtCodMunicipio)
      {
        txtCodMunicipio.PrtNaoLimparControle = true;
        this.LimpaControles(this.Controls);
        txtCodMunicipio.PrtNaoLimparControle = false;
      }
    }

  }
}
