class Album
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
        foreach ( var musica  in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }

        Console.WriteLine($"Para o album {Nome} o tempo total de duração é: {DuracaoTotal}");
    }
}