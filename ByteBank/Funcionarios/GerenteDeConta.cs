
namespace ByteBank.Funcionarios
{
<<<<<<< HEAD
  class GerenteDeConta : FuncionarioAutenticavel
  {
    public GerenteDeConta(string cpf) : base(4000, cpf)//utilizando o cpf do metodo construtor do funcionario
    {

    }
    public override void AumentarSalario()
    {
      Salario *= 1.05;
    }
    public override double GetBonificacao()
    {
      return Salario * 0.25;//GetBonificacao do funcionario
    }
  }
=======
    class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf) : base(4000, cpf)//utilizando o cpf do metodo construtor do funcionario
        {

        }
        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.25;//GetBonificacao do funcionario
        }
    }
>>>>>>> a3d1302390df0f23180b9d09d958442597572cff
}
