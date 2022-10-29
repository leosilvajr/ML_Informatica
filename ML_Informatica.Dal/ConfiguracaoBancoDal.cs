using FirebirdSql.Data.FirebirdClient;
using ML_InformaticaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Informatica.Dal
{
    public class ConfiguracaoBancoDal
    {
        JsonGeneric<ConfiguracaoBancoEntidade> json;

        public string GetStringConexaoFb()
        {
            json = json ?? new JsonGeneric<ConfiguracaoBancoEntidade>("ConfiguracaoBanco");
            string stringConexao = null;
            ConfiguracaoBancoEntidade ent = json.LeArquivoJson();
            if (ent != null)
            {
                if (!string.IsNullOrEmpty(ent.FbNomeBanco) &&
                    !string.IsNullOrEmpty(ent.FbSisUsuario) &&
                    !string.IsNullOrEmpty(ent.FbSisSenha) &&
                    !string.IsNullOrEmpty(ent.FbDiretorioBanco))
                {
                    //String Standard
                    stringConexao = "User=" + ent.FbSisUsuario + ";Password=" + ent.FbSisSenha;
                    stringConexao += ";Database=" + ent.FbDiretorioBanco + ":" + ent.FbNomeBanco;
                    stringConexao += ";Port=" + (string.IsNullOrEmpty(ent.FbPorta) ? "3050" : ent.FbPorta) + ";Dialect=3;Charset=WIN1252;Role=;Connection lifetime=0;";
                    stringConexao += "Connection timeout=7;Pooling=True;Packet Size=8192;Server Type=0";
                }
            }
            return stringConexao;
        }

        public string TestarConexaoBanco()
        {
            try
            {

                using (var conexao = FirebirdDal.GetInstancia.GetConexao())
                {
                    if (conexao == null) return "Faça configuração do banco de dados !";
                    conexao.Open();
                    if (conexao.State == System.Data.ConnectionState.Open)
                    {
                        conexao.Close();
                        return "OK";
                    }
                    else
                    {
                        return "Falha ao tentar abrir o banco de dados (State: " + conexao.State + ")";
                    }
                }
            }
            catch (FbException fbe)
            {
                if (fbe.ErrorCode == 335544472)
                    return "Seu nome de usuário e senha não foram definidos. Peça ao administrador para configurar o banco.";
                else
                    return fbe.Message;
            }
            catch
            {

                throw; //return false;
            }

        }

    }
}
