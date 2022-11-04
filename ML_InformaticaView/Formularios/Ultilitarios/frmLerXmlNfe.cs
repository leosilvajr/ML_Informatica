using Funcionarios.Formularios;
using ML_InformaticaEntidades.NFeEntidades;
using ML_InformaticaNegocios;
using ML_InformaticaView.Funcoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebPages;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ML_InformaticaView.Formularios.Ultilitarios
{
  public partial class frmLerXmlNfe : frmBase
  {
    static string arquivoFileNameXml = "";
    public frmLerXmlNfe()
    {
      InitializeComponent();
      this.TopLevel = false; //necessario para inserir form dentro de um panel
      this.StartPosition = FormStartPosition.CenterScreen;
      lblTituloForm.Text = "Ler XML da NF-e";
    }

    private void buttonEdit1_Click(object sender, EventArgs e)
    {
      LerXml();
    }
    public void LerXml()
    {
      try
      {
        if (openFileXml.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        {
          txtpathXml.Text = openFileXml.FileName;
          arquivoFileNameXml = openFileXml.FileName;

          NFeSerialization serializable = new NFeSerialization();
          var nfe = serializable.ObterObjetoXml<NFeProc>(txtpathXml.Text);

          if (nfe == null)
          {
            MessageBox.Show("Falha ao ler o arquivo xml. Verifique se o arquivo é de uma NF-e/NFC-e autorizada!", "Aviso - Leitura do Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          }
          else
          {
            popularForm(nfe);
            MessageBox.Show("Arquivo xml da Nota Fiscal lido com Sucesso!", "Aviso - Leitura do Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
        }
      }
      catch (Exception)
      {
        MessageBox.Show("Falha no processo de leitura do arquivo xml da Nota Fiscal.", "Aviso - Leitura do Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }
    private void popularForm(NFeProc nfe)
    {
      /* Populando tab Identificação */
      txtNaturezaOperacao.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.natOp;
      txtNumero.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.nNF;
      txtModelo.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.mod;
      txtSerie.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.serie.ToString();
      txtDataEmissao.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.dhEmi.ToShortDateString();

      /* Populando tab Emitente */
      txtRazaoSocial.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.xNome;
      txtNomeFantasia.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.xFant;
      txtCpfCnpjEmitente.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.CNPJ;
      txtInscricaoEstadual.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.IE;
      txtLogradouroEmitente.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.xLgr;
      txtNroEmitente.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.nro;
      txtMunicipioEmitente.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.xMun;
      txtUFEmitente.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.UF;

      /* Populando tab Destinatário */
      txtDestNomeFantasia.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.xNome;
      txtDestCpfCnpj.Text = string.IsNullOrEmpty(nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CNPJ) ? nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CPF : nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CNPJ;
      txtDestEmail.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.email;
      txtDestLogradouro.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco.xLgr;
      txtDestNumero.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco.nro;
      txtDestMunicipio.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco.xMun;
      txtDestUF.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco.UF;
      txtDestCEP.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco.CEP;
      txtDestBairro.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco.xBairro;

      /* Populando tab Itens */
      List<Produto> ListaItens = new List<Produto>();
      XmlDocument doc = new XmlDocument();
      doc.Load(openFileXml.FileName);
      var proditens = doc.GetElementsByTagName("prod");

      foreach (XmlElement nodo in proditens)
      {
        ListaItens.Add(
             new Produto()
             {
               cProd = nodo.GetElementsByTagName("cProd")[0].InnerText.Trim(),
               cEAN = nodo.GetElementsByTagName("cEAN")[0].InnerText.Trim(),
               xProd = nodo.GetElementsByTagName("xProd")[0].InnerText.Trim(),
               CFOP = nodo.GetElementsByTagName("CFOP")[0].InnerText.Trim(),
               NCM = nodo.GetElementsByTagName("NCM")[0].InnerText.Trim(),
               uCom = nodo.GetElementsByTagName("uCom")[0].InnerText.Trim(),
               qCom = nodo.GetElementsByTagName("qCom")[0].InnerText.Trim(),
               vUnCom = nodo.GetElementsByTagName("vUnCom")[0].InnerText.Trim().GetToDecimalNFeExt(),
  
             });
      }
      dgvDados.DataSource = ListaItens;

      //Removendo Colunas
      dgvDados.Columns.Remove("cEAN");
      //Largura das Coluna
      dgvDados.Columns["cProd"].Width = 70;
      dgvDados.Columns["xProd"].Width = 300;
      dgvDados.Columns["NCM"].Width = 70;
      dgvDados.Columns["CFOP"].Width = 40;
      dgvDados.Columns["uCom"].Width = 50;
      dgvDados.Columns["qCom"].Width = 70;
      dgvDados.Columns["vUnCom"].Width = 70;

      //Renomeando Colunas
      dgvDados.Columns["cProd"].HeaderText = "Código";
      dgvDados.Columns["xProd"].HeaderText = "Descrição";
      dgvDados.Columns["uCom"].HeaderText = "Un.Com.";
      dgvDados.Columns["qCom"].HeaderText = "Qtde.Com.";
      dgvDados.Columns["vUnCom"].HeaderText = "Valor Un.";

    }
  }
}
