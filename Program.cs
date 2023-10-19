//Screen Sound
using System.Text.Json;
using ScreenSound.Menus;
using ScreenSound.Modules;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await  client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Song>>(resposta)!;
        Console.WriteLine($"Número toral de músicas é {musicas.Count}");
        Console.WriteLine(musicas[0].Description);
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

