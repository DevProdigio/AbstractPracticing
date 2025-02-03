using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_pagamento
{
    abstract class Pagamentos
    {
        public decimal Valor { get; set; }

        public abstract void ProcessarPagamento();
    }

    class CartaoCredito : Pagamentos
    {
        public override void ProcessarPagamento()
        {
            Console.WriteLine($"Pagamento com cartão de credito efetuado no valor de {Valor}$");
        }
    }

    class Boleto : Pagamentos
    {
        public override void ProcessarPagamento()
        {
            Console.WriteLine($"Pagamento com boleto efetuado no valor de {Valor}$");
        }
    }

    class Pix : Pagamentos
    {
        public override void ProcessarPagamento()
        {
            Console.WriteLine($"Pagamento com pix efetuado no valor de {Valor}$");
        }
    }
}