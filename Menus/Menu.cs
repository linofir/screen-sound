using ScreenSound.Modules;

namespace ScreenSound.Menus;

internal class Menu
{
    public void ExibirMenu(Bandas bandasLista)
    {
        ExibirLogo();
        Console.WriteLine("\nBem vindo ao Screen Sound\n");

        Console.WriteLine("Digite 1 para registrar uma banda");
        Console.WriteLine("Digite 2 para mostrar bandas");
        Console.WriteLine("Digite 3 para avaliar uma banda");
        Console.WriteLine("Digite 4 para mostrar a média de uma banda");
        Console.WriteLine("Digite 5 para registrar um Album");
        Console.WriteLine("Digite 6 Exibir detalhes de uma Banda");
        Console.WriteLine("Digite -1 para sair");

        Console.Write("\nDigite sua opção: ");
        string opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaInteiro = int.Parse(opcaoEscolhida);

        switch (opcaoEscolhidaInteiro)
        {
            case 1 : 
                MenuRegistrarBandas menu1 = new MenuRegistrarBandas();
                menu1.Executar(bandasLista);
                break;
            case 2 : 
                MenuExibirBandas menu2 = new();
                menu2.Executar(bandasLista);
                break;
            case 3 : 
                MenuRegistraNotas menu3 = new();
                menu3.Executar(bandasLista);
                break;
            case 4 : 
                MenuExibirMedia menu4 = new();
                menu4.Executar(bandasLista);
                break;
            case 5 : 
                MenuRegistrarAlbum menu5 = new();
                menu5.Executar(bandasLista);
                break;
            case 6 :
                MenuExibirInformacoes menu6 = new MenuExibirInformacoes();
                menu6.Executar(bandasLista);
                break;
            case -1 : 
                MenuSair menuSair = new();
                menuSair.Executar(opcaoEscolhidaInteiro, bandasLista);
                break;
            default: 
                MenuSair menuDefault = new();
                menuDefault.Executar(opcaoEscolhidaInteiro, bandasLista);
                break;

        
        };
    }

    public void ExibirCabecalho(string titulo)
    {
        ExibirLogo();
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