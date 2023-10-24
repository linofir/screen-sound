using System.Runtime.CompilerServices;
using System.Text.Json;
using ScreenSound.Filter;

namespace ScreenSound.Modules;

internal class SelectedSongs
{
    public string? User { get; set; }
    public string? Name { get; set; }
    public List<Song>? songList = new();

    public SelectedSongs(string usuario, string nome )
    {
        Name = nome;
        User = usuario;

    }

    public void AddLikedSong(Song song)
    {
        songList!.Add(song);
        Console.WriteLine($"Você adicionou {song.Name} ");
    }

    public void PrintLikedSongs()
    {
        Console.WriteLine($"\nEssas são suas músicas favoritas da lista {Name}: ");
        foreach( var song in songList!)
        {
            Console.WriteLine(song.Description);
        }
    }

    public void CreateJsonFile()
    {
        string json = JsonSerializer.Serialize(new
        {
            usuario = User,
            nome = Name,
            musicas = songList

        });
        string fileName = $"{User}-{Name}.json";

        File.WriteAllText(fileName,json);
        Console.WriteLine($"o arquivo {fileName} foi criado com sucesso no {Path.GetFullPath(fileName)}") ;
    }
    
}