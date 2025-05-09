class Conta
{
    public Titular? Titular { get; set; }
    public int Agencia { get; set; }
    public int NumeroConta { get; set; }
    public double Saldo { get; set; }
    public double Limite { get; set; }
    public string? Senha { get; set; }

    public Conta()
    {

    }

    public Conta(Titular titular, int agencia, int numeroConta, double saldo, double limite, string? senha)
    {
        Titular = titular;
        Agencia = agencia;
        NumeroConta = numeroConta;
        Saldo = saldo;
        Limite = limite;
        Senha = senha;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Titular: {Titular!.Nome}");
        Console.WriteLine($"Agencia: {Agencia}");
        Console.WriteLine($"Numero da conta: {NumeroConta}");
        Console.WriteLine($"Saldo: {Saldo}");
        Console.WriteLine($"Limite: {Limite}");
    }

}