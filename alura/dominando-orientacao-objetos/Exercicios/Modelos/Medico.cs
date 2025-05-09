class Medico
{
    public string? Nome { get; set; }
    public string? CRMV { get; set; }
    public List<Consulta> Consultas { get; set; } = new();

    public void RealizarNovaConsulta(Consulta consulta)
    {
        Consultas.Add(consulta);
    }

    public void ListarConsultaDoMedico()
    {
        for (int i = 0; i < Consultas.Count; i++)
        {
            Console.WriteLine($"A {Consultas[i]}º Consulta foi: ");
            Console.WriteLine($"Data da consulta: {Consultas[i].Data}");
            Console.WriteLine($"Descrição do problema: {Consultas[i].DescricaoProblema}");
            Console.WriteLine($"Diagnóstico: {Consultas[i].Diagnostico}");
            Console.WriteLine($"Tratamento: {Consultas[i].Tratamento}");
            Console.WriteLine($"Nome do pet: {Consultas[i].Pet.Nome}");
            Console.WriteLine($"Médico: {Nome}");
            Console.WriteLine();
        }
    }

    public List<Consulta> FiltrarConsultaPorPet(string nomeDoPet)
    {
        List<Consulta> consultasFiltradas = new();

        foreach (var consulta in Consultas)
        {
            if (consulta.Pet.Nome == nomeDoPet)
            {
                consultasFiltradas.Add(consulta);
            }
        }

        return consultasFiltradas;
    }
}