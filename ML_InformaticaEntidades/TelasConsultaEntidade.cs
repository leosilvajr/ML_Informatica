using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_InformaticaEntidades
{
  public class TelasConsultaEntidade
  {
    public int IdUsuario { get; set; }
    public string NomeUsuario { get; set; }
    public string IdTela { get; set; }
    public ParametrosTela ParametroTela { get; set; }


    public TelasConsultaEntidade(int idUsuario, string nomeUsuario, string idTela, ParametrosTela parametroTela)
    {
      IdUsuario = idUsuario;
      NomeUsuario = nomeUsuario;
      IdTela = idTela;
      ParametroTela = parametroTela ?? new ParametrosTela();
    }
  }

  public class ParametrosTela
  {
    public bool PesquisaCadaDigitacao { get; set; }
    public string ValorComboFiltro { get; set; }
    public string ValorComboPesquisa { get; set; }
    public string TipoDeBusca { get; set; }

    public IDictionary<string, string> LarguraColsGrid { get; set; }

    public ParametrosTela()
    {
      LarguraColsGrid = new Dictionary<string, string>();
    }
  }
}
