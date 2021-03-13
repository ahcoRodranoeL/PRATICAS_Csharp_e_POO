using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
//Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
            double valor = double.Parse(Console.ReadLine());
          
            if(valor < 0.00 || valor > 100.00 ){
                System.Console.WriteLine("Fora do intervalo");
            }else if(valor <= 25.00){
                System.Console.WriteLine("Intervalo [0,25]");
            }else if(valor <= 50.00){
                System.Console.WriteLine("Intervalo [25,50]");
            }else if(valor <= 75.00){
                System.Console.WriteLine("Intervalo [50,75]");
            }else{
                System.Console.WriteLine("Intervalo [75,100]");
            }
        }
    }
}
