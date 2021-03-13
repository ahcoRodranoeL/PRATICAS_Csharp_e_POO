using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
//Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.
            
            Console.WriteLine("Digite os números: ");

            string[] valores = Console.ReadLine().Split(' ');
                int a = int.Parse(valores[0]);
                int b = int.Parse(valores[1]);

            if(a % b == 0 || b % a == 0){
                System.Console.WriteLine("SÃO MULTIPLOS");
            }else{
                System.Console.WriteLine("NÃO SÃO MULTIPLOS");
            }
        }
    }
}
