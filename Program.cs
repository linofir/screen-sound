//Screen Sound
using System.Text.Json;
using ScreenSound.Filter;
using ScreenSound.Menus;
using ScreenSound.Modules;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await  client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Song>>(resposta)!;
        //Console.WriteLine($"Número toral de músicas é {musicas.Count}");
        //LinqFilter.FilterGenre(musicas);
        //LinqOrder.OrderArtists(musicas);

        // Console.Write("Digite o genero que gostaria de saber os artistas: ");
        // string generoEscolhido = Console.ReadLine()!;
        // LinqFilter.FilterArtistsByGenre(musicas,generoEscolhido);

        // Console.Write("Digite o artista que gostaria de saber as músicas: ");
        // string artistaEscolhido = Console.ReadLine()!;
        // LinqFilter.FilterMusicsByArtist(musicas, artistaEscolhido);

        List<string> listaTest = new(){"Adventure of a Lifetime", "Ai Se Eu Te Pego - Live", "All The Small Things", "All You Wanted", "Ayo Technology", "Bad Blood" };
        //"BURN IT DOWN"
        Console.Write("Digite a música que gostaria de adicionar as favoritas: ");
        string musicaEscolhida = Console.ReadLine()!;

        SelectedSongs minhaLista = new("Curtidas","Lino");

        foreach(var musicasTeste in listaTest)
        {
            LinqFilter.FilterMusicToAdd(musicas, musicasTeste, minhaLista);

        }

        LinqFilter.FilterMusicToAdd(musicas, musicaEscolhida, minhaLista);


        minhaLista.PrintLikedSongs();
        //minhaLista.CreateJsonFile();

        Console.Write("Digite a tonalidade das músicas que gostaria: ");
        string tonalidadeEscolhida = Console.ReadLine()!;
        LinqFilter.FilterByTune(musicas,tonalidadeEscolhida);

    }
    catch(Exception ex){
        Console.WriteLine($"Existe um erro: {ex.Message}");
    }
}



Bandas bandasLista = new Bandas();

Banda banda = new Banda("queen");
bandasLista.AddBanda(banda);

Album album = new Album("A night of Opera");
banda.AddAlbum(album);

Musica musica = new Musica(banda, "history of my life")
{
    Duracao = 213,
    Disponibilidade = true
};

Musica musica2 = new Musica(banda, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponibilidade = false
};


album.AddMusica(musica);
album.AddMusica(musica2);

Menu menu = new();
//menu.ExibirMenu(bandasLista);

