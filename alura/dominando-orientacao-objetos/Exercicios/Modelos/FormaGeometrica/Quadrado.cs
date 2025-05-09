class Quadrado : FormaGeometrica
{
    public double Lado { get; set; }

    public Quadrado(double lado) => Lado = lado;
    public override void Area()
    {
        Console.WriteLine($"A area do quadrado é {Lado * Lado}");
    }

    public override void Perimetro()
    {
        Console.WriteLine($"O perimetro do quadrado é {4 * Lado}");
    }
}