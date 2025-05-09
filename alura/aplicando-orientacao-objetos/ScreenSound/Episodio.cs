class Episodio
{

    public string? Titulo { get; }
    public int Duracao { get; }
    public int Ordem { get; }
    public string? Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", ListaConvidados)}";
    public List<string> ListaConvidados = new();

    public Episodio(string? titulo, int duracao, int ordem)
    {
        Titulo = titulo;
        Duracao = duracao;
        Ordem = ordem;
    }


    public void AdicionarConvidados(string convidado)
    {
        ListaConvidados.Add(convidado);
    }
}