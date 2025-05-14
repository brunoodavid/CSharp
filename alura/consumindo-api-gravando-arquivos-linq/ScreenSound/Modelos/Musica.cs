using System.Text.Json.Serialization;

class Musica
{

    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    [JsonPropertyName("year")]
    public string Ano { get; set; }
    [JsonPropertyName("key")]
    public int Key { get; set; }
    private string[] tonalidade = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
    public string Tonalidade
    {
        get
        {
            return tonalidade[Key];
        }
    }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Nome da musica: {Nome}");
        Console.WriteLine($"Nome do artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");
    }

    public void ExibirTodasAsMusicasComC()
    {
        if (Tonalidade == "C#")
        {
            Console.WriteLine($"Nome da musica: {Nome}");
            Console.WriteLine($"Tonalidade: {Tonalidade}");
        }
    }
}