﻿using System;


namespace ByteBank
{
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
}
