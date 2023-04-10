public class Baralho
{
    private List<Carta> cartas;
    private Random random;

    public Baralho()
    {
        cartas = new List<Carta>();
        random = new Random();

        cartas.Add(new CartaAtor("Tom Cruise", "Ator de filmes de ação", 1));
        cartas.Add(new CartaAtor("Denzel Washington", "Ator vencedor do Oscar", 2));
        cartas.Add(new CartaAtor("Leonardo DiCaprio", "Ator que nunca ganhou um Oscar", 3));
        cartas.Add(new CartaAtor("Robert Downey Jr.", "Ator de filmes de super-heróis", 4));
        cartas.Add(new CartaAtor("Brad Pitt", "Ator que traiu Angelina Jolie", 5));
        cartas.Add(new CartaAtor("Andrew Garfield", "Melhor ator do Spider Man", 6));

        cartas.Add(new CartaCantor("Taylor Swift", "Cantora pop famosa", 7));
        cartas.Add(new CartaCantor("Selena Gomez", "Melhor cantora pop famosa", 8));
        cartas.Add(new CartaCantor("Justin Bieber", "Ex da Selena Gomez", 9));
        cartas.Add(new CartaCantor("Beyoncé", "Cantora de R&B famosa", 10));
        cartas.Add(new CartaCantor("Ariana Grande", "Cantora com mais de 100 milhões de seguidores no Instagram", 11));
        cartas.Add(new CartaCantor("Ed Sheeran", "Cantor e compositor britânico", 12));
    }

    //public void Embaralhar()
    //{
    //    Random random = new Random();

    //    for (int i = cartas.Count - 1; i > 0; i--)
    //    {
    //        int j = random.Next(i + 1);
    //        Carta temp = cartas[i];
    //        cartas[i] = cartas[j];
    //        cartas[j] = temp;
    //    }
    //}

    public void Embaralhar()
    {
        Random random = new Random();

        for (int i = 0; i < cartas.Count; i++)
        {
            int j = random.Next(i, cartas.Count);
            cartas.Swap(i, j);
        }
    }

    public bool TemCartasSuficientes(int quantidade)
    {
        return cartas.Count >= quantidade;
    }

    public List<Carta> Distribuir(int quantidade)
    {
        if (!TemCartasSuficientes(quantidade))
        {
            throw new Exception("Não há cartas suficientes no baralho!");
        }

        List<Carta> cartasDistribuidas = cartas.Take(quantidade).ToList();
        cartas.RemoveRange(0, quantidade);
        return cartasDistribuidas;
    }
}
