abstract class Funcionario
{
    public string? Nome { get; set; }
    public double Salario { get; set; }

    public Funcionario(string nome, double salario)
    {
        Nome = nome;
        Salario = salario;
    }

    public abstract double calcularBonificacao();

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Salário: {Salario}");
        Console.WriteLine($"Bonificação: {calcularBonificacao()}");
    }
}