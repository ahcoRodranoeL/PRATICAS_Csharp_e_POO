using System;

namespace exFix01
{
    class Program
    {
        static void Main(string[] args)
        {
//Fazer um programa para ler os valores da largura e altura de um retângulo. Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe como mostrado no projeto ao lado.
            Retangulo r = new Retangulo();
            System.Console.WriteLine("Digite a largura e a altura do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine());
            r.Altura = double.Parse(Console.ReadLine());
            
            Console.WriteLine("AREA = " + r.Area().ToString("F2"));
            
            Console.WriteLine("PERIMETRO = " + r.Perimetro().ToString("F2"));
            
            Console.WriteLine("DIAGONAL = " + r.Diagonal().ToString("F2"));
        }
    }
}
