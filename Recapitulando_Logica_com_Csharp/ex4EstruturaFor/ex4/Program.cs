using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++){
                string[] divisao = Console.ReadLine().Split(' ');
                int n1 = int.Parse(divisao[0]);
                int n2 = int.Parse(divisao[1]);
                
                if(n2 == 0){
                    Console.WriteLine("divisão impossivel");
                }else{
                    double resultado = (double)n1 / n2;
                    System.Console.WriteLine(resultado.ToString("F1"));
                }
            }
            
        }
    }
}
