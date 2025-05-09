//1 - Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.


using System.Net.Http.Headers;

void calculadora(double valor1, double valor2)
{
    double adicao = valor1 + valor2;
    double subtracao = valor1 - valor2;
    double multiplicação = valor1 * valor2;
    double divisao = valor1 / valor2;

    Console.WriteLine($"Adição: {adicao}");
    Console.WriteLine($"Subtração: {subtracao}");
    Console.WriteLine($"Multiplicação: {multiplicação}");
    Console.WriteLine($"Divisao: {divisao}");
}

//calculadora(5, 5);

//2 - Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida

List<string> bandas = new List<string> { "Linkin Park", "Avenged Sevenfold" };

//3 - Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console

// for (int i = 0; i < bandas.Count; i++)
// {
//     Console.WriteLine("Banda: " + bandas[i]);
// }

//4- Criar um programa que calcula a soma de todos os elementos inteiros em uma lista
// List<int> elementosInteiros = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
// int somaElementos = 0;
// for (int i = 0; i < elementosInteiros.Count; i++)
// {
//     somaElementos = somaElementos + elementosInteiros[i];
// }

// Console.WriteLine(somaElementos);

//5-Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.
// Dictionary<string, List<double>> notasAlunos = new Dictionary<string, List<double>> {
//     {"Bruno", new List<double> {4.5, 3.5,9.8}},
//     {"Luisa", new List<double> {5,8,9}}
// };
// double somaDasNotas = 0;
// double mediaNotas = 0;

// foreach (var aluno in notasAlunos)
// {
//     Console.WriteLine($"Notas do {aluno.Key}");
//     List<double> notas = aluno.Value;
//     foreach (double nota in notas)
//     {
//         Console.WriteLine(nota);
//         somaDasNotas = somaDasNotas + nota;
//     }

//     mediaNotas = somaDasNotas / notas.Count;
//     Console.WriteLine(notas.Count);
//     Console.WriteLine($"A média das notas é {mediaNotas}");
// }

//6-Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque
// Dictionary<string, int> produtos = new Dictionary<string, int>();
// produtos.Add("Processador", 5);
// produtos.Add("Placa de vídeo", 8);

// foreach (var produto in produtos)
// {
//     Console.WriteLine($"O produto {produto.Key} tem em estoque {produto.Value} unidades");
// }

//7-Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.
// Dictionary<string, string> questionario = new Dictionary<string, string>();

// questionario.Add("Qual a capital do Brasil?", "Brasilia");
// questionario.Add("Qual a formula da Água?", "H20");

// foreach (var item in questionario)
// {
//     Console.WriteLine(item.Key);
//     string resposta = Console.ReadLine()!;

//     if (resposta.Equals(item.Value, StringComparison.OrdinalIgnoreCase))
//     {
//         Console.WriteLine("Você acertou");
//     }
//     else
//     {
//         Console.WriteLine("Você errou!");
//     }
// }

// //8-Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas
// Dictionary<string, string> login = new Dictionary<string, string>();

// Console.Write("Digite o usuario: ");
// string nomeUsuario = Console.ReadLine()!;

// Console.Write("Digite a senha: ");
// string senha = Console.ReadLine()!;

// login.Add(nomeUsuario, senha);

// Dictionary<string, int> estoque = new Dictionary<string, int>
// {
//     { "camisetas", 50 },
//     { "calças", 30 },
//     { "tênis", 20 },
//     // Adicione mais produtos conforme necessário
// };

// string produto = "camisetas";

// if (estoque.ContainsKey(produto))
// {
//     Console.WriteLine($"Quantidade em estoque de {produto}: {estoque[produto]} unidades.");
// }
// else
// {
//     Console.WriteLine("Produto não encontrado no estoque.");
// }

//9-Com base na lista de super carros fornecida acima, onde a chave é o nome do carro e os valores são quantas vezes esse carro foi vendido por ano, calcule a média de uma chave específica.

// Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
//     { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
//     { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
//     { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
//     { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
//     { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
// };

// int soma = 0;
// double media = 0;

// foreach (var carro in vendasCarros)
// {
//     List<int> valores = carro.Value;
//     foreach (var valor in valores)
//     {
//         soma += valor;
//     }
//     media = soma / valores.Count;
//     Console.WriteLine($"A média do {carro.Key} é {media}");
// }
//como o instrutor fez
// double mediaBugattiVeyron = vendasCarros["Bugatti Veyron"].Average();
// Console.WriteLine(mediaBugattiVeyron);




