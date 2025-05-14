using System.Text.Json;

// List<Pessoa> pessoas = new List<Pessoa>();
// Console.WriteLine("--- Cadastro de Pessoas ---");

// string resposta = "";

// do
// {
//     Console.WriteLine("Digite o nome: ");
//     string nome = Console.ReadLine()!;

//     Console.WriteLine("Digite a idade: ");
//     int idade = int.Parse(Console.ReadLine()!);

//     Console.WriteLine("Digite o email: ");
//     string email = Console.ReadLine()!;

//     Pessoa pessoa = new Pessoa(nome, idade, email);

//     pessoas.Add(pessoa);

//     Console.WriteLine("Deseja adicionar outra pessoa? [S/N]");
//     resposta = Console.ReadLine()!.ToUpper();


// } while (resposta != "N");

// string jsonString = JsonSerializer.Serialize(pessoas);

// string nomeArquivo = "pessoas.json";

// File.WriteAllText(nomeArquivo, jsonString);

// Console.WriteLine($"Os dados foram salvos em {nomeArquivo}");

try
{
    string caminhoArquivo = @"C:\Users\bruno\Desktop\CSharp\alura\consumindoApiGravandoArquivosLinq\Exercicios\pessoas.json";
    if (!File.Exists(caminhoArquivo))
    {
        Console.WriteLine("Arquivo não encontrado!");
        return;
    }

    string conteudoJson = File.ReadAllText(caminhoArquivo);

    var pessoas = JsonSerializer.Deserialize<List<Pessoa>>(conteudoJson);

    Console.WriteLine("Digite a idade das pessoas que deseja buscar: ");
    int idadeParaBuscar = int.Parse(Console.ReadLine()!);

    var pessoasComIdade = pessoas.Where(pessoa => pessoa.Idade == idadeParaBuscar).ToList();

    foreach (var pessoa in pessoasComIdade)
    {
        Console.WriteLine($"Nome: {pessoa.Nome}");
        Console.WriteLine($"Idade: {pessoa.Idade}");
        Console.WriteLine($"Email: {pessoa.Email}");
        Console.WriteLine();
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

// try
// {
//     string caminhoArquivo = @"C:\Users\bruno\Desktop\CSharp\alura\consumindoApiGravandoArquivosLinq\Exercicios\dados-pessoa-Bruno.json";
//     if (!File.Exists(caminhoArquivo))
//     {
//         Console.WriteLine("Arquivo não encontrado!");
//         return;
//     }

//     string conteudoJson = File.ReadAllText(caminhoArquivo);

//     var pessoa = JsonSerializer.Deserialize<Pessoa>(conteudoJson);

//     Console.WriteLine($"Nome: {pessoa.Nome}");
//     Console.WriteLine($"Idade: {pessoa.Idade}");
//     Console.WriteLine($"Email: {pessoa.Email}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }

// List<int> inteiros = new List<int> { 1, 2, 3, };

// var numerosPares = inteiros.Where(numerosPares => numerosPares % 2 == 0);
// Console.WriteLine("Numeros pares:");
// foreach (var pares in numerosPares)
// {
//     Console.WriteLine(pares);
// }


// List<Produto> produtos = new List<Produto>
// {
//     new Produto { Nome = "Processador", Preco = 2500 },
//     new Produto { Nome = "Placa de Vídeo", Preco = 4200 },
//     new Produto { Nome = "Memória RAM 16GB", Preco = 600 },
//     new Produto { Nome = "SSD 1TB", Preco = 750 },
//     new Produto { Nome = "Fonte 750W", Preco = 550 }
// };

// decimal precoMedio = produtos.Average(produtos => produtos.Preco);

// Console.WriteLine($"Preco medio dos produtos = {precoMedio}");


// List<Livro> livros = new List<Livro>
// {
//     new Livro { Titulo = "A Cabana", Autor = "Bruno", AnoPublicacao = 2005 },
//     new Livro { Titulo = "1984", Autor = "George Orwell", AnoPublicacao = 2003 },
//     new Livro { Titulo = "Dom Casmurro", Autor = "Machado de Assis", AnoPublicacao = 2001 },
//     new Livro { Titulo = "O Alquimista", Autor = "Paulo Coelho", AnoPublicacao = 2002 },
//     new Livro { Titulo = "O Senhor dos Anéis", Autor = "J.R.R. Tolkien", AnoPublicacao = 2010 }
// };

// var LivrosPublicadosAposAno2000 = livros.Where(livro => livro.AnoPublicacao > 2000).OrderBy(livro => livro.Titulo).ToList();

// Console.WriteLine("Livros publicados apos os anos 2000: ");
// foreach (var livro in LivrosPublicadosAposAno2000)
// {
//     Console.WriteLine($"- {livro.Titulo}");
// }

// List<int> numeros = new List<int> { 1, 2, 3, 3, 3, 3, 3 };

// var unicos = numeros.Distinct();

// Console.WriteLine("Numeros unicos");
// foreach (int numero in unicos)
// {
//     Console.WriteLine(numero);
// }


// try
// {
//     List<string> lista = new();
//     lista[-1] = "";
// }
// catch (Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }


// try
// {
//     Console.WriteLine("Digite o numero1: ");
//     int numero1 = int.Parse(Console.ReadLine()!);
//     Console.WriteLine("Digite o numero2: ");
//     int numero2 = int.Parse(Console.ReadLine()!);

//     int resposta = numero1 / numero2;
// }
// catch (Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }

// using (HttpClient client = new HttpClient())
// {
//     string resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
//     Console.WriteLine(resposta);
// }