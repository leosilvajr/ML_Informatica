using ML_Informatica.Dal;
using ML_InformaticaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_InformaticaNegocios
{
  public class MunicipioNegocio
  {
    private MunicipioDal dal = new MunicipioDal();

    public List<MunicipioEntidade> PesquisaLista(MunicipioEntidade param, bool fullSearch = false, string tipoBusca = "", string filtroAdicional = "")
    {
      try
      {
        return dal.PegaDados(param, fullSearch, tipoBusca);
      }
      catch
      {
        throw;
      }
    }
    public MunicipioEntidade PesquisaById(int? codigo, bool fullSearch = false)
    {
      return dal.PegaDadosById(codigo, fullSearch);
    }

    public Dictionary<int, string> Faz_Municipio(MunicipioEntidade param, EnumsEntidade.TipoAcaoProcedure wTipo)
    {
      return dal.Faz_Municipio(param, wTipo);
    }

  }
}
