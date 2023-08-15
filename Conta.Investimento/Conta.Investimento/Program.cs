using System;
using Fiap.Banco.Enum;
using Fiap.Banco.Models;

    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente
            {
                Agencia = 123,
                Numero = 456,
                DataAbertura = DateTime.Now,
                Saldo = 1000,
                Tipo = TipoConta.Comum
            };

            ContaPoupanca contaPoupanca = new ContaPoupanca(0.05m)
            {
                Agencia = 789,
                Numero = 123,
                DataAbertura = DateTime.Now,
                Saldo = 5000,
                Taxa = 2
            };

            try
            {
                contaCorrente.Retirar(500);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Erro ao retirar da Conta Corrente: " + ex.Message);
            }

            try
            {
                contaPoupanca.Retirar(550);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Erro ao retirar da Conta Poupança: " + ex.Message);
            }
        }
    }
