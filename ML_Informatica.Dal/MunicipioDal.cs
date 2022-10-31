using FirebirdSql.Data.FirebirdClient;
using ML_InformaticaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Informatica.Dal
{
  public class MunicipioDal
  {
    private string SelectFields(bool fullSearch)
    {
      return "nome, codigo_municipio, nome_uf, codigo_uf ";
    }

    /// <summary>
    /// Função criada para tratar os parametros caso necessario antes de continuar
    /// </summary>
    /// <param name="parametros"></param>
    private MunicipioEntidade Func_TrataParametros(MunicipioEntidade parametros)
    {
      MunicipioEntidade parametrosTratados;
      parametrosTratados = parametros;

      //trata aqui os parametros se necessario;

      return parametrosTratados;
    }

    /// <summary>
    /// Função faz consulta e retorna apenas o primeiro registro encontrado
    /// </summary>
    /// <param name="obj">entidade com os parametros de tela a ser consultado</param>
    /// <param name="fullSearch">se true, retorna todos os campos da tabela</param>
    /// <returns></returns>
    public MunicipioEntidade PegaDadosById(int? codigo, bool fullSearch = false)
    {
      MunicipioEntidade p = new MunicipioEntidade();
      p.CodigoMunicipio = codigo;

      List<MunicipioEntidade> lista = PegaDados(p.Nome, p.CodigoMunicipio, p.NomeUF, p.CodigoUF, fullSearch);
      var item = lista.Count > 0 ? lista.First() : null;
      return item;

    }

    /// <summary>
    /// Função faz consulta e retorna uma lista de registros
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="fullSearch"></param>
    /// <param name="tipoBusca"></param>
    /// <returns></returns>
    public List<MunicipioEntidade> PegaDados(MunicipioEntidade obj, bool fullSearch = false, string tipoBusca = "")
    {
      var p = Func_TrataParametros(obj);

      return PegaDados(p.Nome, p.CodigoMunicipio, p.NomeUF, p.CodigoUF, fullSearch, tipoBusca);
    }

    private List<MunicipioEntidade> PegaDados(string nome, int? codigo_municipio, string nome_uf, int? codigo_uf, bool fullSearch = false, string tipoBusca = "")
    {
      List<MunicipioEntidade> lista = new List<MunicipioEntidade>();

      try
      {

        using (var conexao = FirebirdDal.GetInstancia.GetConexao())
        {
          string campos = SelectFields(fullSearch);
          string query = "select " + campos + " from VIEW_MUNICIPIO ";
          if (codigo_municipio != null)
            query += UtilDal.WhereOrAnd(query) + " codigo_municipio = ? ";
          if (nome != null)
            query += UtilDal.WhereOrAnd(query) + " nome " + tipoBusca + " ? ";

          using (var cmd = FirebirdDal.GetInstancia.GetFbCommand_Text(query, conexao))
          {
            if (codigo_municipio != null)
              cmd.Parameters.Add(FirebirdDal.GetInstancia.Add_Parametro_SetEntrada("@codigo_municipio", codigo_municipio.ToString(), FbDbType.Integer));
            if (nome != null)
              cmd.Parameters.Add(FirebirdDal.GetInstancia.Add_Parametro_SetEntrada("@nome", nome, FbDbType.VarChar));

            conexao.Open();
            using (var reader = FirebirdDal.GetInstancia.ExecutarConsulta(cmd))
            {
              MunicipioEntidade retorno = new MunicipioEntidade();
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
    public Dictionary<int, string> Faz_Municipio(MunicipioEntidade param, EnumsEntidade.TipoAcaoProcedure wTipo)
    {
      try
      {

        using (var conexao = FirebirdDal.GetInstancia.GetConexao())
        {
          using (var cmd = FirebirdDal.GetInstancia.GetFbCommand_Procedure("FAZ_MUNICIPIO", conexao))
          {
            conexao.Open();
            cmd.Parameters.Add(FirebirdDal.GetInstancia.Add_Parametro_SetEntrada("codigo_municipio", param.CodigoMunicipio.ToString(), FbDbType.Integer));
            cmd.Parameters.Add(FirebirdDal.GetInstancia.Add_Parametro_SetEntrada("nome", param.Nome, FbDbType.VarChar));
            cmd.Parameters.Add(FirebirdDal.GetInstancia.Add_Parametro_SetEntrada("codigo_uf", param.CodigoUF.ToString(), FbDbType.Integer));
            cmd.Parameters.Add(FirebirdDal.GetInstancia.Add_Parametro_SetEntrada("nome_uf", param.NomeUF, FbDbType.VarChar));
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

    private MunicipioEntidade PopulateAll(FbDataReader reader)
    {
      MunicipioEntidade retorno = new MunicipioEntidade();

      retorno.CodigoMunicipio = (int)reader["CODIGO_MUNICIPIO"];
      retorno.Nome = reader["NOME"].ToString();
      retorno.CodigoUF = (int)reader["CODIGO_UF"];
      retorno.NomeUF = reader["NOME_UF"].ToString();

      return retorno;
    }

    private MunicipioEntidade Populate(FbDataReader reader)
    {

      MunicipioEntidade retorno = new MunicipioEntidade();

      retorno.CodigoMunicipio = (int)reader["CODIGO_MUNICIPIO"];
      retorno.Nome = reader["NOME"].ToString();
      retorno.CodigoUF = (int)reader["CODIGO_UF"];
      retorno.NomeUF = reader["NOME_UF"].ToString();

      return retorno;
    }
  }
}
