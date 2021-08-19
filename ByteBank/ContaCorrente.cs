﻿using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        private double _saldo = 100;
        public int  Agencia { get; }
        public int  Numero { get; }//somente o get deixa  ReadOnly
        public Cliente Titular { get;  set; } 
        public static int TotalDeContas { get; private set; }   
        public static double TaxaOperacao { get; private set; }

        public ContaCorrente(int agencia, int numero)//metodo construtor
        {
            Agencia = agencia;
            Numero = numero;

            if(agencia <=0 )
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0",nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0", nameof(numero));
            }            
            TotalDeContas++;
            TaxaOperacao = 30 / TotalDeContas;
        }
        public double Saldo
        {
            get
            {
                return this._saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                this._saldo = value;
            }
        }
        public void Sacar(double valor)
        {
            if(valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }

            if (this._saldo < valor)
            {
                throw new SaldoInsuficienteException("Saldo insuficiente para o saque no valor de: "+valor);
            }

            this._saldo -= valor;
            
        }
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }
        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para o transferência.", nameof(valor));
            }

            Sacar(valor);
            contaDestino.Depositar(valor);
        }
    }
}