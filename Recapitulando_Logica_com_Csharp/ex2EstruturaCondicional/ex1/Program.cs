using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite o número: ");
            int number = int.Parse(Console.ReadLine());
            if (number >= 0){
                Console.WriteLine("NAO NEGATIVO");
            }else{
                Console.WriteLine("NEGATIVO");
            }
            
        }
    }
}
