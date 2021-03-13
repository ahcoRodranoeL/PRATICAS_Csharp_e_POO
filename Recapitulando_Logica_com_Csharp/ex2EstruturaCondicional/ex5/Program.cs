using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
//Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.
            System.Console.WriteLine("Digite o código do produto desejado e a quantidade: ");
            string[] compra = Console.ReadLine().Split(' ');
            int cod = int.Parse(compra[0]);
            int qtd = int.Parse(compra[1]);
            double total = 0;
            switch (cod){
                case 1:
                total = 4.00*qtd;
                break;
                case 2:
                total = 4.50*qtd;
                break;
                case 3:
                total = 5.00*qtd;
                break;
                case 4:
                total = 2.00*qtd;
                break;
                case 5:
                total = 1.50*qtd;
                break;
                default:
                System.Console.WriteLine("Cógido inválido");
                break;
            }
            Console.WriteLine($"Total: R$ {total.ToString("F2")}");
        }
    }
}
