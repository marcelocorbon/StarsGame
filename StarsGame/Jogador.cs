public class Jogador
{
    public string Nome { get; set; }
    private int Vitorias { get; set; }
    public List<Carta> Cartas { get; set; }

    public Jogador(string nome)
    {
        Nome = nome;
        Vitorias = 0;
        Cartas = new List<Carta>();
    }

    public void ReceberCartas(List<Carta> cartasRecebidas)
    {
        Cartas.AddRange(cartasRecebidas);
    }

    public void JogarCarta(Carta cartaJogada)
    {
        Cartas.Remove(cartaJogada);
        cartaJogada.Usar();
    }

    public bool TemCartasSuficientes()
    {
        return Cartas.Count > 0;
    }

    public void AdicionarPonto()
    {
        Vitorias++;
    }

    public int GetVitorias()
    {
        return Vitorias;
    }
}
