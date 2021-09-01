using ByteBank.Modelos;
using System;
using Humanizer;
using System.Text.RegularExpressions;

namespace ByteBank.SistemaAgencia
{
  class Program
  {
    static void Main(string[] args)
    {

      MetodoEquals();
    }
    static void IndexOfString()
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
    static void RegexText()
    { // "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]"
      // "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]"
      // "[0-9]{4,5}[-][0-9]{4}"
      // "[0-9]{4,5}[-]{0,1}[0-9]{4}"
      string padrao = "[0-9]{4,5}[-]?[0-9]{4}";

      string texto = "Me ligue agora 91234-5678";

      Match resultado = Regex.Match(texto, padrao);

      Console.WriteLine(resultado.Value);
    }
    static void OverrideToString()
    {
      ContaCorrente contaCorrente = new(123, 123);
      Console.WriteLine(contaCorrente);
    }
    static void MetodoEquals()
    {
      Cliente cliente1 = new();
      cliente1.Nome = "Joao";
      cliente1.CPF = "123123123";
      cliente1.Profissao = "teste";

      Cliente cliente2 = new();
      cliente2.Nome = "Joao";
      cliente2.CPF = "123123123";
      cliente2.Profissao = "teste";


      if (cliente1.Equals(cliente2))
      {
        Console.WriteLine("Igual");
      }




    }
  }
}
