using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles
{
  public class Enums
  {
    public enum TipoCampo
    {
      CEP,
      CNPJ,
      CPF,
      DATA,
      DECIMAL,
      FONE,
      CELULAR,
      INTEIRO,
      NCM,
      PIS,
      PLACA,
      TEXTO
    }

    public enum TipoTexto
    {

      NUMERICO,
      TEXTO_MAIUSCULO, //chacacter casing  = UPPER
      TEXTO_ESPECIAL,
      SENHA,
      TEXTO_NORMAL  //defini este tipo para campos que desejo manter o character casing  = Normal
    }

    public enum TipoBuscaConsulta
    {
      EXATA = 'E',
      INICIA = 'I',
      CONTEM = 'C'
    }

    public enum TipoEstiloBotao
    {
      PowerBlue,
      SteelBlue,
      MediumTurquoise,
      Nenhum
    }

    public enum ImagemAlignmento
    {
      TopLeft = 1,
      TopCenter = 2,
      TopRight = 4,
      MiddleLeft = 16,
      MiddleCenter = 32,
      MiddleRight = 64,
      BottomLeft = 256,
      BottomCenter = 512,
      BottomRight = 1024
    }

    public enum AcaoTelaStatus
    { 
      Incluindo = 'I',
      Alterando = 'A',
      Navegando = 'N',
      Excluindo = 'E'
    }


  }
}
