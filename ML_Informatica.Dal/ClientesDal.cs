using FirebirdSql.Data.FirebirdClient;
using ML_InformaticaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Informatica.Dal
{
  public class ClientesDal
  {
    private string SelectFields(bool fullSearch)
    {
      return "CODIGO_CLIENTE, NOME, APELIDO, ENDERECO, NUMERO, COMPLEMENTO, BAIRRO, CODIGO_MUNICIPIO, " +
        "NOME_MUNICIPIO, UF, CEP, TELEFONE, CELULAR, EMAIL";
    }
    private ClientesEntidade Func_TrataParametros(ClientesEntidade parametros)
    {
      ClientesEntidade parametrosTratados;
      parametros.CodigoMunicipio = parametros.CodigoMunicipio > 0 ? parametros.CodigoMunicipio : null;
      parametrosTratados = parametros;

      return parametrosTratados;
    }
    public ClientesEntidade PegaDadosById(int codigo_Cliente, bool fullSearch = false)
    {
      try
      {
        //var p = Func_TrataParametros(obj);
        ClientesEntidade p = new ClientesEntidade();
        p.CodigoCliente = codigo_Cliente;

        List<ClientesEntidade> lista = PegaDados(p.CodigoCliente, p.Nome,p.Apelido,p.Endereco,
          p.Numero, p.Complemento, p.Bairro, p.CodigoMunicipio, p.NomeMunicipio, p.Uf,
          p.Cep, p.Email, p.Telefone, p.Celular, fullSearch);

        var item = lista.Count > 0 ? lista.First() : null;
        return item;

      }
      catch (Exception)
      {

        throw;
      }
    }
    public List<ClientesEntidade> PegaDados(ClientesEntidade obj, bool fullSearch = false, string tipoBusca = "")
    {
      var p = Func_TrataParametros(obj);

      return PegaDados(p.CodigoCliente, p.Nome, p.Apelido, p.Endereco,
          p.Numero, p.Complemento, p.Bairro, p.CodigoMunicipio, p.NomeMunicipio, p.Uf,
          p.Cep, p.Email, p.Telefone, p.Celular, fullSearch, tipoBusca);
    }


    private List<ClientesEntidade> PegaDados(int? codigo_cliente, string nome, string apelido,
        string endereco, string numero, string complemento, string bairro, int? codigo_municipio, string nome_municipio,
        string uf, string cep, string email, string telefone, string celular,
        bool fullSearch = false, string tipoBusca = "")
    {
      List<ClientesEntidade> lista = new List<ClientesEntidade>();

      try
      {

        using (var conexao = FirebirdDal.GetInstancia.GetConexao())
        {
          string campos = SelectFields(fullSearch);
          string query = "select " + campos + " from VW_CLIENTES "; // where  and filcod = ? and pedcod = ?";
          if (codigo_cliente!= null)
            query += UtilDal.WhereOrAnd(query) + " CODIGO_CLIENTE = ? ";
          if (nome != null)
            query += UtilDal.WhereOrAnd(query) + " NOME = ? ";

          using (var cmd = FirebirdDal.GetInstancia.GetFbCommand_Text(query, conexao))
          {
            if (codigo_cliente != null)
              cmd.Parameters.Add(FirebirdDal.GetInstancia.Add_Parametro_SetEntrada("@CODIGO_CLIENTE", codigo_cliente.ToString(), FbDbType.Integer));
            if (nome != null)
              cmd.Parameters.Add(FirebirdDal.GetInstancia.Add_Parametro_SetEntrada("@NOME", nome.ToString(), FbDbType.VarChar));

            conexao.Open();
            using (var reader = FirebirdDal.GetInstancia.ExecutarConsulta(cmd))
            {
              ClientesEntidade retorno = new ClientesEntidade();
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
    public Dictionary<int, string> Faz_Clientes(ClientesEntidade _param, EnumsEntidade.TipoAcaoProcedure wTipo)
    {
      try
      {
        var param = Func_TrataParametros(_param);
        using (var conexao = FirebirdDal.GetInstancia.GetConexao())
        {
          using (var cmd = FirebirdDal.GetInstancia.GetFbCommand_Procedure("FAZ_CLIENTES", conexao))
          {
            conexao.Open();
            cmd.Parameters.Add(FirebirdDal.GetInstancia.Add_Parametro_SetEntrada("CODIGO_CLIENTE", param.CodigoCliente.ToString(), FbDbType.Integer));
            cmd.Parameters.Add(FirebirdDal.GetInstancia.Add_Parametro_SetEntrada("NOME", param.Nome, FbDbType.VarChar));
            cmd.Parameters.Add(FirebirdDal.GetInstancia.Add_Parametro_SetEntrada("APELIDO", param.Apelido, FbDbType.VarChar));
            cmd.Parameters.Add(FirebirdDal.GetInstancia.Add_Parametro_SetEntrada("ENDERECO", param.Endereco, FbDbType.VarChar));
            cmd.Parameters.Add(FirebirdDal.GetInstancia.Add_Parametro_SetEntrada("NUMERO", param.Numero, FbDbType.VarChar));
            cmd.Parameters.Add(FirebirdDal.GetInstancia.Add_Parametro_SetEntrada("COMPLEMENTO", param.Complemento, FbDbType.VarChar));
            cmd.Parameters.Add(FirebirdDal.GetInstancia.Add_Parametro_SetEntrada("BAIRRO", param.Bairro, FbDbType.VarChar));
            cmd.Parameters.Add(FirebirdDal.GetInstancia.Add_Parametro_SetEntrada("CODIGO_MUNICIPIO", param.CodigoMunicipio.ToString(), FbDbType.Integer));
            cmd.Parameters.Add(FirebirdDal.GetInstancia.Add_Parametro_SetEntrada("CEP", param.Cep, FbDbType.VarChar));
            cmd.Parameters.Add(FirebirdDal.GetInstancia.Add_Parametro_SetEntrada("TELEFONE", param.Telefone, FbDbType.VarChar));
            cmd.Parameters.Add(FirebirdDal.GetInstancia.Add_Parametro_SetEntrada("CELULAR", param.Celular, FbDbType.VarChar));
            cmd.Parameters.Add(FirebirdDal.GetInstancia.Add_Parametro_SetEntrada("EMAIL", param.Email, FbDbType.VarChar));

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
    private ClientesEntidade PopulateAll(FbDataReader reader)
    {
      ClientesEntidade retorno = new ClientesEntidade();

      retorno.CodigoCliente = (int)reader["CODIGO_CLIENTE"];
      retorno.Nome = reader["NOME"].ToString();
      retorno.Apelido = reader["APELIDO"].ToString();
      retorno.Endereco = reader["ENDERECO"].ToString();
      retorno.Numero = reader["NUMERO"].ToString();
      retorno.Complemento = reader["COMPLEMENTO"].ToString();
      retorno.Bairro = reader["BAIRRO"].ToString();
      retorno.CodigoMunicipio = string.IsNullOrEmpty(reader["CODIGO_MUNICIPIO"].ToString()) ? (int?)null : (int?)reader["CODIGO_MUNICIPIO"];
      retorno.NomeMunicipio = reader["NOME_MUNICIPIO"].ToString();
      retorno.Uf = reader["UF"].ToString();
      retorno.Cep = reader["CEP"].ToString();
      retorno.Telefone = reader["TELEFONE"].ToString();
      retorno.Celular = reader["CELULAR"].ToString();
      retorno.Email = reader["EMAIL"].ToString();


      return retorno;
    }


    /// <summary>
    /// retorna apenas alguns campos selecionados da tabela
    /// </summary>
    /// <param name="reader"></param>
    /// <returns></returns>
    private ClientesEntidade Populate(FbDataReader reader)
    {

      ClientesEntidade retorno = new ClientesEntidade();

      retorno.CodigoCliente = (int)reader["CODIGO_CLIENTE"];
      retorno.Nome = reader["NOME"].ToString();
      retorno.Apelido = reader["APELIDO"].ToString();
      retorno.Endereco = reader["ENDERECO"].ToString();
      retorno.Numero = reader["NUMERO"].ToString();
      retorno.Complemento = reader["COMPLEMENTO"].ToString();
      retorno.Bairro = reader["BAIRRO"].ToString();
      retorno.CodigoMunicipio = string.IsNullOrEmpty(reader["CODIGO_MUNICIPIO"].ToString()) ? (int?)null : (int?)reader["CODIGO_MUNICIPIO"];
      retorno.NomeMunicipio = reader["NOME_MUNICIPIO"].ToString();
      retorno.Uf = reader["UF"].ToString();
      retorno.Cep = reader["CEP"].ToString();
      retorno.Telefone = reader["TELEFONE"].ToString();
      retorno.Celular = reader["CELULAR"].ToString();
      retorno.Email = reader["EMAIL"].ToString();

      return retorno;
    }
  }
}
