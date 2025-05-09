class Pet
{
    public string? Nome { get; set; }
    public string? Especie { get; set; }
    public string? Raca { get; set; }
    public int Idade { get; set; }
    public double Peso { get; set; }
    public Dono Dono { get; set; } = new();
    public List<Consulta> Consultas { get; set; } = new();

    public void RegistrarConsulta(Consulta consulta)
    {
        Consultas.Add(consulta);
    }

    public void MostrarConsultas()
    {
        foreach (var consulta in Consultas)
        {
            Console.WriteLine($"Data da consulta: {consulta.Data}");
            Console.WriteLine($"Descrição do problema: {consulta.DescricaoProblema}");
            Console.WriteLine($"Diagnóstico: {consulta.Diagnostico}");
            Console.WriteLine($"Tratamento: {consulta.Tratamento}");
            Console.WriteLine($"Pet: {consulta.Pet.Nome}");
            Console.WriteLine($"Médico: {consulta.Medico.Nome}");
            Console.WriteLine();
        }
    }
}