using System.Text.Json;

class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasPreferidas { get; } = new List<Musica>();

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasPreferidas.Add(musica);
    }

    public void ExibirMusicasFavoridas()
    {
        Console.WriteLine($"Essas são as musicas favoridas do {Nome}");
        foreach (var musica in ListaDeMusicasPreferidas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
    }

    public void GerarArquivoJson()
    {
        var json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasPreferidas
        });
        string nomeDoArquivo = $"musicas-preferidas-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo json foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }
}