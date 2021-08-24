
namespace ByteBank.Funcionarios
{
  class Designer : Funcionario
  {
    public Designer(string cpf) : base(3000, cpf)//utilizando o cpf do metodo construtor do funcionario
    {

    }
    public override void AumentarSalario()
    {
      Salario *= 1.11;
    }
    public override double GetBonificacao()
    {
      return Salario * 0.17;//GetBonificacao do funcionario
    }
  }
}
