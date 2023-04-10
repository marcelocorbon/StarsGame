public class CartaCantor : Carta
{
    public int PontosCanto { get; set; }

    public CartaCantor(string nome, string descricao, int pontosCanto)
        : base(nome, descricao)
    {
        PontosCanto = pontosCanto;
    }

    public override void Usar()
    {
        Console.WriteLine($"A carta {Nome} foi usada para ganhar {PontosCanto} pontos de canto!");
    }
}
