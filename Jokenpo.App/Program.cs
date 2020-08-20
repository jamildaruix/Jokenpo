using System;

namespace Jokenpo.App
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;

            do
            {
                var campeonato = Campeonato.Create();
                campeonato.Jogar();

                Console.WriteLine("Precione tecla ENTER pra jogar novamente\n");
                key = Console.ReadKey();

            } while (key.Key == ConsoleKey.Enter);
        }
    }
}
