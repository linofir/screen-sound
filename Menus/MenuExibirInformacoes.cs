using ScreenSound.Modules;

namespace ScreenSound.Menus;

internal class MenuExibirInformacoes : Menu
{
    public override void Executar(Bandas bandasLista)
    {
        base.Executar(bandasLista);
        ExibirCabecalho("Informações das Bandas Cadastradas");
        Console.Write("Qual banda você quer saber a as informaçoes? ");
        string bandaEscolhida = Console.ReadLine()!;
        Banda bandaEncontrada = bandasLista.ConfereBanda(bandaEscolhida);

        if(bandaEncontrada != null)
        {
            bandaEncontrada.ExbirDiscografia();
            Console.WriteLine("Digite qualquer tecla para retornar");
            Console.ReadKey();
            ExibirMenu(bandasLista);
        
        }else
        {
            Console.WriteLine("Banda não encontrada");
            Thread.Sleep(2000);
            ExibirMenu(bandasLista);
        }


    }
}