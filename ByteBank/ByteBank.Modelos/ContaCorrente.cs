﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
  /// <summary>
  /// Define uma conta Corrente do banco Bytebank
  /// </summary>
  public class ContaCorrente
  {
    private static int TaxaOperacao;

    public static int TotalDeContasCriadas { get; private set; }

    public Cliente Titular { get; set; }

    public int ContadorSaquesNaoPermitidos { get; private set; }
    public int ContadorTransferenciasNaoPermitidas { get; private set; }

    public int Numero { get; }
    public int Agencia { get; }

    private double _saldo = 100;
    public double Saldo
    {
      get
      {
        return _saldo;
      }
      set
      {
        if (value < 0)
        {
          return;
        }

        _saldo = value;
      }
    }
    /// <summary>
    /// Cria uma instancia de ContaCorrente com os argumentos utilizados
    /// </summary>
    /// <param name="agencia">Representa o valor da propiedade <see cref="Agencia"/></param>
    /// <param name="numero">Representa o valor da propiedade <see cref="Numero"/></param> 
    public ContaCorrente(int agencia, int numero)
    {
      if (numero <= 0)
      {
        throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));
      }

      if (numero <= 0)
      {
        throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));
      }

      Agencia = agencia;
      Numero = numero;

      TotalDeContasCriadas++;
      TaxaOperacao = 30 / TotalDeContasCriadas;
    }
    /// <summary>
    /// Realiza o saque e atualiza o valor da propiedade <see cref="Saldo"/>
    /// </summary>
    /// <exception cref="ArgumentException"> Exceção Lançada quando um valor negativo é utilizado no argumento <paramref name="valor"/></exception>
    /// <exception cref="SaldoInsuficienteException">Exceção lançada quando o valor de <paramref name="valor"/> é maior que o valor da propiedade<see cref="Saldo"/> </exception>
    /// <param name="valor">Representa o valor do saque</param>
    public void Sacar(double valor)
    {
      if (valor < 0)
      {
        throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
      }

      if (_saldo < valor)
      {
        ContadorSaquesNaoPermitidos++;
        throw new SaldoInsuficienteException(Saldo, valor);
      }

      _saldo -= valor;
    }

    public void Depositar(double valor)
    {
      _saldo += valor;
    }

    public void Transferir(double valor, ContaCorrente contaDestino)
    {
      if (valor < 0)
      {
        throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
      }

      try
      {
        Sacar(valor);
      }
      catch (SaldoInsuficienteException ex)
      {
        ContadorTransferenciasNaoPermitidas++;
        throw new OperacaoFinanceiraException("Operação não realizada.", ex);
      }

      contaDestino.Depositar(valor);
    }
  }

}
