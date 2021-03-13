using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
//Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
            Console.Write("Digite o número: ");
            int number = int.Parse(Console.ReadLine());

            if(number%2 == 0){
                System.Console.WriteLine("PAR");
            }else{
                System.Console.WriteLine("IMPAR");
            }
        }
    }
}
