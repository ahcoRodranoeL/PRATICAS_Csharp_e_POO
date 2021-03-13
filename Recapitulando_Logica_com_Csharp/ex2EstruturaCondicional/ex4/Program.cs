using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
//Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.           
            Console.WriteLine("Digite a hora de inicio e hora do fim do jogo: ");
            string[] tempo = Console.ReadLine().Split(' ');
                int horaInicio = int.Parse(tempo[0]);
                int horaFim = int.Parse(tempo[1]);
                int horaTotal;


            if(horaFim > horaInicio){
                horaTotal = horaFim - horaInicio;
            }else{
               horaTotal = 24 - horaInicio + horaFim;
            }
            System.Console.WriteLine($"O JOGO DUROU {horaTotal} HORA(S)");
        }
    }
}
