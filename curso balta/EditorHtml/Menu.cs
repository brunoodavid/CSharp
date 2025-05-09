using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Mostrar()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DesenharTela();
            mostrarOpcoes();

            var opcao = short.Parse(Console.ReadLine());

            executarOpcaoMenu(opcao);
        }

        public static void DesenharTela()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.WriteLine();

            for (int linhas = 0; linhas <= 10; linhas++)
            {
                Console.Write("|");

                for (int i = 0; i <= 30; i++)
                {
                    Console.Write(" ");
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.WriteLine();
        }

        public static void mostrarOpcoes()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo: ");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

        public static void executarOpcaoMenu(short opcao)
        {
            switch (opcao)
            {
                case 1:
                    Editor.Mostrar(); break;
                case 2:
                    Console.WriteLine("Visualizador"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Mostrar(); break;
            }
        }
    }
}