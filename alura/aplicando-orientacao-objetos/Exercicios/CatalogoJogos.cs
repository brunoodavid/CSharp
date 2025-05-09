class CatalogoJogos
{
    public CatalogoJogos(string? nomeJogos, List<string>? listaJogos)
    {
        NomeJogos = nomeJogos;
        ListaJogos = listaJogos;
    }

    public string? NomeJogos { get; set; }
    public List<string>? ListaJogos { get; set; }

    public void AdicionarJogo(string jogo)
    {
        ListaJogos!.Add(jogo);
    }

    public void RemoverJogo(string jogo)
    {
        ListaJogos!.Remove(jogo);
    }

}