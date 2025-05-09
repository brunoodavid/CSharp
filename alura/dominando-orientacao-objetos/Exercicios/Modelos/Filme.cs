namespace Alura.Filmes;
class Filme
{
    public string? Titulo { get; set; }
    public int Duracao { get; set; }
    public List<Artista> Elenco { get; set; } = new();

    public Filme(string titulo)
    {
        Titulo = titulo;
    }

    public void AdicionarArtista(Artista artista)
    {
        if (!Elenco.Contains(artista))
        {
            Elenco.Add(artista);
            artista.AdicionarFilme(this);
        }
    }
}