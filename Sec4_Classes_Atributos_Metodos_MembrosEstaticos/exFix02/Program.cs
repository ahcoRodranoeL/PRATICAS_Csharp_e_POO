using System;

namespace exFix02
{
    class Program
    {
        static void Main(string[] args)
        {
//Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto). Em seguida, mostrar os dados do funcionário (nome e salário líquido). Em seguida, aumentar o salário do funcionário com base em uma porcentagem dada (somente o salário bruto é afetado pela porcentagem) e mostrar novamente os dados do funcionário. Use a classe projetada abaixo.
            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            System.Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            System.Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Funcionário: " + f);
            System.Console.WriteLine();
            System.Console.Write("Digite a porcentagem para aumentar o Salário: ");
            double aumento = double.Parse(Console.ReadLine());
            f.AumentoSalario(aumento);
            System.Console.WriteLine("Dados Atualizados: " + f);
        }
    }
}
