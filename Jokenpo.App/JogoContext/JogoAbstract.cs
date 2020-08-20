using System;
using System.Collections.Generic;
using System.Linq;

namespace Jokenpo.App
{
    public abstract class JogoAbstract : IJogo
    {
        protected const string EMPATE = "Empate entre os jogadores";
        protected Jogador JogadorA { get; }
        protected Jogador JogadorB { get; }

        protected ISet<(EOpcao Ganha, EOpcao Perde)> Regra = new HashSet<(EOpcao Ganha, EOpcao Perde)>();

        private protected JogoAbstract(Jogador jogadorA, Jogador jogadorB)
        {
            JogadorA = jogadorA;
            JogadorB = jogadorB;
            CriarRegra();
        }

        public virtual void Ganhador()
        {
            Console.WriteLine($"Opção do {JogadorA.Individuo} foi {JogadorA.Opcao}");
            Console.WriteLine($"Opção do {JogadorB.Individuo} foi {JogadorB.Opcao}");

            if (JogadorA.Opcao == JogadorB.Opcao)
                Console.WriteLine(EMPATE);
            else if (Regra.Any(p => p == (JogadorA.Opcao, JogadorB.Opcao)))
                Console.WriteLine(JogadorA.ToString());
            else
                Console.WriteLine(JogadorB.ToString());

            Console.WriteLine();
        }

        private void CriarRegra()
        {
            Regra.Add((EOpcao.Pedra, EOpcao.Tesoura));
            Regra.Add((EOpcao.Papel, EOpcao.Pedra));
            Regra.Add((EOpcao.Tesoura, EOpcao.Papel));
        }
    }
}
