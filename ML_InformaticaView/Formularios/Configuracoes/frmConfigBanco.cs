using Funcionarios.Formularios;
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
using System.Web.Helpers;
using System.Windows.Forms;

namespace ML_InformaticaView.Formularios.Configuracoes
{
    public partial class frmConfigBanco : frmBaseCadastro
    {
        ConfiguracaoBancoEntidade config = new ConfiguracaoBancoEntidade();
        ConfiguracaoBancoNegocio neg = new ConfiguracaoBancoNegocio();
        JsonGeneric<ConfiguracaoBancoEntidade> json;
        public frmConfigBanco()
        {
            InitializeComponent();
            lblTituloForm.Text = "Configuração do Banco de Dados Firebird";
            pnlBotoesTopo.Enabled = false;
            pnlStatus.Enabled = false;
            MontaTela();
        }
        public override void MontaTela()
        {
            json = json ?? new JsonGeneric<ConfiguracaoBancoEntidade>("ConfiguracaoBanco");
            config = null;
            config = json.LeArquivoJson(); //neg.LeArquivoConfiguracaoBanco();
            base.MontaTela(config);

        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            try
            {
            config = new ConfiguracaoBancoEntidade();   
            config.FbDiretorioBanco = txtFbDiretorioBanco.Text;
            config.FbPorta = txtFbPorta.Text;
            config.FbNomeBanco = txtFbNomeBanco.Text;
            config.FbSisUsuario = txtFbSisUsuario.Text;
            config.FbSisSenha = txtFbSisSenha.Text;
            config.FbDbaUsuario = txtFbDbaUsuario.Text;
            config.FbDbaSenha = txtFbDbaSenha.Text;

            var ret = json.GravarAlterarArquivo(config); //neg.GravarConfiguracaoBanco(config);
            if (ret == true)
                Mensagem.MostraAviso("Configuração gravada com sucesso");
            else
                Mensagem.MostraAviso("Falha ao gravar configuração");
        }
      catch (Exception ex)
      {

        Mensagem.MostraErro(ex.Message);
      }
}

        private void buttonEdit1_Click(object sender, EventArgs e)
        {
            var ret = neg.TestarConexaoBanco();
            if (ret.ToUpper() == "OK")
                Mensagem.MostraAviso("Teste com sucesso");
            else
                Mensagem.MostraAviso("Teste falhou");
        }
    }
}
