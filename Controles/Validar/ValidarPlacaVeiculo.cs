using System.Text.RegularExpressions;

namespace ControlsEdit.Validar
{
  internal class ValidarPlacaVeiculo
  {
    private static ValidarPlacaVeiculo instancia;

    private ValidarPlacaVeiculo()
    {

    }

    public static ValidarPlacaVeiculo getInstancia
    {
      get { return instancia = instancia ?? new ValidarPlacaVeiculo(); }
    }

    internal bool ValidarPlaca(string placa)
    {
      //estamos aqu utilizando a classe de expressao regular para verificar se a placa é valida.
      Regex regexPlaca = new Regex(@"^[a-zA-Z]{3}[0-9]{1}[0-9a-zA-Z]{1}[0-9]{2}$");
      if (regexPlaca.IsMatch(placa))
        return true; //placa válida
      else
        return false;
    }

  }
}
