using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
//Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++){
                string[] notas = Console.ReadLine().Split(' ');
                double n1 = double.Parse(notas[0]);
                double n2 = double.Parse(notas[1]);
                double n3 = double.Parse(notas[2]);
                
                double mediaPonderada = (n1 * 2.0 + n2 * 3.0 + n3 * 5.0) / 10.0;
                Console.WriteLine(mediaPonderada.ToString("F1"));
            }
        }
    }
}
