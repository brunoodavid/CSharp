Random random = new Random();
int numeroAleatorio = random.Next(1, 100);

string opcao = "";

do
{
    Console.WriteLine("Digite um número: ");
    int numeroDigitado = int.Parse(Console.ReadLine()!);

    if (numeroDigitado == numeroAleatorio)
    {
        Console.WriteLine("Você acertou o numero, parabens! ");
    }
    else if (numeroDigitado > numeroAleatorio)
    {
        Console.WriteLine("O número digitado é maior que o numero aleatorio");
    }
    else
    {
        Console.WriteLine("O numero digitado é menor que o numero aleatorio" + numeroAleatorio);
    }

    Console.WriteLine("Deseja continuar? [S/N]");
    opcao = Console.ReadLine()!;
} while (opcao != "N");

