namespace ScreenSound.Modules;
using System.ComponentModel;
using System.Dynamic;

internal class Musica
{
    public Musica(Banda banda, string nome)
    {
        Artista = banda;
        Nome = nome;
    }
    public string Nome { get; }
    public Banda Artista {get; }
    public int Duracao { set ;get; }
    public bool Disponibilidade { set ;get; }
    public string Descricao => $"A música {Nome} pertence ao artista {Artista.Nome} ";

    public void ExibirInformacoes()
    {
        Console.WriteLine(Descricao);
        Console.WriteLine($"Nome:{Nome}");
        Console.WriteLine($"Artista:{Artista.Nome}");
        Console.WriteLine($"Duração:{Duracao}s");
        if(Disponibilidade)
        {
            Console.WriteLine($"Essa música está disponível\n");
        }else Console.WriteLine("Música indisponível\n");
    }
}

