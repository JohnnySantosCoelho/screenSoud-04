using ScreenSoud_04.Modelos;
using System.Text.Json;
using ScreenSoud_04.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarMusicasEmCSharp(musicas);


        //musicas[5].ExibirDetalheDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistaOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGenerosMusical(musicas,"pop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
        //LinqFilter.FiltrarMusicasPeloAno(musicas, 2012);


        //var musicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[377]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1467]);

        //musicasPreferidasDoDaniel.ExibirMusicasFavoritas();

        //var musicasPreferidasJohnny = new MusicasPreferidas("Johnny");

        //musicasPreferidasJohnny.AdicionarMusicasFavoritas(musicas[135]);
        //musicasPreferidasJohnny.AdicionarMusicasFavoritas(musicas[801]);
        //musicasPreferidasJohnny.AdicionarMusicasFavoritas(musicas[586]);
        //musicasPreferidasJohnny.AdicionarMusicasFavoritas(musicas[22]);
        //musicasPreferidasJohnny.AdicionarMusicasFavoritas(musicas[327]);

        //musicasPreferidasJohnny.ExibirMusicasFavoritas();

        //musicasPreferidasJohnny.GerarArquivoJson();


        

    }
    catch (Exception ex) 
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
    
}