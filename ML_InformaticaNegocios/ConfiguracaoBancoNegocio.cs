using ML_Informatica.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_InformaticaNegocios
{
    public class ConfiguracaoBancoNegocio
    {
        private ConfiguracaoBancoDal dal = new ConfiguracaoBancoDal();
        public string TestarConexaoBanco()
        {
            return dal.TestarConexaoBanco();// "OK";
        }
    }
}
