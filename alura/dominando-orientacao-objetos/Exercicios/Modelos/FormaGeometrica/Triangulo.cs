class Triangulo : FormaGeometrica
{
    public double LadoA { get; set; }
    public double LadoB { get; set; }
    public double LadoC { get; set; }

    public Triangulo(double ladoA, double ladoB, double ladoC)
    {
        LadoA = ladoA;
        LadoB = ladoB;
        LadoC = ladoC;
    }

    public override void Area()
    {
        double soma = (LadoA + LadoB + LadoC) / 2;
        double area = Math.Sqrt(soma * (soma - LadoA) * (soma - LadoB) * (soma - LadoC));
        Console.WriteLine($"A área do triangulo de 3 lados é {area}");
    }

    public override void Perimetro()
    {
        double perimetro = LadoA + LadoB + LadoC;
        Console.WriteLine($"O Perimetro do triangulo é {perimetro}");
    }
}