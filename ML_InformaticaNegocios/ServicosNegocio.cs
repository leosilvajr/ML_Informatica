using ML_Informatica.Dal;
using ML_InformaticaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_InformaticaNegocios
{
  public class ServicosNegocio
  {
    private ServicosDal dal = new ServicosDal();

    public List<ServicosEntidade> PesquisaLista(ServicosEntidade param, bool fullSearch = false, string tipoBusca = "", string filtroAdicional = "")
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

    public ServicosEntidade PesquisaById(int codigo_servico, bool fullSearch = false)
    {
      return dal.PegaDadosById(codigo_servico, fullSearch);
    }

    public Dictionary<int, string> Faz_Servico(ServicosEntidade param, EnumsEntidade.TipoAcaoProcedure wTipo)
    {
      try
      {
        return dal.Faz_Servico(param, wTipo);

      }
      catch (Exception)
      {
        throw;
      }
    }
  }
}
