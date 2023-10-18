using ScreenSound.Menus;

namespace ScreenSound.Modules;
internal class Album : IAvaliacao
{   
    private List<Musica> musicas = new List<Musica>();
    private List<Avaliacao> notas = new List<Avaliacao>();
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
        int counter = 0;
        foreach ( var musica  in musicas)
        {
            counter += 1;
            Console.WriteLine($"Música-{counter}: {musica.Nome} ");
            Console.WriteLine($"Informações: ");
            musica.ExibirInformacoes();
        }

        Console.WriteLine($"Para o album {Nome} o tempo total de duração é: {DuracaoTotal}");
    }

    public void AddNota(Avaliacao nota)
    {
        notas.Add(nota);
    }
    
    public void ExibirMedia()
    {
        double media = notas.Average(e => e.Nota);
        Console.WriteLine($"A média do {Nome} é {media}");
    }

    public void ExibeNotas()
    {
        int contador = 0;
        Console.WriteLine($"Notas do Album {Nome}:\n");
        foreach (var nota in notas)
        {   
            contador += 1;
            Console.WriteLine($"Nota {contador}: {nota.Nota}");
            
        }
    }
}