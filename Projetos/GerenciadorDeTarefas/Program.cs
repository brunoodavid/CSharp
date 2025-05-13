var tarefa = new Tarefa();
var gerenciador = new GerenciadorDeTarefas();
gerenciador.Carregar();
var executando = true;

while (executando)
{
    Console.WriteLine("------------- Gerenciador de Tarefas -------------");
    Console.WriteLine("1 - Adicionar Tarefa");
    Console.WriteLine("2 - Listar Tarefa");
    Console.WriteLine("3 - Concluir Tarefa");
    Console.WriteLine("4 - Remover Tarefa");
    Console.WriteLine("0 - Sair");
    Console.Write("Digite a opção desejada: ");
    int op = int.Parse(Console.ReadLine()!);

    switch (op)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("Digite o titulo da tarefa: ");
            string titulo = Console.ReadLine()!;

            Console.WriteLine("Digite a descrição da tarefa: ");
            string descricao = Console.ReadLine()!;

            gerenciador.AdicionarTarefa(titulo, descricao);
            break;

        case 2:
            Console.Clear();
            gerenciador.ListarTodasAsTarefas();
            break;
        case 3:
            Console.Clear();
            gerenciador.ListarTodasAsTarefas();
            Console.WriteLine("Digite o ID da tarefa para concluir: ");
            int idConcluir = int.Parse(Console.ReadLine()!);
            gerenciador.MarcarTarefaComoConcluida(idConcluir);
            break;
        case 4:
            Console.Clear();
            gerenciador.ListarTodasAsTarefas();
            Console.WriteLine("Digite o ID da tarefa para remover: ");
            int idRemover = int.Parse(Console.ReadLine()!);
            gerenciador.RemoverTarefaDaLista(idRemover);
            break;
        case 0:
            gerenciador.Salvar();
            Console.WriteLine("Saindo do programa!");
            executando = false;
            break;
        default: Console.WriteLine("Digite uma opção valida!"); break;

    }
}

