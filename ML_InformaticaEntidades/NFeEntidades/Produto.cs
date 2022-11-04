using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_InformaticaEntidades.NFeEntidades
{
  public class Produto
  {
    public string Codigo { get; set; } //cProd
    public string cEAN { get; set; }
    public string Descricao { get; set; } //xProd
    public string NCM { get; set; }  //NCM
    public string CFOP { get; set; } //CFOP
    public string uCom { get; set; }  //PC
    public double qCom { get; set; }  
    public double vUnCom { get; set; }
  }
}
