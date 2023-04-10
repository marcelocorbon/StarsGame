public class CartaAtor : Carta
{
    public int PontosAtuacao { get; set; }

    public CartaAtor(string nome, string descricao, int pontosAtuacao)
        : base(nome, descricao)
    {
        PontosAtuacao = pontosAtuacao;
    }

    public override void Usar()
    {
        Console.WriteLine($"A carta {Nome} foi usada para ganhar {PontosAtuacao} pontos de atuação!");
    }
}
