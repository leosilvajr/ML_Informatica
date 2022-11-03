using FirebirdSql.Data.FirebirdClient;
using ML_InformaticaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Informatica.Dal
{
  public class ServicosDal
  {

    private string SelectFields(bool fullSearch)
    {
      return "CODIGO_SERVICO, NOME_SERVICO";
    }
    private ServicosEntidade Func_TrataParametros(ServicosEntidade parametros)
    {
      ServicosEntidade parametrosTratados;
      parametros.CodigoServico = parametros.CodigoServico > 0 ? parametros.CodigoServico : null;
      parametrosTratados = parametros;

      return parametrosTratados;
    }
    public ServicosEntidade PegaDadosById(int? codigo_Servico, bool fullSearch = false)
    {
      try
      {
        //var p = Func_TrataParametros(obj);
        ServicosEntidade p = new ServicosEntidade();
        p.CodigoServico = codigo_Servico;

        List<ServicosEntidade> lista = PegaDados(p.CodigoServico, p.NomeServico, fullSearch);

        var item = lista.Count > 0 ? lista.First() : null;
        return item;

      }
      catch (Exception)
      {

        throw;
      }
    }
    public List<ServicosEntidade> PegaDados(ServicosEntidade obj, bool fullSearch = false, string tipoBusca = "")
    {
      var p = Func_TrataParametros(obj);

      return PegaDados(p.CodigoServico, p.NomeServico, fullSearch, tipoBusca);
    }


    private List<ServicosEntidade> PegaDados(int? codigo_servico, string nome_servico,
        bool fullSearch = false, string tipoBusca = "")
    {
      List<ServicosEntidade> lista = new List<ServicosEntidade>();

      try
      {

        using (var conexao = FirebirdDal.GetInstancia.GetConexao())
        {
          string campos = SelectFields(fullSearch);
          string query = "select " + campos + " from VW_SERVICOS "; // where  and filcod = ? and pedcod = ?";
          if (codigo_servico != null)
            query += UtilDal.WhereOrAnd(query) + " CODIGO_SERVICO = ? ";
          if (nome_servico != null)
            query += UtilDal.WhereOrAnd(query) + " NOME_SERVICO = ? ";

          using (var cmd = FirebirdDal.GetInstancia.GetFbCommand_Text(query, conexao))
          {
            if (codigo_servico != null)
              cmd.Parameters.Add(FirebirdDal.GetInstancia.Add_Parametro_SetEntrada("@CODIGO_SERVICO", codigo_servico.ToString(), FbDbType.Integer));
            if (nome_servico != null)
              cmd.Parameters.Add(FirebirdDal.GetInstancia.Add_Parametro_SetEntrada("@NOME_SERVICO", nome_servico.ToString(), FbDbType.VarChar));

            conexao.Open();
            using (var reader = FirebirdDal.GetInstancia.ExecutarConsulta(cmd))
            {
              ServicosEntidade retorno = new ServicosEntidade();
              if (reader.HasRows)
              {
                while (reader.Read())
                {
                  if (fullSearch)
                    retorno = PopulateAll(reader);
                  else
                    retorno = Populate(reader);
                  lista.Add(retorno);
                }

              }
              return lista;

            }

          }
        }

      }

      catch
      {

        throw;
      }
    }

    /// <summary>
    /// Faz Municipio - vamos incluir/alterar ou deletar o municipio
    /// </summary>
    /// <param name="param">passamos a entidade com os dados da tela </param>
    /// <param name="wTipo">definimos o tipo de ação (INCLUIR/ALTERAR/DELETAR)</param>
    /// <returns></returns>
    public Dictionary<int, string> Faz_Servico(ServicosEntidade _param, EnumsEntidade.TipoAcaoProcedure wTipo)
    {
      try
      {
        var param = Func_TrataParametros(_param);
        using (var conexao = FirebirdDal.GetInstancia.GetConexao())
        {
          using (var cmd = FirebirdDal.GetInstancia.GetFbCommand_Procedure("FAZ_SERVICOS", conexao))
          {
            conexao.Open();
            cmd.Parameters.Add(FirebirdDal.GetInstancia.Add_Parametro_SetEntrada("CODIGO_SERVICO", param.CodigoServico.ToString(), FbDbType.Integer));
            cmd.Parameters.Add(FirebirdDal.GetInstancia.Add_Parametro_SetEntrada("NOME_SERVICO", param.NomeServico, FbDbType.VarChar));


            cmd.Parameters.Add(FirebirdDal.GetInstancia.Add_Parametro_SetEntrada("wtip", ((char)wTipo).ToString(), FbDbType.Char));

            using (var reader = FirebirdDal.GetInstancia.ExecutarConsulta(cmd))
            {
              Dictionary<int, string> retorno = new Dictionary<int, string>();
              if (reader.HasRows)
              {
                reader.Read();
                retorno.Add((int)reader["result"], reader["wmsg"].ToString());
              }
              return retorno;

            }

          }
        }

      }

      catch
      {

        throw;
      }
    }

    /// <summary>
    /// retorna todos os campos da tabela
    /// </summary>
    /// <param name="reader"></param>
    /// <returns></returns>
    private ServicosEntidade PopulateAll(FbDataReader reader)
    {
      ServicosEntidade retorno = new ServicosEntidade();
      retorno.CodigoServico = (int)reader["CODIGO_SERVICO"];
      retorno.NomeServico = reader["NOME_SERVICO"].ToString();

      return retorno;
    }
    /// <summary>
    /// retorna apenas alguns campos selecionados da tabela
    /// </summary>
    /// <param name="reader"></param>
    /// <returns></returns>
    private ServicosEntidade Populate(FbDataReader reader)
    {

      ServicosEntidade retorno = new ServicosEntidade();
      retorno.CodigoServico = (int)reader["CODIGO_SERVICO"];
      retorno.NomeServico = reader["NOME_SERVICO"].ToString();

      return retorno;
    }
  }
}
