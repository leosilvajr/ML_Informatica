using ML_InformaticaEntidades.NFeEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ML_InformaticaNegocios
{
  public class NFeSerialization
  {
    public T ObterObjetoXml<T>(string arquivo) where T : class
    {            //processo de converter as propriedades e campos públicos de um objeto em um formato serial
      var serialize = new XmlSerializer(typeof(T));

      try
      {
        //Le o arquivo XML carregado atravez de um arquivo.
        var xmlArquivo = System.Xml.XmlReader.Create(arquivo);
        return (T)serialize.Deserialize(xmlArquivo);
      }

      catch (Exception)
      {
        return null;
      }
    }
  }
}
