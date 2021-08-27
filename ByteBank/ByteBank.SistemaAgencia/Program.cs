using ByteBank.Modelos;
using System;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
  class Program
  {
    static void Main(string[] args)
    {
       StringRegex();

      Console.ReadLine();
    }    
    static void StringRegex()
    {
      string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

      int indice = url.IndexOf('?');

      string argumentos = url.Substring(indice);

      Console.WriteLine(argumentos);
      
    }
    static void NuGet()
    {
      DateTime dataFimPagamento = new(2022, 8, 17);
      DateTime dataCorrente = DateTime.Now;

      TimeSpan diferenca = dataFimPagamento - dataCorrente;
      string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);
      Console.WriteLine(mensagem);
      Console.ReadLine();
    }
  }
}
