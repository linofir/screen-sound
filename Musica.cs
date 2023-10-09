
using System.ComponentModel;
using System.Dynamic;

class Musica
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
    public string Descricao => $"A música {Nome} pertence ao artista {Artista} ";

    public void ExibirInformacoes()
    {
        Console.WriteLine(Descricao);
        Console.WriteLine($"Nome:{Nome}");
        Console.WriteLine($"Artista:{Artista}");
        Console.WriteLine($"Duração:{Duracao}s");
        if(Disponibilidade)
        {
            Console.WriteLine($"Essa música está disponível");
        }else Console.WriteLine("Música indisponível");
    }
}

