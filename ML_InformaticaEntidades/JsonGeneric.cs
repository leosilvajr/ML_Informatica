using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace ML_InformaticaEntidades
{
    public class JsonGeneric<T>
    {
            
        private string nomeArquivo;
        private string diretorio;
        private string fullPathFile;

        /// <summary>
        /// construtor da classe
        /// </summary>
        /// <param name="NomeArquivo">informe o nome do arquivo a ser gravado ou recuperado</param>
        public JsonGeneric(string _nomeArquivo)
        {
            nomeArquivo = _nomeArquivo + ".json"; //typeof(T).Name + ".json";  => comentei pq utilizo a mesma entidade para varias tabelas e aí não daria certo
            diretorio = Directory.GetCurrentDirectory();
            fullPathFile = diretorio + @"\" + nomeArquivo;
        }
        /// <summary>
        /// Propriedade devolve path do arquivo com a configuração do banco de dados
        /// </summary>
        public string GetFullPathFile
        {
            get => fullPathFile;


        }
        /// <summary>
        /// Metodo cria ou altera o arquivo Json com a entidade passada
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool GravarAlterarArquivo(T obj)
        {
            try
            {
                var jsonString = JsonConvert.SerializeObject(obj);
                var jsonFormatado = JValue.Parse(jsonString).ToString(Formatting.Indented);
                //cria ou altera o arquivo existente com a variavel configuracao
                File.WriteAllText(fullPathFile, jsonFormatado);
                return true;
            }
            catch
            {

                throw;
            }

        }

        /// <summary>
        /// Metodo le o arquivo Json da Entidade
        /// </summary>
        /// <returns></returns>
        public T LeArquivoJson()
        {
            try
            {
                if (File.Exists(fullPathFile))
                {
                    string jsonString = File.ReadAllText(fullPathFile);
                    var obj = JsonConvert.DeserializeObject<T>(jsonString);
                    return obj;

                }
                else return default(T);
            }
            catch
            {

                throw;
            }
        }
    }
}
