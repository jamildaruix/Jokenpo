namespace Jokenpo.App
{
    public class Pedra : JogoAbstract
    {
        public Pedra(Jogador jogadorA, Jogador jogadorB) : base(jogadorA, jogadorB)
        {
        }

        public static Pedra Create(Jogador jogadorA, Jogador jogadorB) => new Pedra(jogadorA, jogadorB);
    }
}