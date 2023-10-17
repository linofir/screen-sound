using ScreenSound.Modules;

namespace ScreenSound.Menus;

internal class MenuExibirInformacoes : Menu
{
    public void Executar(Bandas bandasLista)
    {
        Console.Clear();
        ExibirCabecalho("Músicas cadastradas");
        Console.Write("Qual banda você quer saber a média? ");
        string bandaEscolhida = Console.ReadLine()!;
        Banda bandaEncontrada = bandasLista.ConfereBanda(bandaEscolhida);

        if(bandaEncontrada != null)
        {
            bandaEncontrada.ExbirDiscografia();
            Thread.Sleep(2000);
            ExibirMenu(bandasLista);
        
        }else
        {
            Console.WriteLine("Banda não encontrada");
            Thread.Sleep(2000);
            ExibirMenu(bandasLista);
        }


    }
}