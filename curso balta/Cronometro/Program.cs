static void Iniciar(int tempo)
{
    int tempoAtual = 0;

    while (tempoAtual != tempo)
    {
        Console.Clear();
        tempoAtual++;
        Console.WriteLine(tempoAtual);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("Cronometro finalizando..");
    Thread.Sleep(2500);
    Menu();
}

static void Menu()
{
    Console.Clear();
    Console.WriteLine("S = Segundos => 10s = 10 segundos");
    Console.WriteLine("M = Minutos => 1m = 1 minuto");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Quanto tempo deseja contar? ");
    string dados = Console.ReadLine().ToLower();

    char tipo = char.Parse(dados.Substring(dados.Length - 1, 1));
    int tempo = int.Parse(dados.Substring(0, dados.Length - 1));

    int multiplicador = 1;

    if (tipo == 'm')
        multiplicador = 60;

    if (tempo == 0)
        System.Environment.Exit(0);

    Iniciar(tempo * multiplicador);

}

Menu();