namespace Alura.Filmes;

class Artista
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<Filme> FilmesAtuados { get; set; } = new();

    public void AdicionarFilme(Filme filme)
    {
        if (!FilmesAtuados.Contains(filme))
        {
            FilmesAtuados.Add(filme);
            filme.AdicionarArtista(this);
        }
    }


}
