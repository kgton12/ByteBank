using System;

namespace ByteBank.SistemaAgencia
{
  public class ExtratorDeArgumentosURL
  {
    private readonly string _argumentos;
    public string URL { get; }
    public ExtratorDeArgumentosURL(string url)
    {
      if (String.IsNullOrEmpty(url))
      {
        throw new ArgumentException("O argumento url não poder ser nulo ou vazio", nameof(url));
      }

      _argumentos = url.Substring(url.IndexOf('?') + 1);

      URL = url;
    }

    public string GetValor(string nomeParametro)
    {
      nomeParametro = nomeParametro.ToUpper();
      string argumentoToUpper = _argumentos.ToUpper();
      string termo = nomeParametro + "=";
      int indiceTermo = argumentoToUpper.IndexOf(termo);

      string resultado = _argumentos.Substring(indiceTermo + termo.Length);
      int indiceEComercial = resultado.IndexOf('&');

      if (indiceEComercial == -1)
      {
        return resultado;
      }

      return resultado.Remove(indiceEComercial);
    }
  }
}
