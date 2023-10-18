using ScreenSound.Modules;

namespace ScreenSound.Menus;

internal class MenuExibirMediaAlbum : Menu
{
    public override void Executar(Bandas bandasLista)
    {
        base.Executar(bandasLista);
        ExibirCabecalho("Avalie os Albuns");

        RegistraNotaAlbum(bandasLista);    
    }

    public void RegistraNotaAlbum(Bandas bandasLista)
    {
        Console.Write("De qual banda deseja avaliar o Album?");
        string bandaEscolhida = Console.ReadLine()!;
        Banda bandaEncontrada = bandasLista.ConfereBanda(bandaEscolhida);
    
        if( bandaEncontrada != null)
        {
            Console.Write($"Digite o nome do Album da banda {bandaEncontrada.Nome}: ");
            string albumEscolhido = Console.ReadLine()!;
            Album albumEncontrado = bandaEncontrada.ConfereAlbum(albumEscolhido);
            if(albumEncontrado != null)
            {
                Console.Write($"\nQual sua nota para a banda {albumEncontrado.Nome}?");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                Console.WriteLine($"O {albumEncontrado.Nome} recebeu a nota: {nota.Nota}");
                albumEncontrado.AddNota(nota);
                albumEncontrado.ExibeNotas();
                Console.Write("Deseja ver a média desse album?(s/n)");
                string opcaoFinal = Console.ReadLine()!;
                if(opcaoFinal == "s")
                {
                    albumEncontrado.ExibirMedia();
                    Console.WriteLine("Digite qualquer tecla para retornar");
                    Console.ReadKey();
                    ExibirMenu(bandasLista);
                }else{
                    Thread.Sleep(2000);
                    ExibirMenu(bandasLista);
                }
            }else
            {
                Console.WriteLine($"A {albumEscolhido} não existe");
                Thread.Sleep(2000);
                ExibirMenu(bandasLista);
            }
        }else 
        {
        Console.WriteLine($"A {bandaEscolhida} não existe");
        Thread.Sleep(2000);
        ExibirMenu(bandasLista);
        };
    }
}
