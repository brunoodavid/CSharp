class Programador : Funcionario
{
    public string? Linguagem { get; set; }

    public override void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"Linguagem escolhida é: {Linguagem}");
    }
}