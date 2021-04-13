using System;

namespace exFix04
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual é a cotação do dólar? ");
            double cotacaoDolar = double.Parse(Console.ReadLine());

            System.Console.Write("Quantos dólares você vai comprar? ");
            double compraDolares = double.Parse(Console.ReadLine());

            double total = ConversorDeMoeda.TotalEmReais(cotacaoDolar, compraDolares);

            System.Console.WriteLine($"Valor a ser pago em reais = {total.ToString("F2")}");
        }
    }
}
