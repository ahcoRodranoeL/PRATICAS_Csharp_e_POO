using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
//Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas, começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme exemplo.
            
            int n = int.Parse(Console.ReadLine());
            int a, b;
            for(int i = 1; i <= n; i++){
                
                a = (int)Math.Pow(i,2);
                b = (int)Math.Pow(i,3);
                System.Console.WriteLine(i+" "+a+" "+b);
            }
        }
    }
}
