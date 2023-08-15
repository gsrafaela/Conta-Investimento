﻿using System;
namespace Fiap.Banco.Models
{
    public abstract class Conta
    {
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public DateTime DataAbertura { get; set; }
        public decimal Saldo { get; set; }

        public abstract void Depositar(decimal valor);
        public abstract void Retirar(decimal valor);
    }
}

