class Funcionario
{
    public string? Nome { get; set; }
    public double Salario { get; set; }

    public virtual void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Salario: {Salario}");
    }
}