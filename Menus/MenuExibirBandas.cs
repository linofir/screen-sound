using ScreenSound.Modules;

namespace ScreenSound.Menus;

internal class MenuExibirBandas: Menu
{
    public void Executar(Bandas bandasLista)
    {
        Console.Clear();
        ExibirLogo();
        ExibirCabecalho("Todas as bandas cadastradas");

        bandasLista.ExibirBandas();
        Console.WriteLine("Digite uma tecla para retornar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu(bandasLista);


    }
}