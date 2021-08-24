
namespace ByteBank.Funcionarios
{
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
}
