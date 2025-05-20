using System.Collections;
using System.Runtime.CompilerServices;
using bytebank.Modelos.Conta;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region Exemplos de Arrays em C#
//TestaArrayInt();
//TestaArrayString();


void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine($"Tamanho do array {idades.Length}");

    int acumulador = 0;

    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"índice [{i}] = {idade}");
        acumulador += idade;
    }

    int media = acumulador / idades.Length;
    Console.WriteLine($"Média de idades = {media}");
}

void TestaArrayString()

{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite a {i + 1}ª palavra: ");
        arrayDePalavras[i] = Console.ReadLine()!;
    }

    Console.Write("Digite a palavra a ser encontrada: ");
    string palavraEncontrada = Console.ReadLine()!;

    bool encontrada = false;

    foreach (var palavra in arrayDePalavras)
    {
        if (palavra.Equals(palavraEncontrada))
        {
            encontrada = true;
            break;
        }
    }

    if (encontrada)
    {
        Console.WriteLine("Palavra encontrada!");
    }
    else
    {
        Console.WriteLine("Palavra não encontrada!");
    }
}

Array amostra = Array.CreateInstance(typeof(double), 4);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);

//TestaMediana(amostra);

void TestaMediana(Array array)
{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
    }

    double[] numerosOrdenados = (double[])array.Clone();
    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;

    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
}

//TestaMedia((double[])amostra);

void TestaMedia(double[] numeros)
{
    double acumulador = 0;
    int tamanhoArray = numeros.Length;

    for (int i = 0; i < tamanhoArray; i++)
    {
        acumulador += numeros[i];
    }

    double media = acumulador / tamanhoArray;

    Console.WriteLine($"A média do array é = {media}");
}

void TestaArrayDeContasCorrentes()
{
    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    // listaDeContas.AdicionarConta(new ContaCorrente(874, "5679787-A")
    // {
    //     Saldo = 1500,
    //     Titular = new Cliente
    //     {
    //         Nome = "Joao"
    //     }
    // });
    // listaDeContas.AdicionarConta(new ContaCorrente(874, "4456668-B")
    // {
    //     Saldo = 3500,
    //     Titular = new Cliente
    //     {
    //         Nome = "Marcelo"
    //     }
    // });
    // listaDeContas.AdicionarConta(new ContaCorrente(874, "7781438-C")
    // {
    //     Saldo = 2500,
    //     Titular = new Cliente
    //     {
    //         Nome = "Bruno"
    //     }
    // });

    listaDeContas.AdicionarConta(new ContaCorrente(874));
    listaDeContas.AdicionarConta(new ContaCorrente(874));
    listaDeContas.AdicionarConta(new ContaCorrente(874));
    listaDeContas.AdicionarConta(new ContaCorrente(874));
    listaDeContas.AdicionarConta(new ContaCorrente(874));
    listaDeContas.AdicionarConta(new ContaCorrente(874));
    var contaDoAndre = new ContaCorrente(963);
    listaDeContas.AdicionarConta(contaDoAndre);
    // listaDeContas.ExibeLista();
    // Console.WriteLine("============");
    // listaDeContas.Remover(contaDoAndre);
    // listaDeContas.ExibeLista();

    //listaDeContas.MaiorSaldoDeContasCorrentes();+

    for (int i = 0; i < listaDeContas.Tamanho; i++)
    {
        ContaCorrente conta = listaDeContas[i];
        Console.WriteLine($"Indice [{i}] = {conta.Conta}/{conta.Numero_agencia}");
    }

}

//TestaArrayDeContasCorrentes();

#endregion

new byteBankAtendimentos().AtendimentoCliente();
