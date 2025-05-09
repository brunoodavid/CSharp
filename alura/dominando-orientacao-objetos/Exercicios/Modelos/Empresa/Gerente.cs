class Gerente : Funcionario
{
    public int NumeroFuncionarios { get; set; }

    public override void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"O Numero de funcionarios é {NumeroFuncionarios}");
    }
}