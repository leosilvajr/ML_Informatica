using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ML_InformaticaEntidades
{
  [XmlRoot(ElementName = "ide")]
  public class PedidoEntidade
  {

    [XmlElement(ElementName = "numero")]
    public int Numero { get; set; }


    [XmlElement(ElementName = "data")]
    public DateTime Data { get; set; }


    [XmlElement(ElementName = "cliente")]
    public string Cliente { get; set; }


    [XmlArray("itens")]
    public List<PedidoItens> Itens { get; set; }


    [XmlType("item")]
    public class PedidoItens
    {


      [XmlElement(ElementName = "id")]
      public int ProdutoID { get; set; }


      [XmlElement(ElementName = "produto")]
      public string Produto { get; set; }


      [XmlElement(ElementName = "quantidade")]
      public int Quantidade { get; set; }
    }
  }
}
