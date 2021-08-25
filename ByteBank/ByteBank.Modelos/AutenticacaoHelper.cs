using System;

namespace ByteBank.Modelos
{
  internal class AutenticacaoHelper//internal referencia essa classe visivel somente a esse projeto, sem prefixo tambem é internal.
  {
    public bool CompararSenhas(string senhaVerdadeira, string senhaTentativa)
    {
      return senhaVerdadeira == senhaTentativa;
    }
  }
}
