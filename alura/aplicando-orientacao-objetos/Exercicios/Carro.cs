class Carro
{
    public string? Fabricante { get; set; }
    public string? Modelo { get; set; }
    private int _ano;
    public int Ano
    {
        get { return _ano; }
        set
        {
            if (value >= 1960 && value >= 2023)
            {
                _ano = value;
            }
            else
            {
                Console.WriteLine("Digite um ano válido entre 1960 e 2023");
            }
        }
    }
    public int Velocidade { get; set; } = 0;
    public string? DescricaoDetalhada { get => $"O Fabricante do carro é {this.Fabricante} com o modelo {this.Modelo} e o ano {this.Ano}"; }
    public void Acelerar()
    {
        Console.WriteLine("Acelerando...");
        if (Velocidade < 100)
        {
            Velocidade += 5;
        }
    }
    public void Frear()
    {
        Console.WriteLine("Freando...");
        if (Velocidade > 0)
        {
            Velocidade -= 5;
        }
    }
    public void Buzinar()
    {
        Console.WriteLine("Bi Bi");
    }
}