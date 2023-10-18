namespace ScreenSound.Modules;
using System.ComponentModel;
using System.Security.Cryptography;
using ScreenSound.Modules;

internal class Banda : IAvaliacao
{
    public Banda(string banda){
        Nome = banda;

    }
    private List<Album> albuns= new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();

    public int Nota { get; set; }   
    public string Nome { get; set; }
    
    public void ExibirMedia()
    {
        double media =  notas.Average(a => a.Nota);
        Console.WriteLine($"A média da {Nome} é {media}");
    }


    public void AddAlbum(Album album)
    {
        albuns.Add(album);
    }
    public void ExbirDiscografia()
    {
        Console.WriteLine($"A banda {Nome} tem os seguintes albuns");
        int counter = 0;
        foreach (var album in albuns)
        {
            counter +=1;
            Console.WriteLine($"{counter}: {album.Nome}({album.DuracaoTotal}s)\n");
            Console.WriteLine($"As Músicas do {album.Nome} são: ");
            album.ExibirMusicas();
            
        }
    }

    public void AddNota(Avaliacao nota)
    {
        notas.Add(nota);
        
    }
    public void ExibeNotas()
    {
        int contador = 0;
        Console.WriteLine($"notas da banda {Nome}:\n");
        foreach (var nota in notas)
        {   
            contador += 1;
            Console.WriteLine($"Nota {contador}: {nota.Nota}");
            
        }
    }

    public List<Avaliacao> RetornaLista()
    {
        return notas;
    }

     public Album ConfereAlbum(string albumEscolhido)
    {
        Album albumEncontrado = albuns.Find(album => album.Nome == albumEscolhido)!;
        return  albumEncontrado;
    }
    
    

    
}