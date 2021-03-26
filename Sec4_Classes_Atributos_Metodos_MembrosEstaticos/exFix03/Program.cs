using System;

namespace exFix03
{
    class Program
    {
        static void Main(string[] args)
        {
//Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano(primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver este problema.
            Aluno aluno = new Aluno();
            System.Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            System.Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            aluno.Nota2 = double.Parse(Console.ReadLine());
            aluno.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTA FINAL = " + aluno);
            if (aluno.NotaFinal() >= 60.00 ){
                System.Console.WriteLine("APROVADO");
            }else{
                System.Console.WriteLine("REPROVADO");
                System.Console.WriteLine("FALTARAM " + aluno.MargemReprovacao().ToString("F2") + " PONTOS");
            }
        }
    }
}
