using System;
using System.Text.RegularExpressions;

namespace EditorHtml
{
    public static class Visualizador
    {
        public static void Mostrar(string texto)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("-------------");
            Trocar(texto);
            Console.WriteLine("-------------");
            Console.ReadKey();
            Menu.Mostrar();
        }

        public static void Trocar(string texto)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var palavras = texto.Split(' ');

            for (int i = 0; i < palavras.Length; i++)
            {
                if (strong.IsMatch(palavras[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(
                        palavras[i].Substring(
                            palavras[i].IndexOf('>') + 1,
                            ((palavras[i].LastIndexOf('<') - 1) - palavras[i].IndexOf('>'))

                        )
                    );
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(palavras[i]);
                    Console.Write(" ");
                }
            }
        }
    }
}