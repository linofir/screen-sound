using ScreenSound.Modules;

namespace ScreenSound.Menus;

internal class Menu
{
    public Dictionary<int, Menu> opcoes = new();
    
    public void ExibirMenu(Bandas bandasLista)
    {
        int opcaoEscolhida = ExibirOpcoes();
        opcoes[opcaoEscolhida].Executar(bandasLista);

        // switch (MenuSelecionado)
        // {
        //     case 1 : 
        //         MenuRegistrarBandas menu1 = new MenuRegistrarBandas();
        //         menu1.Executar(bandasLista);
        //         break;
        //     case 2 : 
        //         MenuExibirBandas menu2 = new();
        //         menu2.Executar(bandasLista);
        //         break;
        //     case 3 : 
        //         MenuRegistraNotas menu3 = new();
        //         menu3.Executar(bandasLista);
        //         break;
        //     case 4 : 
        //         MenuExibirMedia menu4 = new();
        //         menu4.Executar(bandasLista);
        //         break;
        //     case 5 : 
        //         MenuRegistrarAlbum menu5 = new();
        //         menu5.Executar(bandasLista);
        //         break;
        //     case 6 :
        //         MenuExibirInformacoes menu6 = new MenuExibirInformacoes();
        //         menu6.Executar(bandasLista);
        //         break;
        //     case -1 : 
        //         MenuSair menuSair = new();
        //         menuSair.Executar(MenuSelecionado, bandasLista);
        //         break;
        //     default: 
        //         MenuSair menuDefault = new();
        //         menuDefault.Executar(MenuSelecionado, bandasLista);
        //         break;

        
        // };
    }

    public virtual void Executar(Bandas bandasLista)
    {
        Console.Clear();
        ExibirLogo();
    }

    public int ExibirOpcoes()
    {
        opcoes.Add(1, new MenuRegistrarBandas());
        opcoes.Add(2, new MenuExibirBandas());
        opcoes.Add(3, new MenuRegistraNotas());
        opcoes.Add(4, new MenuExibirMedia());
        opcoes.Add(5, new MenuRegistrarAlbum());
        opcoes.Add(6, new MenuExibirInformacoes());
        opcoes.Add(7, new MenuExibirMediaAlbum());
        opcoes.Add(-1, new MenuSair());

        ExibirLogo();
        Console.WriteLine("\nBem vindo ao Screen Sound\n");

        Console.WriteLine("Digite 1 para registrar uma banda");
        Console.WriteLine("Digite 2 para mostrar bandas");
        Console.WriteLine("Digite 3 para avaliar uma banda");
        Console.WriteLine("Digite 4 para mostrar a média de uma banda");
        Console.WriteLine("Digite 5 para registrar um Album");
        Console.WriteLine("Digite 6 Exibir detalhes de uma Banda");
        Console.WriteLine("Digite 7 Exibir detalhes de uma Banda");
        Console.WriteLine("Digite -1 para sair");

        Console.Write("\nDigite sua opção: ");
        string opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaInteiro = int.Parse(opcaoEscolhida);
        return opcaoEscolhidaInteiro;
    }

    public void ExibirCabecalho(string titulo)
    {
        int quantidadeLetras = titulo.Length;
        string separador = string.Empty.PadRight(quantidadeLetras,'-');
        Console.WriteLine(separador);
        Console.WriteLine(titulo);
        Console.WriteLine(separador + "\n");
    }

    public static void ExibirLogo() 
    {
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine(@"
    █████████████████████████████████████████████████████████████████████████
    █─▄▄▄▄█─▄▄▄─█▄─▄▄▀█▄─▄▄─█▄─▄▄─█▄─▀█▄─▄███─▄▄▄▄█─▄▄─█▄─██─▄█▄─▀█▄─▄█▄─▄▄▀█
    █▄▄▄▄─█─███▀██─▄─▄██─▄█▀██─▄█▀██─█▄▀─████▄▄▄▄─█─██─██─██─███─█▄▀─███─██─█
    ▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▀▄▄▀▀▀▄▄▄▄▄▀▄▄▄▄▀▀▄▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀");

    }
}