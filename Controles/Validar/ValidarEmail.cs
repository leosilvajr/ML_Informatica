using System.Text.RegularExpressions;

namespace ControlsEdit.Validar
{
  public class ValidarEmail
  {
    private static ValidarEmail instancia;
    private ValidarEmail()
    {

    }
    public static ValidarEmail getInstancia
    {
      get { return instancia = instancia ?? new ValidarEmail(); }
    }
    public bool ValidaEmail(string value)
    {
      Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
      return regex.IsMatch(value);
    }

  }
}
