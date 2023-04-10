public class Program
{
    public static void Main()
    {
        Baralho baralho = new Baralho();
        baralho.Embaralhar();

        Jogador jogador1 = new Jogador("Jogador 1");
        Jogador jogador2 = new Jogador("Jogador 2");

        List<Carta> cartasJogador1 = baralho.Distribuir(6);
        List<Carta> cartasJogador2 = baralho.Distribuir(6);

        jogador1.ReceberCartas(cartasJogador1);
        jogador2.ReceberCartas(cartasJogador2);

        MiddleGame(jogador1, jogador2);

        EndedGame(jogador1, jogador2);
    }

    private static void MiddleGame(Jogador jogador1, Jogador jogador2)
    {
        while (jogador1.TemCartasSuficientes() && jogador2.TemCartasSuficientes())
        {
            Console.WriteLine($"Jogador 1 tem {jogador1.Cartas.Count} cartas.");
            Console.WriteLine($"Jogador 2 tem {jogador2.Cartas.Count} cartas.");

            Carta cartaJogadaJogador1 = jogador1.Cartas[0];
            Carta cartaJogadaJogador2 = jogador2.Cartas[0];

            Console.WriteLine($"Jogador 1 jogou a carta {cartaJogadaJogador1.Nome}.");
            Console.WriteLine($"Jogador 2 jogou a carta {cartaJogadaJogador2.Nome}.");

            if (cartaJogadaJogador1 is CartaAtor && cartaJogadaJogador2 is CartaCantor)
            {
                Console.WriteLine("Jogador 1 ganhou!");
                jogador1.JogarCarta(cartaJogadaJogador1);
                jogador2.JogarCarta(cartaJogadaJogador2);
                jogador1.AdicionarPonto();
            }
            else if (cartaJogadaJogador1 is CartaCantor && cartaJogadaJogador2 is CartaAtor)
            {
                Console.WriteLine("Jogador 2 ganhou!");
                jogador1.JogarCarta(cartaJogadaJogador1);
                jogador2.JogarCarta(cartaJogadaJogador2);
                jogador2.AdicionarPonto();
            }
            else
            {
                Console.WriteLine("Empate!");
                jogador1.JogarCarta(cartaJogadaJogador1);
                jogador2.JogarCarta(cartaJogadaJogador2);
            }

            Console.WriteLine();
        }
    }

    private static void EndedGame(Jogador jogador1, Jogador jogador2)
    {
        if (jogador1.GetVitorias() > jogador2.GetVitorias())
        {
            Console.WriteLine("Jogador 1 venceu!");
        }
        else if (jogador2.GetVitorias() > jogador1.GetVitorias())
        {
            Console.WriteLine("Jogador 2 venceu!");
        }
        else
        {
            Console.WriteLine("Empate!");
        }
    }
}
