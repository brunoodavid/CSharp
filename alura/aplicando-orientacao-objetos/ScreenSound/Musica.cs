class Musica
{
    public string? Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero GeneroMusical { get; set; } = new Genero();
    //utilizando o lambda
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";

    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
        Console.WriteLine($"Genero {GeneroMusical.NomeGenero}");
        Console.WriteLine();
    }
}