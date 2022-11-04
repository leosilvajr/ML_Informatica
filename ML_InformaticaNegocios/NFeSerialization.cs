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
    public T GetObjectFromFile<T>(string arquivo) where T : class
    {
      var serialize = new XmlSerializer(typeof(T));

      try
      {
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
