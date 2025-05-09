class Carro
{
    public string? Marca { get; set; }
    public string? Modelo { get; set; }
    public int Ano { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"{Marca}");
        Console.WriteLine($"{Modelo}");
        Console.WriteLine($"{Ano}");
    }
}