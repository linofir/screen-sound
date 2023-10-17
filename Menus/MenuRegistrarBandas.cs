using ScreenSound.Modules;

namespace ScreenSound.Menus;

internal class MenuRegistrarBandas : Menu
{
    public void Executar(Bandas bandasLista)
    {
        Console.Clear();
        Menu.ExibirLogo();
        ExibirCabecalho("Registro de Bandas");
        Console.Write("Digite o nome da banda: ");
        string banda = Console.ReadLine()!;
        Banda bandaEncontrada = bandasLista.ConfereBanda(banda);
        if(bandaEncontrada != null)
        {
            Console.WriteLine("Essa banda já está cadastrada");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirMenu(bandasLista);
        }else
        {
            Banda bandaNova = new Banda(banda);
            bandasLista.AddBanda(bandaNova);
            Console.WriteLine($"\nNome da banda {bandaNova.Nome} cadastrada com sucesso");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirMenu(bandasLista);

        }

    }
}