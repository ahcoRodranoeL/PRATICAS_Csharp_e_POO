using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
//Ler um número inteiro N e calcular todos os seus divisores.
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++){
                if(n % i == 0){
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}
