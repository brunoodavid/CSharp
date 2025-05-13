using System.Text.Json;

class GerenciadorDeTarefas
{
    //public Tarefa Tarefa { get; set; }
    public List<Tarefa> ListaDeTarefa { get; set; } = new List<Tarefa>();

    public void AdicionarTarefa(string titulo, string descricao)
    {
        int novoId;
        if (ListaDeTarefa.Any())
        {
            novoId = ListaDeTarefa.Max(t => t.ID) + 1;
        }
        else
        {
            novoId = 1;
        }

        var tarefa = new Tarefa()
        {
            ID = novoId,
            Titulo = titulo,
            Descricao = descricao,
            EstaConcluida = false
        };

        ListaDeTarefa.Add(tarefa);
    }

    public void ListarTodasAsTarefas()
    {
        if (ListaDeTarefa.Any())
        {
            foreach (var tarefa in ListaDeTarefa)
            {
                Console.WriteLine($"Tarefa: {tarefa.ID}");
                Console.WriteLine($"Nome da tarefa: {tarefa.Titulo}");
                Console.WriteLine($"Descrição: {tarefa.Descricao}");
                Console.WriteLine($"Esta concluida: {(tarefa.EstaConcluida ? "Sim" : "Não")}");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Nenhuma tarefa cadastrada.");
            return;
        }

    }

    public void MarcarTarefaComoConcluida(int id)
    {
        var item = ListaDeTarefa.FirstOrDefault(item => item.ID == id);
        if (item != null)
        {
            item.EstaConcluida = true;
        }
    }

    public void RemoverTarefaDaLista(int id)
    {
        var tarefaParaRemover = ListaDeTarefa.FirstOrDefault(item => item.ID == id);

        if (tarefaParaRemover != null)
        {
            ListaDeTarefa.Remove(tarefaParaRemover);
            Console.WriteLine("Tarefa removida com sucesso!");
        }
        else
        {
            Console.WriteLine("Tarefa não encontrada.");
        }
    }

    public string CaminhoArquivo = $"tarefas.json";

    public void Salvar()
    {
        var json = JsonSerializer.Serialize(ListaDeTarefa, new JsonSerializerOptions { WriteIndented = true });


        File.WriteAllText(CaminhoArquivo, json);
        Console.WriteLine($"O arquivo json foi criado com sucesso! {Path.GetFullPath(CaminhoArquivo)}");

    }

    public void Carregar()
    {
        if (File.Exists(CaminhoArquivo))
        {
            var json = File.ReadAllText(CaminhoArquivo);
            ListaDeTarefa = JsonSerializer.Deserialize<List<Tarefa>>(json)!;
        }
        else
        {
            ListaDeTarefa = new List<Tarefa>();
        }
    }

}