using System;
using System.IO;

namespace ByteBank
{
  public class LeitorDeArquivos : IDisposable
  {
    public string Arquivo { get; }
    public LeitorDeArquivos(string arquivo)
    {
      Arquivo = arquivo;
      throw new FileNotFoundException();
      Console.WriteLine("Abrindo arquivo: " + arquivo);
    }
    public string LerProximaLinha()
    {
      Console.WriteLine("Lendo linha...");

      //throw new IOException();
      return "Linha do arquivo";
    }
    public void Dispose()//o metodo Dispose se assemelha ao finally utilizado no try
    {
      Console.WriteLine("Fechando arquivo");
    }
  }
}
