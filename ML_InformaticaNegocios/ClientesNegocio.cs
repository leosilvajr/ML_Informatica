using ML_Informatica.Dal;
using ML_InformaticaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_InformaticaNegocios
{
  public class ClientesNegocio
  {
    private ClientesDal dal = new ClientesDal();
    public List<ClientesEntidade> PesquisaLista(ClientesEntidade param, bool fullSearch = false, string tipoBusca = "", string filtroAdicional = "")
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

    public ClientesEntidade PesquisaById(int codigo_cliente, bool fullSearch = false)
    {
      return dal.PegaDadosById(codigo_cliente, fullSearch);
    }

    public Dictionary<int, string> Faz_Cliente(ClientesEntidade param, EnumsEntidade.TipoAcaoProcedure wTipo)
    {
      try
      {
        return dal.Faz_Clientes(param, wTipo);

      }
      catch (Exception)
      {
        throw;
      }
    }
  }
}
