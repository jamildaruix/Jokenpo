using System;

namespace Jokenpo.App
{
    public class Jogador
    {
        public string Individuo { get; }
        public EOpcao Opcao { get; private set; }

        private Jogador(string individuo)
        {
            Individuo = individuo;
            SelecionarOpcao();
        }

        public static Jogador Create(string individuo) => new Jogador(individuo);

        public override string ToString() => $"O {Individuo} Ganhou";

        private void SelecionarOpcao()
        {
            var quantidade = Enum.GetValues(typeof(EOpcao)).Length;
            Opcao = (EOpcao)new Random().Next(0, quantidade);
        }
    }
}
