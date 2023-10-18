using ScreenSound.Modules;

namespace ScreenSound.Menus;

internal class MenuExibirMedia : Menu
{
    public override void Executar(Bandas bandasLista)
    {
        base.Executar(bandasLista);
        ExibirCabecalho("Avalie as Bandas");

        Console.Write("Qual banda você quer saber a média? ");
        string bandaEscolhida = Console.ReadLine()!;
        Banda bandaEncontrada = bandasLista.ConfereBanda(bandaEscolhida);

        if(bandaEncontrada != null)
        {
            if(bandaEncontrada.RetornaLista().Count != 0)
            {
                bandaEncontrada.ExibirMedia();
                Console.WriteLine("Digite qualquer tecla para retornar");
                Console.ReadKey();
                ExibirMenu(bandasLista);
            }else{
                Console.WriteLine($"A banda {bandaEscolhida} não recebeu nenhum voto");
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