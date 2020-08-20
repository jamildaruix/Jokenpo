namespace Jokenpo.App
{
    public class Tesoura : JogoAbstract
    {
        private Tesoura(Jogador jogadorA, Jogador jogadorB) : base(jogadorA, jogadorB)
        {
        }

        public static Tesoura Create(Jogador jogadorA, Jogador jogadorB) => new Tesoura(jogadorA, jogadorB);

        public override void Ganhador()
        {
            // Aqui poderia ter uma outra rotina
            base.Ganhador();
        }
    }
}