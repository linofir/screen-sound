//Screen Sound
using System.Runtime.CompilerServices;
using System.Security.AccessControl;

string menssagemHelloWorld = "\nBem vindo ao Screen Sound\n";

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("acdc", new List<int>{10,8,5});
bandasRegistradas.Add("metallica", new List<int>());

Banda banda = new Banda("Queen");

Album album = new Album("A night of Opera");
banda.AddAlbum(album);

Musica musica = new Musica(banda, "history of my life")
{
    Duracao = 213,
    Disponibilidade = true
};

Musica musica2 = new Musica(banda, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponibilidade = false
};


album.AddMusica(musica);
album.AddMusica(musica2);

void ExibirLogo() 
{
    Console.WriteLine("--------------------------------------------------------------");
    Console.WriteLine(@"
█████████████████████████████████████████████████████████████████████████
█─▄▄▄▄█─▄▄▄─█▄─▄▄▀█▄─▄▄─█▄─▄▄─█▄─▀█▄─▄███─▄▄▄▄█─▄▄─█▄─██─▄█▄─▀█▄─▄█▄─▄▄▀█
█▄▄▄▄─█─███▀██─▄─▄██─▄█▀██─▄█▀██─█▄▀─████▄▄▄▄─█─██─██─██─███─█▄▀─███─██─█
▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▀▄▄▀▀▀▄▄▄▄▄▀▄▄▄▄▀▀▄▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀");

    Console.WriteLine(menssagemHelloWorld);
};

void ExibirMenu() 
{
    ExibirLogo();

    Console.WriteLine("Digite 1 para registrar band");
    Console.WriteLine("Digite 2 para mostrar bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para mostrar a média de uma banda");
    Console.WriteLine("Digite 5 para músicas de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaInteiro = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaInteiro)
    {
        case 1 : RegistrarBandas();
            break;
        case 2 : ExibirTodasBandas();
            break;
        case 3 : RegistrarNotas();
            break;
        case 4 : ExibirMedia();
            break;
        case 5 : ExibirMusicas();
            break;
        case -1 : Console.WriteLine("**Adeus**");
            break;
        default: Console.WriteLine("A opção é invalida");
            break;

    }
};

void RegistrarBandas() 
{
    Console.Clear();
    ExibirLogo();
    ExibirCabecalho("Registro de Bandas");
    Console.Write("Digite o nome da banda: ");
    string banda = Console.ReadLine()!;
    bandasRegistradas.Add(banda, new List<int>());
    Console.WriteLine($"\nNome da banda {banda} cadastrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
};

void ExibirTodasBandas() 
{   
    Console.Clear();
    ExibirLogo();
    ExibirCabecalho("Todas as bandas cadastradas");

    foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda {1}: {banda}");

    };
    Console.WriteLine("Digite uma tecla para retornar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();

};

void RegistrarNotas()
{
    Console.Clear();
    ExibirLogo();
    ExibirCabecalho("Avalie as Bandas");

    Console.Write("Qual banda quer avaliar?");
    string bandaEscolhida = Console.ReadLine()!;
    //string bandaUpperCase = bandaEscolhida.ToLower(bandaEscolhida);

    if(bandasRegistradas.ContainsKey(bandaEscolhida))
    {
        Console.Write($"\nQual sua nota para a banda {bandaEscolhida}?");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[bandaEscolhida].Add(nota);
        Console.WriteLine($"A {bandaEscolhida} recebeu a nota: {nota}");
        Thread.Sleep(2000);
        ExibirMenu();
    }else 
    {
    Console.WriteLine($"A {bandaEscolhida} não existe");
    Thread.Sleep(2000);
    ExibirMenu();
    };
};

void ExibirMedia() 
{
    Console.Clear();
    ExibirLogo();
    ExibirCabecalho("Avalie as Bandas");

    Console.Write("Qual banda você quer saber a média? ");
    string bandaEscolhida = Console.ReadLine()!;

    if(bandasRegistradas.ContainsKey(bandaEscolhida))
    {
        if(bandasRegistradas[bandaEscolhida].Count != 0)
        {
            double mediaBanda = bandasRegistradas[bandaEscolhida].Average();
            Console.WriteLine($"A média da {bandaEscolhida} é {mediaBanda}");
            Console.WriteLine("Digite qualquer tecla para retornar");
            Console.ReadKey();
            ExibirMenu();
        }else{
            Console.WriteLine($"A banda {bandaEscolhida} não recebeu nenhum voto");
            Thread.Sleep(2000);
            ExibirMenu();
        }
    }else   
    {
    Console.WriteLine($"A {bandaEscolhida} não existe");
    Thread.Sleep(2000);
    ExibirMenu();
    };


};

void ExibirMusicas() 
{
    Console.Clear();
    ExibirLogo();
    ExibirCabecalho("Músicas cadastradas");

    banda.ExbirDiscografia();
    album.ExibirMusicas();
    musica.ExibirInformacoes();
    musica2.ExibirInformacoes();

}

void ExibirCabecalho(string titulo) 
{
    int quantidadeLetras = titulo.Length;
    string separador = string.Empty.PadRight(quantidadeLetras,'-');
    Console.WriteLine(separador);
    Console.WriteLine(titulo);
    Console.WriteLine(separador + "\n");

};



ExibirMenu();