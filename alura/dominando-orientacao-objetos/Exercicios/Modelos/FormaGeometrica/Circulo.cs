class Circulo : FormaGeometrica
{
    public double Raio { get; set; }

    public Circulo(double raio)
    {
        Raio = raio;
    }

    public override void Area()
    {
        double area = Math.PI * Math.Pow(Raio, 2);
        Console.WriteLine($"A area do circulo é {area}");
    }

    public override void Perimetro()
    {
        double perimetro = 2 * Math.PI * Raio;
        Console.WriteLine($"O perimetro do circulo é {perimetro}");
    }
}