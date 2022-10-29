using System.ComponentModel;

namespace Controles
{
  public class TiposConversao
  {
    //public class TipoBoolean : StringConverter
    //{
    //  public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
    //  {
    //    return true;
    //  }
    //  public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
    //  {
    //    return new StandardValuesCollection(new bool[] { true, false });
    //  }
    //}


  }
  public class Converter
  {
    private static Converter instancia;

    private Converter()
    {

    }
    public static Converter GetInstancia
    {
      get { return instancia = instancia ?? new Converter(); }
    }
    /*
    public decimal GetToDecimal(string value)
    {
      try
      {
        decimal.TryParse(value, out decimal valorConvertido);
        return valorConvertido;
      }
      catch (System.Exception)
      {

        return 0;
      }
    }

    public double GetToDouble(string value)
    {
      try
      {
        double.TryParse(value, out double valorConvertido);
        return valorConvertido;
      }
      catch (System.Exception)
      {

        return 0;
      }
    }

    public int GetToInt(string value)
    {
      try
      {
        int.TryParse(value, out int valorConvertido );
        return valorConvertido;
      }
      catch (System.Exception)
      {

        return 0;
      }
    }

    /// <summary>
    /// vamos usar tipo long quando precisarmos Int64 ou seja BigInt 
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public long GetToLong(string value)
    {
      try
      {
        long.TryParse(value, out long valorConvertido );
        return valorConvertido;
      }
      catch (System.Exception)
      {

        return 0;
      }
    }
    */
  }

}

