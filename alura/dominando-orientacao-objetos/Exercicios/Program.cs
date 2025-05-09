Gerente gerente = new Gerente
{
    Nome = "Bruno David",
    Salario = 5000,
    NumeroFuncionarios = 5,
};

gerente.ExibirDados();














// Triangulo triangulo = new(3, 4, 5);
// Circulo circulo = new(5);
// Quadrado quadrado = new(5);

// triangulo.Area();
// triangulo.Perimetro();

// circulo.Area();
// circulo.Perimetro();

// quadrado.Area();
// quadrado.Perimetro();












// // 1. Criar um Dono
// Dono dono = new Dono
// {
//     Nome = "Carlos",
//     Telefone = 123456789,
//     Endereco = "Rua das Flores, 123",
//     Cpf = "123.456.789-00"
// };

// // 2. Criar um Pet e associar ao dono
// Pet pet = new Pet
// {
//     Nome = "Rex",
//     Especie = "Cachorro",
//     Raca = "Labrador",
//     Idade = 5,
//     Peso = 25.4,
//     Dono = dono
// };

// dono.AdicionarPet(pet);

// // 3. Criar um Médico
// Medico medico = new Medico
// {
//     Nome = "Dra. Ana",
//     CRMV = "CRMV-001"
// };

// // 4. Criar uma Consulta associando pet e médico
// Consulta consulta = new Consulta
// {
//     Data = DateTime.Now,
//     DescricaoProblema = "Febre e cansaço",
//     Diagnostico = "Infecção viral",
//     Tratamento = "Antibióticos por 7 dias",
//     Pet = pet,
//     Medico = medico
// };

// // 5. Registrar a consulta no pet e no médico
// pet.RegistrarConsulta(consulta);
// medico.RealizarNovaConsulta(consulta);

// // 6. Usar os métodos para testar
// Console.WriteLine(">> Listar Pets do Dono:");
// dono.ListarPets();

// Console.WriteLine(">> Consultas do Pet:");
// pet.MostrarConsultas();

// Console.WriteLine(">> Consultas do Médico:");
// medico.ListarConsultaDoMedico();

// Console.WriteLine(">> Filtrar consultas por nome do pet:");
// var consultasFiltradas = medico.FiltrarConsultaPorPet("Rex");
// foreach (var c in consultasFiltradas)
// {
//     c.ExibirConsultas();
// }

