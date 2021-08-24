﻿using System;

namespace ByteBank.Funcionarios
{
<<<<<<< HEAD
  public abstract class Funcionario
  {
    public static int TotalDeFuncionarios { get; private set; }
    public string Nome { get; set; }
    public string CPF { get; private set; }
    public double Salario { get; protected set; }//protected permite que as classes derivadas tambem consigam usar o set.

    public Funcionario(double salario, string cpf)
    {
      CPF = cpf;
      Salario = salario;
      TotalDeFuncionarios++;
    }

    public abstract double GetBonificacao();

    public abstract void AumentarSalario();

  }
=======
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        //0 - funcionario
        //1- diretor
        //2- designer
        private int _tipo;
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }//protected permite que as classes derivadas tambem consigam usar o set.

        public Funcionario(double salario, string cpf)
        {
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        public abstract  double GetBonificacao();

        public abstract void AumentarSalario();
        
    }
>>>>>>> a3d1302390df0f23180b9d09d958442597572cff
}
