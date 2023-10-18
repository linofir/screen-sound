using ScreenSound.Modules;

namespace ScreenSound.Menus;

internal class MenuRegistrarAlbum : Menu
{
    public override void Executar(Bandas bandasLista)
    {
        base.Executar(bandasLista);
        ExibirCabecalho("Avalie as Bandas");

        Console.WriteLine("Deseja adicionar um album para qual banda");
        string bandaEscolhida = Console.ReadLine()!;
        Banda bandaEncontrada = bandasLista.ConfereBanda(bandaEscolhida);
        if(bandaEncontrada != null)
        {
            Console.Write($"Digite o nome do Album da banda {bandaEncontrada.Nome}: ");
            Album novoAlbum = new(Console.ReadLine()!);
            bandaEncontrada.AddAlbum(novoAlbum);
            bandaEncontrada.ExbirDiscografia();
            Console.Write("Deseja incluir músicas nesse algum?(s/n)");
            string opcaoEscolhida = Console.ReadLine()!;

            if(opcaoEscolhida == "s" )
            {
                RegistraMusica(bandaEncontrada, novoAlbum);
                Console.WriteLine("Digite qualquer tecla para retornar");
                Console.ReadKey();
                ExibirMenu(bandasLista);

            }else
            {
                Thread.Sleep(2000);
                ExibirMenu(bandasLista);
            }

        }else
        {
            Console.WriteLine($"A {bandaEscolhida} não existe");
            Thread.Sleep(2000);
            ExibirMenu(bandasLista);
        }
    }

    public void RegistraMusica(Banda bandaEncontrada, Album novoAlbum)
    {
        Console.Write("Digite o nome da música ");
        string nomeEscolhido = Console.ReadLine()!;
        Musica novaMusica = new(bandaEncontrada, nomeEscolhido);
        Console.Write("Digite a duração dessa música: ");
        novaMusica.Duracao = int.Parse(Console.ReadLine()!);
        novaMusica.Disponibilidade = true;

        novoAlbum.AddMusica(novaMusica);
        novoAlbum.ExibirMusicas();
    }
}