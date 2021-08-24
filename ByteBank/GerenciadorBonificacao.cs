using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
<<<<<<< HEAD
  public class GerenciadorBonificacao
  {
    private double _totalBonificacao;

    public void Registrar(Funcionario funcionario)
    {
      _totalBonificacao += funcionario.GetBonificacao();
    }
    public double GetTotalBonificacao()
    {
      return _totalBonificacao;
    }
  }
=======
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }
        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
>>>>>>> a3d1302390df0f23180b9d09d958442597572cff
}
