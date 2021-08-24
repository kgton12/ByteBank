using System;

namespace ByteBank.Funcionarios
{
<<<<<<< HEAD
  public class Diretor : FuncionarioAutenticavel
  {
    public Diretor(string cpf) : base(5000, cpf)//utilizando o cpf do metodo construtor do funcionario
    {

    }

    public override void AumentarSalario()
    {
      Salario *= 1.15;
    }
    public override double GetBonificacao()
    {
      return Salario * 0.5;//GetBonificacao do funcionario
    }
  }
=======
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(5000, cpf)//utilizando o cpf do metodo construtor do funcionario
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.5;//GetBonificacao do funcionario
        }
    }
>>>>>>> a3d1302390df0f23180b9d09d958442597572cff
}
