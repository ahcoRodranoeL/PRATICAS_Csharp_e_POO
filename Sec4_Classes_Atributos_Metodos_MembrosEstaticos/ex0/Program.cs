using System;

namespace ex0
{
    class Program
    {
        static void Main(string[] args)
        {
//Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.
            Pessoa a = new Pessoa ();
            Pessoa b = new Pessoa ();
            Console.WriteLine("Digite os dados da primeira pessoa: ");
            System.Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            System.Console.Write("Idade: ");
            a.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os dados da segunda pessoa: ");
            System.Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            System.Console.Write("Idade: ");
            b.Idade = int.Parse(Console.ReadLine());

            if(a.Idade > b.Idade){
                System.Console.WriteLine("Pessoa mais velha: " + a.Nome);
            }else{
                System.Console.WriteLine("Pessoa mais velha: " + b.Nome);
            }
        }
    }
}
