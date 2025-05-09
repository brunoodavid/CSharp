class Analista : Funcionario
{
    public string? AreaAtuacao { get; set; }

    public override void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"Are de atuacao: {AreaAtuacao}");
    }
}