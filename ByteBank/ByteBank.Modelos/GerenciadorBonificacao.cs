using ByteBank.Modelos.Funcionarios;
using System;

namespace ByteBank.Modelos
{
  public class GerenciadorBonificacao
  {
    private double _totalBonificacao;

    public void Registrar(Funcionario funcionario)
    {
      _totalBonificacao += funcionario.GetBonificacao();
    }

    internal double GetTotalBonificacao()
    {
      return _totalBonificacao;
    }
  }
}
