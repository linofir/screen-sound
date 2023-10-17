using System.Reflection;
using ScreenSound.Modules;

namespace ScreenSound.Menus;

internal class MenuSair : Menu
{
    public void Executar(int opcaoEscolhida, Bandas bandasLista)
    {
        if(opcaoEscolhida == -1)
        {
            Console.WriteLine("***Adeus***");
        }else
        {
            Console.WriteLine("Opção escolhida inválida, deseja retornar?(s/n) ");
            string opcaoFinal = Console.ReadLine()!;
            if(opcaoFinal == "s")
            {
                ExibirMenu(bandasLista);
            }else{
                Console.WriteLine("***Adeus***");
            }
        }
    }
}