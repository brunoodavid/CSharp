static void Soma(double valor1, double valor2)
{
    double resultado = valor1 + valor2;
    Console.WriteLine(resultado);
    Console.ReadKey();
    Menu();
}

static void Subtracao(double valor1, double valor2)
{
    double resultado = valor1 - valor2;
    Console.WriteLine(resultado);
    Console.ReadKey();
    Menu();
}

static void Divisao(double valor1, double valor2)
{
    double resultado = valor1 / valor2;
    Console.WriteLine(resultado);
    Console.ReadKey();
    Menu();
}

static void Multiplicacao(double valor1, double valor2)
{
    double resultado = valor1 * valor2;
    Console.WriteLine(resultado);
    Console.ReadKey();
    Menu();
}

static void Menu()
{
    Console.WriteLine("Digite o primeiro valor: ");
    double valor1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor: ");
    double valor2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Opcões: ");
    Console.WriteLine("1 - Adição");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Sair");

    Console.WriteLine("Digite a opcão que você deseja: ");
    short op = short.Parse(Console.ReadLine());

    switch (op)
    {
        case 1: Soma(valor1, valor2); break;
        case 2: Subtracao(valor1, valor2); break;
        case 3: Multiplicacao(valor1, valor2); break;
        case 4: Divisao(valor1, valor2); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
    }
}

Menu();