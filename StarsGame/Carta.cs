public class Carta
{
    public string Nome { get; set; }
    public string Descricao { get; set; }

    public Carta(string nome, string descricao)
    {
        Nome = nome;
        Descricao = descricao;
    }

    public virtual void Usar()
    {
        Console.WriteLine($"A carta {Nome} foi usada!");
    }
}
