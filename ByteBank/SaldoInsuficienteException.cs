using System;


namespace ByteBank
{
<<<<<<< HEAD
  public class SaldoInsuficienteException : OperacaoFinanceiraException
  {
    public double Saldo { get; }
    public double ValorSaque { get; }
    public SaldoInsuficienteException()
    {

    }
    public SaldoInsuficienteException(double saldo, double valorSaque) : this("Tentativa de saque do valor de " + valorSaque + "em uma conta com saldo de " + saldo)
    {
      this.Saldo = saldo;
      this.ValorSaque = valorSaque;
    }
    public SaldoInsuficienteException(String mensagem) : base(mensagem)
    {

    }
    public SaldoInsuficienteException(String mensagem, Exception excecaoInterna) : base(mensagem, excecaoInterna)
    {

    }
  }
=======
    public class SaldoInsuficienteException : Exception
    {
        public double Saldo { get; }
        public double ValorSaque { get; }
        public SaldoInsuficienteException() 
        {

        }
        public SaldoInsuficienteException(double saldo, double valorSaque) : this ("Tentativa de saque do valor de "+valorSaque+"em uma conta com saldo de "+saldo)
        {
            this.Saldo = saldo;
            this.ValorSaque = valorSaque;
        }
        public SaldoInsuficienteException(String mensagem) : base(mensagem)
        {

        }
    }
>>>>>>> a3d1302390df0f23180b9d09d958442597572cff
}
