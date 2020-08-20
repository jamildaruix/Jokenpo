namespace Jokenpo.App
{
    public class Papel : JogoAbstract
    {
        public Papel(Jogador jogadorA, Jogador jogadorB) : base(jogadorA, jogadorB)
        {
        }

        public static Pedra Create(Jogador jogadorA, Jogador jogadorB) => new Pedra(jogadorA, jogadorB);
    }
}
