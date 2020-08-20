using System;
using System.Collections.Generic;

namespace Jokenpo.App
{
    public class Campeonato
    {
        private Campeonato() { }

        public static Campeonato Create() => new Campeonato();

        public void Jogar()
        {
            Console.WriteLine("Inicio do jogo");
            
            var jogos = MelhorDeTres;

            foreach (var item in jogos)
                item.Ganhador();

            Console.WriteLine("Fim do jogo");
        }


        private IList<IJogo> MelhorDeTres => new List<IJogo>
                                            {
                                                Tesoura.Create(Jogador.Create($"Jogador A"), Jogador.Create($"Jogador B")),
                                                Pedra.Create(Jogador.Create($"Jogador A"), Jogador.Create($"Jogador B")),
                                                Papel.Create(Jogador.Create($"Jogador A"), Jogador.Create($"Jogador B"))
                                            };
    }
}
