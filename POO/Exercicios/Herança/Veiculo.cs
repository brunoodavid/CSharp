class Veiculo
{
    public string? Marca;
    public string? Modelo;
    public int Ano;

    public virtual void ExibirDetalhes()
    {
        Console.WriteLine($"{Marca}");
        Console.WriteLine($"{Modelo}");
        Console.WriteLine($"{Ano}");
    }
}