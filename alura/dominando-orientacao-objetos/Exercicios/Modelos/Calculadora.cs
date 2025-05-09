class Calculadora
{
    public static void Calcular(int numero1, int numero2, string sinal)
    {
        if (sinal == "+")
        {
            int resultado = numero1 + numero2;
            Console.WriteLine($"{numero1} + {numero2} é {resultado}");
        }
        if (sinal == "-")
        {
            int resultado = numero1 - numero2;
            Console.WriteLine($"{numero1} - {numero2} é {resultado}");
        }
        if (sinal == "*")
        {
            int resultado = numero1 * numero2;
            Console.WriteLine($"{numero1} * {numero2} é {resultado}");
        }
        if (sinal == "/")
        {
            if (numero2 == 0)
            {
                Console.WriteLine("Erro: divisão por zero.");
            }
            else
            {
                int resultado = numero1 / numero2;
                Console.WriteLine($"{numero1} / {numero2} é {resultado}");
            }
        }
        if (sinal == "potencia")
        {
            double resultado = Math.Pow(numero1, numero2);
            Console.WriteLine($"{numero1} potencia de {numero2} é {resultado}");
        }
    }
    public void Calcular(int numero, string sinal)
    {
        if (sinal == "raiz quadrada")
        {
            if (numero < 0)
            {
                Console.WriteLine("Erro: não é possível calcular a raiz de número negativo.");
                return;
            }
            double resultado = Math.Sqrt(numero);
            Console.WriteLine($"raiz quadrada de {numero} é {resultado}");
        }
    }
}