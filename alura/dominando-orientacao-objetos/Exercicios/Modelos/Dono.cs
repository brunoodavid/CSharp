class Dono
{
    public string? Nome { get; set; }
    public int Telefone { get; set; }
    public string? Endereco { get; set; }
    public string? Cpf { get; set; }
    public List<Pet> Pets { get; set; } = new();

    public void AdicionarPet(Pet pet)
    {
        Pets.Add(pet);

    }

    public void ListarPets()
    {
        for (int i = 0; i < Pets.Count; i++)
        {
            Console.WriteLine($"O {Pets[i]}º Pet é: {Pets[i].Nome} ");
            Console.WriteLine($"A especie é {Pets[i].Especie} ");
            Console.WriteLine($"A Raca é {Pets[i].Raca} ");
            Console.WriteLine($"A Idade é {Pets[i].Idade} ");
            Console.WriteLine($"O peso é {Pets[i].Peso} ");
            Console.WriteLine($"O dono é: {Pets[i].Dono.Nome}");
            Console.WriteLine();
        }
    }

}