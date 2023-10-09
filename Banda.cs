using System.Security.Cryptography;

class Banda
{
    public Banda(string banda){
        Nome = banda;

    }
    private List<Album> albuns= new List<Album>();
    public string Nome { get; set; }


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
}