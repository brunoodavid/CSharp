class Carro : Veiculo
{
    public string? Motor;

    public override void ExibirDetalhes()
    {
        base.ExibirDetalhes();
        Console.WriteLine(Motor);
    }
}