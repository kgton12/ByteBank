
namespace ByteBank.Funcionarios
{
<<<<<<< HEAD
  class Auxiliar : Funcionario
  {
    public Auxiliar(string cpf) : base(2000, cpf)//utilizando o cpf do metodo construtor do funcionario
    {

    }
    public override void AumentarSalario()
    {
      Salario *= 1.1;
    }
    public override double GetBonificacao()
    {
      return Salario * 0.2;//GetBonificacao do funcionario
    }
  }
=======
    class Auxiliar: Funcionario
    {
        public Auxiliar(string cpf) : base(2000, cpf)//utilizando o cpf do metodo construtor do funcionario
        {

        }
        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.2;//GetBonificacao do funcionario
        }
    }
>>>>>>> a3d1302390df0f23180b9d09d958442597572cff
}
