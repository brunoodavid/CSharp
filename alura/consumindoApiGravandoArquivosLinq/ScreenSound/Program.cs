using System.Text.Json;

try
{
    using (HttpClient client = new HttpClient())
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
        //musicas[0].ExibirDetalhesDaMusica();
        foreach (var musica in musicas)
        {
            musica.ExibirTodasAsMusicasComC();
        }
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas!);
        //LinqOrder.ExibirListaDeArtistasOrdenado(musicas!);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Zedd");
        //LinqFilter.FiltrarMusicasPorAno(musicas, "2012");
        // var musicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
        // musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
        // musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[377]);
        // musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[4]);
        // musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[6]);
        // musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1467]);
        // musicasPreferidasDoDaniel.ExibirMusicasFavoridas();
        // musicasPreferidasDoDaniel.GerarArquivoJson();

    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}