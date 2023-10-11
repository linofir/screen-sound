namespace ScreenSound.Modules;
internal class Album
{   
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get;}
    public int DuracaoTotal => musicas.Sum(musica => musica.Duracao );
    
    public void AddMusica(Musica musica)
    {
        musicas.Add(musica);

    }

    public void ExibirMusicas()
    {
        int counter =0;
        foreach ( var musica  in musicas)
        {
            counter += 1;
            Console.WriteLine($"Música-{counter}: {musica.Nome}");
        }

        Console.WriteLine($"Para o album {Nome} o tempo total de duração é: {DuracaoTotal}");
    }
}