using ScreenSound.Modules;

namespace ScreenSound.Menus;

internal class MenuExibirBandas: Menu
{
    public override void Executar(Bandas bandasLista)
    {
        base.Executar(bandasLista);
        ExibirCabecalho("Todas as bandas cadastradas");

        bandasLista.ExibirBandas();
        Console.WriteLine("Digite uma tecla para retornar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu(bandasLista);


    }
}