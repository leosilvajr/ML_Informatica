using Funcionarios.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ML_InformaticaView.Formularios.Ultilitarios
{
  public partial class frmLerXmlNfe : frmBase
  {
    public frmLerXmlNfe()
    {
      InitializeComponent();
      this.TopLevel = false; //necessario para inserir form dentro de um panel
      this.StartPosition = FormStartPosition.CenterScreen;
      lblTituloForm.Text = "Ler XML da NF-e";
    }

    private void LerXmlNfe()
    {
      var arquivo = @"C:\WorkspaceGit\ML_Informatica\NFe\nfe.xml";
      var item = "";
      var cProd = "";
      var xProd = "";
      var qCom = "";
      var vUnCom = "";
      var vProd = "";

      //Instanciando um Objeto XMLReader e apontando para o arquivo do diretorio 
      using (XmlReader meuXml = XmlReader.Create(arquivo))
      {

        var fimItens = false;

        //Lendo o XML
        while (meuXml.Read())
        {
          // ---- Cabeçalho
          if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "natOp")
            lblNaturezaOperacao.Text = meuXml.ReadElementString();

          if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "nNF")
            lblNfNum.Text = meuXml.ReadElementString();


          if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "dhEmi")
            lblNfData.Text = meuXml.ReadElementString();

          //----- Itens da Nfe
          if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "det")
          {
            //Lendo atributo da tag <det>
            item = meuXml.GetAttribute("nItem");
            cProd = "";
            xProd = "";
            qCom = "";
            vUnCom = "";
            vProd = "";
          }
          else if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "total")
          {
            fimItens = true;
          }

          if (!fimItens)
          {
            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "cProd")
            cProd = meuXml.ReadElementString();

            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xProd")
            xProd = meuXml.ReadElementString();

            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "qCom")
             qCom = meuXml.ReadElementString().Replace(".", ",");

            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "vUnCom")
              vUnCom = meuXml.ReadElementString().Replace(".", ",")+" R$";

            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "vProd")
            {
              vProd = meuXml.ReadElementString().Replace(".", ",") + " R$";
              listView.Items.Add(new ListViewItem(new[] {item,cProd,xProd,qCom,vUnCom.ToString
                (),vProd.ToString().Replace(".",",")}));
            }

          }
          //---Rodapé
          if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "vNF")
            lblValorTotal.Text = meuXml.ReadElementString().Replace(".", ",") + " R$";
        }
      }
    }

    private void btnAbrir_Click(object sender, EventArgs e)
    {
      LerXmlNfe();
    }
  }
}
