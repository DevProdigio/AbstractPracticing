using System;
using Sistema_de_pagamento;

class Program
{
    static void Main(string[] args)
    {
        CartaoCredito cartaoCredito = new CartaoCredito();
        Boleto boleto = new Boleto();
        Pix pix = new Pix();


        Console.WriteLine("Qual forma de pagamento deseja aderir? \n" +
            "1. Cartão de Credito\n" +
            "2. Boleto\n" +
            "3. Pix\n" +
            "4. Sair");
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.WriteLine("Você escolheu a opção Cartão de Credito");
                Console.WriteLine("Qual o Valor a ser pago?");
                cartaoCredito.Valor = decimal.Parse(Console.ReadLine());
                cartaoCredito.ProcessarPagamento();
                break;
            case "2":
                Console.WriteLine("Você escolheu a opção Boleto");
                Console.WriteLine("Qual o Valor a ser pago?");
                boleto.Valor = decimal.Parse(Console.ReadLine());
                boleto.ProcessarPagamento();
                break;
            case "3":
                Console.WriteLine("Você escolheu a opção Boleto");
                Console.WriteLine("Qual o Valor a ser pago?");
                pix.Valor = decimal.Parse(Console.ReadLine());
                pix.ProcessarPagamento();
                break;
            case "4":
                Console.WriteLine("Saindo do sistema...");
                break;
            default:
                Console.WriteLine("Escola uma opção valida.");
                break;
        }
    }
}