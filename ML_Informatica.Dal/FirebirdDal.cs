using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Informatica.Dal
{
    public sealed class FirebirdDal
    {
        private static readonly FirebirdDal instanciaFirebird = null; // = new FirebirdDal();


        private FirebirdDal()
        {

        }

        public static FirebirdDal GetInstancia
        {
            get { return instanciaFirebird ?? new FirebirdDal(); }
        }

        public FbConnection GetConexao()
        {
            try
            {
                ConfiguracaoBancoDal config = new ConfiguracaoBancoDal();
                string stringConexao = config.GetStringConexaoFb();
                if (string.IsNullOrEmpty(stringConexao)) return null;
                return new FbConnection(stringConexao);
            }
            catch (FbException ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Cria uma instancia de FbCommand com a query passada
        /// </summary>
        /// <param name="query">instrução sql a ser executada</param>
        /// <param name="conn">conexão do banco de dados</param>
        /// <returns></returns>
        public FbCommand GetFbCommand_Text(string query, FbConnection conn)
        {
            return new FbCommand(query, conn);
        }
        /// <summary>
        /// Cria uma instancia de FbCommand, com a procedure passada" 
        /// </summary>
        /// <param name="nomeProcedure">Nome da Procedure</param>
        /// <param name="conn">conexão do banco</param>
        /// <returns></returns>
        public FbCommand GetFbCommand_Procedure(string nomeProcedure, FbConnection conn)
        {
            FbCommand fbCmd = new FbCommand(nomeProcedure, conn);
            fbCmd.CommandType = CommandType.StoredProcedure;
            return fbCmd;
        }

        /// <summary>
        /// Metodo cria um parametro de saída retornando para ser inserido em um FbCommand
        /// </summary>
        /// <param name="nomeParametro"></param>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public FbParameter Add_Parametro_SetSaida(string nomeParametro, FbDbType tipo)
        {
            FbParameter f = new FbParameter(nomeParametro, tipo);
            f.Direction = ParameterDirection.Output;
            //        fbCmd.Parameters.Add(f);
            return f;


        }

        /// <summary>
        /// Metodo cria um parametro de entrada retornando para ser inserido em um FbCommand
        /// </summary>
        /// <param name="nomeParametro"></param>
        /// <param name="valor"></param>
        /// <param name="fbTipo"></param>
        /// <returns></returns>
        public FbParameter Add_Parametro_SetEntrada(string nomeParametro, string valor = null, FbDbType fbTipo = FbDbType.VarChar)
        {
            FbParameter f = new FbParameter(PoeArroba(nomeParametro), fbTipo);
            f.Direction = ParameterDirection.Input;
            switch (fbTipo)
            {
                case FbDbType.Integer:
                    f.Value = string.IsNullOrEmpty(valor) ? (object)DBNull.Value : int.Parse(valor);
                    break;
                case FbDbType.SmallInt:
                    f.Value = string.IsNullOrEmpty(valor) ? (object)DBNull.Value : short.Parse(valor);
                    break;
                case FbDbType.BigInt:
                    f.Value = string.IsNullOrEmpty(valor) ? (object)DBNull.Value : long.Parse(valor);
                    break;
                case FbDbType.Decimal:
                    f.Value = string.IsNullOrEmpty(valor) ? (object)DBNull.Value : decimal.Parse(valor);
                    break;
                case FbDbType.TimeStamp:
                case FbDbType.Date:
                    //DateTime resultado;
                    //if (DateTime.TryParse(valor.Trim(), out resultado) == false)
                    //  valor = null;
                    f.Value = string.IsNullOrEmpty(valor) ? (object)DBNull.Value : DateTime.Parse(valor).Date;
                    break;
                case FbDbType.Char:
                    f.Value = string.IsNullOrEmpty(valor) ? (object)DBNull.Value : char.Parse(valor);
                    break;
                default:
                    f.Value = string.IsNullOrEmpty(valor) ? (object)DBNull.Value : valor;
                    break;

            }
            return f;
        }

        //se não começar com arroba vamos colocar para evitar erro
        private string PoeArroba(string nomeParametro)
        {
            string np = nomeParametro.Substring(0, 1) != "@" ? "@" + nomeParametro : nomeParametro;
            return np;
        }

        /// <summary>
        /// Metodo faz consulta no banco de dados e retorna um FbDataReader
        /// </summary>
        /// <param name="cmd">objeto FbCommand que será executado </param>
        /// <param name="posResult"> posição de captura retorno Result, caso não informe será passado zero</param>
        /// <param name="posMensagem">posição de captura retorno Mensagem, caso não informe será passado um</param>
        /// <returns></returns>
        public FbDataReader ExecutarConsulta(FbCommand cmd, int posResult = 0, int posMensagem = 1)
        {
            try
            {

                return cmd.ExecuteReader();
            }
            catch
            {

                throw;
            }
        }
    }
}
