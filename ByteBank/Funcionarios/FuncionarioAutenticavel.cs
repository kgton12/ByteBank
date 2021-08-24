
namespace ByteBank.Funcionarios
{
<<<<<<< HEAD
  public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
  {
    public string Senha { get; set; }
    public FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf)
    {

    }

    public bool Autenticar(string senha)
    {
      return this.Senha == senha;
    }
  }
=======
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        public FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf)
        {

        }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
>>>>>>> a3d1302390df0f23180b9d09d958442597572cff
}
