namespace ScreenSound.Modules;
using System.ComponentModel;
using System.Security.Cryptography;
using ScreenSound.MOdules;

internal class Banda
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
        foreach (var album in albuns)
        {
            Console.WriteLine($"A {Nome} tem os albuns: {album.Nome}({album.DuracaoTotal}s)");
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
            Console.WriteLine($"Nota {contador}: {nota}");
            
        }
    }

    public List<Avaliacao> RetornaLista()
    {
        return notas;
    }

    
    

    
}