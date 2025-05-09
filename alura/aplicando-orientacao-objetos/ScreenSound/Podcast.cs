class Podcast
{
    public string? Host { get; }
    public string? Nome { get; }
    private List<Episodio> _listaEpisodios { get; set; } = new List<Episodio>();
    public int TotalEpisodios => _listaEpisodios.Count;

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        _listaEpisodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"O nome do podcast é {Nome} e seu Host {Host}\n");
        foreach (var episodio in _listaEpisodios)
        {
            Console.WriteLine($"Episodio: {episodio.Resumo}");
        }
        Console.WriteLine($"\nEste podcast possui {TotalEpisodios} episódios.");
    }
}