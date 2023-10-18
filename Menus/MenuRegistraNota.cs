using ScreenSound.Modules;

namespace ScreenSound.Menus;

internal class MenuRegistraNotas : Menu
{
    public override void Executar(Bandas bandasLista)
    {
        base.Executar(bandasLista);
        ExibirCabecalho("Avalie as Bandas");

        Console.Write("Qual banda quer avaliar?");
        string bandaEscolhida = Console.ReadLine()!;
        Banda bandaEncontrada = bandasLista.ConfereBanda(bandaEscolhida);
    
        if( bandaEncontrada != null)
        {
            Console.Write($"\nQual sua nota para a banda {bandaEncontrada.Nome}?");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            Console.WriteLine($"A {bandaEncontrada.Nome} recebeu a nota: {nota.Nota}");
            bandaEncontrada.AddNota(nota);
            bandaEncontrada.ExibeNotas();
            Thread.Sleep(2000);
            ExibirMenu(bandasLista);
        }else 
        {
        Console.WriteLine($"A {bandaEscolhida} não existe");
        Thread.Sleep(2000);
        ExibirMenu(bandasLista);
        };
    }
}