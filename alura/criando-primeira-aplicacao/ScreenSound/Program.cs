string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso" };
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 9 });
bandasRegistradas.Add("Avenged Sevenfold", new List<int>());


void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesMenu()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida)
    {
        case 1: RegistrarBanda(); break;
        case 2: MostrarBandasRegistradas(); break;
        case 3: AvaliarUmaBanda(); break;
        case 4: ExibirMediaDeUmaBanda(); break;
        case -1: break;
        default: Console.WriteLine("Digite um valor válido"); break;
    }
}


void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada");
    Thread.Sleep(2000);
    ExibirOpcoesMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Lista de bandas registradas:");

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal: ");
    Console.ReadKey();
    ExibirOpcoesMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asterisco = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asterisco);
    Console.WriteLine(titulo);
    Console.WriteLine(asterisco);
    Console.WriteLine();
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.Write("\nDigite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.Write($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(4000);
        ExibirOpcoesMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!\n");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        ExibirOpcoesMenu();
    }
}

void ExibirMediaDeUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir a média de uma banda");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine();
    Console.Write("Qual banda você deseja consultar a média: ");
    string nomeBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        foreach (var banda in bandasRegistradas)
        {
            double media = bandasRegistradas[banda.Key].Average();
            Console.WriteLine($"\nA média da banda {banda.Key} é {media}");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            ExibirOpcoesMenu();
        }
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada!\n");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        ExibirOpcoesMenu();
    }

}

ExibirOpcoesMenu();
