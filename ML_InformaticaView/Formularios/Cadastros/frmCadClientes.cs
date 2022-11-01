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
  public partial class frmCadClientes : frmBaseCadastro
  {
    ClientesEntidade cliente;
    ClientesNegocio negocio;
    MunicipioNegocio negocioMunicipio;

    public frmCadClientes()
    {
      InitializeComponent();
      cliente = new ClientesEntidade();
      negocio = new ClientesNegocio();
      negocioMunicipio = new MunicipioNegocio();
      lblTituloForm.Text = "Cadastro de Clientes";
    }
    //private void Func_PesquisaById(int? codigo_cliente)
    //{
    //  try
    //  {
    //    var _cliente = negocio.PesquisaById((int)codigo_cliente);
    //    cliente = _cliente != null ? _cliente : cliente;
    //    MontaTela();

    //  }
    //  catch (Exception ex)
    //  {
    //    Mensagem.MostraErro(ex.Message);
    //  }
    //}

    private void Func_PesquisaById_Municipio(int? codigo)
    {
      try
      {
        var municipio = negocioMunicipio.PesquisaById((int)codigo, true);
        cliente = cliente ?? new ClientesEntidade();
        cliente.CodigoMunicipio = municipio.CodigoMunicipio;
        cliente.NomeMunicipio = municipio.Nome;
        cliente.Uf = municipio.NomeUF;
        base.MontaTela(cliente, false);

      }
      catch (Exception ex)
      {
        Mensagem.MostraErro(ex.Message);
      }
    }

    private void RetornoConsultaCallbackFn(ClientesEntidade entidade)
    {
      try
      {
        cliente = entidade;
        MontaTela();
      }
      catch (Exception ex)
      {
        Mensagem.MostraErro(ex.Message);
      }
    }
    private void RetornoConsultaCallbackFn(MunicipioEntidade entidade)
    {
      try
      {
        txtCodigoMunicipio.Text = entidade.CodigoMunicipio.ToString();
        lblNomeMunicipio.Text = entidade.Nome;
        lblUf.Text = entidade.NomeUF;

      }
      catch (Exception ex)
      {

        Mensagem.MostraErro(ex.Message);
      }
    }

    public override void MontaTela()
    {
      try
      {
        //metodo generico que preenche automaticamente os campos em tela 
        base.MontaTela(cliente);


        //if (cliente != null)
        //{
        //  if (!string.IsNullOrEmpty(cliente.CodigoCliente.ToString()))
        //    txtCodigoCliente.Enabled = true;
        //  else
        //    txtCodigoCliente.Enabled = false;
        //}
        //else
        //  txtCodigoCliente.Enabled = false;

      }
      catch (Exception ex)
      {

        Mensagem.MostraErro(ex.Message);
      }
    }

    public override bool Func_AcaoCancelar()
    {
      return base.Func_AcaoCancelar();

    }

    public override bool Func_AcaoExcluir()
    {
      try
      {

        cliente.CodigoCliente = int.Parse(txtCodigoCliente.Text);
        var continuar = base.Func_AcaoExcluir();
        if (continuar)
        {
          var ret = negocio.Faz_Cliente(cliente, EnumsEntidade.TipoAcaoProcedure.EXCLUIR);
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

    public override bool Func_AcaoGravar()
    {
      try
      {
        //base.Func_AcaoGravar();
        cliente = cliente ?? new ClientesEntidade();
        cliente = null;
        cliente = new ClientesEntidade
        {
          CodigoCliente = txtCodigoCliente.Text.GetToIntExt(),
          Nome = txtNome.Text,
          Apelido = txtApelido.Text,
          Endereco = txtEndereco.Text,
          Numero = txtNumero.Text,
          Complemento = txtComplemento.Text,
          Bairro = txtBairro.Text,
          CodigoMunicipio = txtCodigoMunicipio.Text.GetToIntExt(),
          NomeMunicipio = lblNomeMunicipio.Text,
          Uf = lblUf.Text,
          Cep = mkbCep.GetTextSemMascara(),
          Email = txtEmail.Text,
          Telefone = mkbTelefone.GetTextSemMascara(),
          Celular = mkbCelular.GetTextSemMascara()
        };

        if (base.ValidaTela(this.Controls))
        {
          var ret = negocio.Faz_Cliente(cliente, EnumsEntidade.TipoAcaoProcedure.INCLUIR);
          if (ret.Count > 0)
          {
            Mensagem.MostraAviso(ret.First().Value);
            if (ret.First().Key > 0)
              txtCodigoCliente.Text = ret.First().Key.ToString();
            Status = Enums.AcaoTelaStatus.Navegando;
            return true;
          }
        }
        return false;
      }
      catch (Exception ex)
      {

        Mensagem.MostraErro(ex.Message);
        return false;
      }
    }
    public override bool Func_AcaoIncluir()
    {
      cliente = null;
      lblNomeMunicipio.Text = "";
      lblUf.Text = "";
      return base.Func_AcaoIncluir();
    }

    public override bool Func_AcaoProcurar()
    {
      base.Func_AcaoProcurar();
      frmConsultaClientes consultaClientes = new frmConsultaClientes();
      consultaClientes.SetRetornoConsultaCallback = new Util.DelegateRetornoConsulta<ClientesEntidade>(RetornoConsultaCallbackFn);
      Util.AbreForm(this, consultaClientes);
      return true;
    }

    private void txtCodigoCliente_Validating(object sender, CancelEventArgs e)
    {
      try
      {
        if (txtCodigoCliente.GetToIntEx() > 0 && string.IsNullOrEmpty(txtNome.Text))
        {

          Func_PesquisaById(int.Parse(txtCodigoCliente.Text));
          if (cliente == null || cliente.CodigoCliente.GetValueOrDefault() == 0)
          {
            e.Cancel = true;
          }
        }
      }

      catch (Exception ex)
      {

        Mensagem.MostraErro(ex.Message);
      }
    }

    private void txtCodigoCliente_TextChanged(object sender, EventArgs e)
    {
      if (this.ActiveControl == txtCodigoCliente)
      {
        txtCodigoCliente.PrtNaoLimparControle = true;

        this.LimpaControles(this.Controls);
        cliente = null;
        cliente = new ClientesEntidade();
        cliente.CodigoCliente = txtCodigoCliente.GetToIntEx();
        cliente.Nome = txtNome.Text;
        txtCodigoCliente.PrtNaoLimparControle = false;
      }
    }

    private void txtCodigoMunicipio_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F3)
      {
        frmConsultaMunicipio consultaMunicipio = new frmConsultaMunicipio();
        consultaMunicipio.SetRetornoConsultaCallback = new Util.DelegateRetornoConsulta<MunicipioEntidade>(RetornoConsultaCallbackFn);
        Util.AbreForm(this, consultaMunicipio);
      }
    }

    private void txtCodigoCliente_Enter(object sender, EventArgs e)
    {
      if (Status == Enums.AcaoTelaStatus.Incluindo)
      {
        this.SetFocusProximoControle();
      }
    }

    private void txtCodigoCliente_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F3)
      {
        frmConsultaClientes consultaClientes = new frmConsultaClientes();
        consultaClientes.SetRetornoConsultaCallback = new Util.DelegateRetornoConsulta<ClientesEntidade>(RetornoConsultaCallbackFn);
        //consultaFilial.CodigoEmpresaAtiva = filial.CodigoEmpresa;
        Util.AbreForm(this, consultaClientes);
      }
    }

    private void txtCodigoMunicipio_TextChanged(object sender, EventArgs e)
    {
      if (this.ActiveControl == txtCodigoMunicipio)
      {
        lblNomeMunicipio.Text = "";
        lblUf.Text = "";
      }


  }

    private void txtCodigoMunicipio_Validating(object sender, CancelEventArgs e)
    {
      try
      {
        if (txtCodigoMunicipio.GetToIntEx() > 0 && string.IsNullOrEmpty(lblNomeMunicipio.Text))
        {

          Func_PesquisaById_Municipio(int.Parse(txtCodigoMunicipio.Text));
          if (cliente == null || cliente.CodigoCliente.GetValueOrDefault() == 0)
          {
            e.Cancel = true;
          }
        }
      }

      catch (Exception ex)
      {

        Mensagem.MostraErro(ex.Message);
      }


    }
  }
  }
