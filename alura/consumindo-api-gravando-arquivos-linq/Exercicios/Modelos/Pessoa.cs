using System.Text.Json;
using System.Text.Json.Serialization;

class Pessoa
{
    [JsonPropertyName("nome")]
    public string? Nome { get; set; }
    [JsonPropertyName("idade")]
    public int Idade { get; set; }
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    public Pessoa(string nome, int idade, string email)
    {
        Nome = nome;
        Idade = idade;
        Email = email;
    }

    public void GerarArquivoJson()
    {
        var json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            idade = Idade,
            email = Email
        });

        string nomeDoArquivo = $"dados-pessoa-{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }
}