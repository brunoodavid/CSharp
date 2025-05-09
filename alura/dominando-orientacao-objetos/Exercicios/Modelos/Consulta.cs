class Consulta
{
    public DateTime Data { get; set; } = new();
    public string? DescricaoProblema { get; set; }
    public string? Diagnostico { get; set; }
    public string? Tratamento { get; set; }
    public Pet Pet { get; set; } = new();
    public Medico Medico { get; set; } = new();

    public void ExibirConsultas()
    {
        Console.WriteLine($"Data da consulta: {Data}");
        Console.WriteLine($"Descrição do problema: {DescricaoProblema}");
        Console.WriteLine($"Diagnóstico: {Diagnostico}");
        Console.WriteLine($"Tratamento: {Tratamento}");
        Console.WriteLine($"Pet: {Pet.Nome}");
        Console.WriteLine($"Médico: {Medico.Nome}");
        Console.WriteLine();
    }

    public void AtualizarDiagnostico(string diagnostico)
    {
        Diagnostico = diagnostico;
    }

}