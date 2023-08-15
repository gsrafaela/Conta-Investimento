using System;
using Fiap.Banco.Enum;

namespace Fiap.Banco.Models
{
    public class ContaCorrente : Conta
    {
        public TipoConta Tipo { get; set; }

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Retirar(decimal valor)
        {
            if (Tipo == TipoConta.Comum && Saldo - valor < 0)
            {
                throw new InvalidOperationException("Saldo insuficiente para saque.");
            }
            Saldo -= valor;
        }
    }
}

