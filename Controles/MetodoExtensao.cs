using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;


namespace Controles
{
  public static class MetodoExtensao
  {
    /// <summary>
    /// Método de extensão:  Defini cor de fundo padrão de acordo com o tipo de controle.
    /// </summary>
    /// <param name="obj"></param>
    public static void BackColorExt(this Control obj)
    {
      if (obj is CheckBoxEdit checkbox)
        checkbox.BackColor = Color.Transparent; //SystemColors.Control;
      else if (obj is ButtonEdit button)
        button.BackColor = Color.White;
      else if (obj is LabelEdit label)
        label.BackColor = Color.Transparent;
      else if (obj is GroupBoxEdit group)
        group.BackColor = Color.Transparent;
      else
        obj.BackColor = Color.White; 
    }

    /// <summary>
    /// Metodo Extensão: Defini cor de fundo e cor da Fonte, chamar quando controle receber o focus.
    /// </summary>
    /// <param name="obj"></param>
    public static void BackColorOnFocusExt(this Control obj)
    {
      obj.BackColor = Tipos.Constantes.BackColorControle;
      obj.ForeColorExt();
    }

    public static void BackgroundColorExt(this Control obj)
    {
      if (obj is DataGridView dgv)
      {
        dgv.BackgroundColor = SystemColors.Control; //Color.FromArgb(0, 60, 94);
        dgv.RowsDefaultCellStyle.BackColor = Color.LightCyan; //Color.FromArgb(175, 238, 238);
        dgv.DefaultCellStyle.ForeColor = Color.Black;
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.MintCream; //Color.FromArgb(240, 255, 255);
        dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
        dgv.RowsDefaultCellStyle.SelectionBackColor = Tipos.Constantes.BackColorControle; //Color.PowderBlue;
        dgv.DefaultCellStyle.SelectionBackColor = Tipos.Constantes.BackColorControle;
        dgv.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
      }
    }

    /// <summary>
    /// Metodo defini cor de texto com base na cor de fundo (BackColor)
    /// </summary>
    /// <param name="obj"></param>
/*    public static void ForeColorExt(this Control obj)
    {
      if (obj.BackColor == Color.SkyBlue)
        obj.ForeColor = Color.Black;
      else
        obj.ForeColor = Color.FromArgb(255,250,250); 
    }
*/
    public static void ForeColorExt(this Control obj)
    {
      Color corFundo = obj.BackColor;

      // Calculate the perceptive luminance (aka luma) - human eye favors green color... 
      double luma = ((0.299 * corFundo.R) + (0.587 * corFundo.G) + (0.114 * corFundo.B)) / 255;
      // Return black for bright colors, white for dark colors
      obj.ForeColor = luma > 0.5 ? Color.Black : Color.White;
    }

    /// <summary>
    /// Define nome da Fonte e tamanho da fonte padrão para o controle.
    /// </summary>
    /// <param name="obj"></param>
    public static void FontExtPadrao(this Control obj)
    {
      obj.Font = new Font("Segoe UI", 10, FontStyle.Regular, GraphicsUnit.Point);
    }

    /// <summary>
    /// Metodo de Extensão converte valor da propriedade Text para inteiro
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static int? GetToIntEx(this Control obj)
    {
      try
      {
        if (ControleComPropriedadeText(obj))
        {
          int.TryParse(obj.Text, out int valorConvertido);
          return valorConvertido;
        }
        else
          return 0;
      }
      catch
      {

        throw;
      }
    }

    /// <summary>
    /// Metodo de Extensão: formata um valor numérico com zeros a esquerda e retorna uma string
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="tamanho"></param>
    /// <returns></returns>
    public static string GetToIntFormatadoEx(this Control obj, int tamanho=0)
    {
      if (string.IsNullOrEmpty(obj.Text)) return obj.Text;
      string value = GetToIntEx(obj).ToString();
      string valorFormatado = value.PadLeft(tamanho, '0');
      return valorFormatado;
    }


    /// <summary>
    /// Metodo de Extensão converte valor da propriedade Text para Long
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static long GetToLongEx(this Control obj)
    {
      try
      {
        if (ControleComPropriedadeText(obj))
        {
          long.TryParse(obj.Text, out long valorConvertido);
          return valorConvertido;
        }
        else
          return 0;
      }
      catch 
      {

        throw;
      }
    }

    /// <summary>
    /// Metodo de Extensão converte valor da propriedade Text para Double
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static double GetToDoubleEx(this Control obj)
    {
      try
      {
        if (ControleComPropriedadeText(obj))
        {
          double.TryParse(obj.Text, out double valorConvertido);
          return valorConvertido;
        }
        else
          return 0;
      }
      catch 
      {

        throw;
      }
    }

    /// <summary>
    /// Metodo de Extensão converte valor da propriedade Text para Decimal
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static decimal GetToDecimalEx(this Control obj)
    {
      try
      {
        if (ControleComPropriedadeText(obj))
        {
          decimal.TryParse(obj.Text, out decimal valorConvertido);
          return valorConvertido;
        }
        else
          return 0;
      }
      catch 
      {

        throw ;
      }
    }

    /// <summary>
    /// Metodo de Extensão: Formata propriedade Text e devolve string com valor decimal formatado 
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string GetToStringFormatadoExt(this Control obj, short numeroCasasDecimais = 2)
    {
      decimal value = GetToDecimalEx(obj);
      //utilizando CultureInfo garantimos que a formatação será a mesma em qualquer maquina.
      obj.Text = value.ToString("N" + numeroCasasDecimais, new CultureInfo("pt-BR"));
      return obj.Text;
    }

    /// <summary>
    /// Metodo de Extensão converte valor da propriedade Text para Char
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static char GetToCharEx(this Control obj)
    {
      try
      {
        if (ControleComPropriedadeText(obj))
        {
          char.TryParse(obj.Text, out char valorConvertido);
          return valorConvertido;
        }
        else
          return '0';
      }
      catch 
      {

        throw;
      }
    }
    private static bool ControleComPropriedadeText(Control obj)
    {

      if ((obj is ButtonEdit button) ||
         (obj is LabelEdit label) ||
         (obj is GroupBoxEdit group) ||
         (obj is MaskedTextBoxEdit mtb) ||
         (obj is TextBoxEdit txt))
        return true;
      else
        return false;

    }
  }
}
