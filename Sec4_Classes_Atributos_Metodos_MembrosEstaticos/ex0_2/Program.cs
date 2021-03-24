using System;

namespace ex0_2
{
    class Program
    {
        static void Main(string[] args)
        {
//Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.
            Funcionarios a = new Funcionarios();
            Funcionarios b = new Funcionarios();
            
            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            a.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            b.Salario = double.Parse(Console.ReadLine());

            double salarioMedio = (a.Salario + b.Salario) / 2.0; 
            System.Console.WriteLine($"Salário médio = {salarioMedio.ToString("F2")}");
        }
    }
}
