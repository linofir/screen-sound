//Screen Sound
using ScreenSound.Menus;
using ScreenSound.Modules;



Bandas bandasLista = new Bandas();

Banda banda = new Banda("queen");
bandasLista.AddBanda(banda);

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

Menu menu = new();
menu.ExibirMenu(bandasLista);

// void ExibirMenu() 
// {
//     Menu.ExibirLogo();

//     Console.WriteLine("Digite 1 para registrar uma banda");
//     Console.WriteLine("Digite 2 para mostrar bandas");
//     Console.WriteLine("Digite 3 para avaliar uma banda");
//     Console.WriteLine("Digite 4 para mostrar a média de uma banda");
//     Console.WriteLine("Digite 5 para registrar um Album");
//     Console.WriteLine("Digite 6 Exibir detalhes de uma Banda");
//     Console.WriteLine("Digite -1 para sair");

//     Console.Write("\nDigite sua opção: ");
//     string opcaoEscolhida = Console.ReadLine()!;
//     int opcaoEscolhidaInteiro = int.Parse(opcaoEscolhida);

//     switch (opcaoEscolhidaInteiro)
//     {
//         case 1 : 
//             RegistrarBandas();
//             MenuRegistrarBandas menu1 = new MenuRegistrarBandas();
//             menu1.Executar(bandasLista);
//             break;
//         case 2 : 
//             ExibirTodasBandas();
            

//             break;
//         case 3 : RegistrarNotas();
//             break;
//         case 4 : ExibirMedia();
//             break;
//         case 5 : RegistrarAlbum();
//             break;
//         case 6 :
//             MenuExibirInformacoes menu6 = new MenuExibirInformacoes();
//             menu6.Executar(bandasLista);
//             break;
//         case -1 : Console.WriteLine("**Adeus**");
//             break;
//         default: Console.WriteLine("A opção é invalida");
//             break;

//     }
// };

// void RegistrarBandas() 
// {
//     Console.Clear();
//     Menu.ExibirLogo();
//     ExibirCabecalho("Registro de Bandas");
//     Console.Write("Digite o nome da banda: ");
//     string banda = Console.ReadLine()!;
//     Banda bandaEncontrada = bandasLista.ConfereBanda(banda);
//     if(bandaEncontrada != null)
//     {
//         Console.WriteLine("Essa banda já está cadastrada");
//         Thread.Sleep(2000);
//         Console.Clear();
//         ExibirMenu();
//     }else
//     {
//         Banda bandaNova = new Banda(banda);
//         bandasLista.AddBanda(bandaNova);
//         Console.WriteLine($"\nNome da banda {bandaNova.Nome} cadastrada com sucesso");
//         Thread.Sleep(2000);
//         Console.Clear();
//         ExibirMenu();

//     }
// };

// void ExibirTodasBandas() 
// {   
//     Console.Clear();
//     Menu.ExibirLogo();
//     ExibirCabecalho("Todas as bandas cadastradas");

//     bandasLista.ExibirBandas();
//     Console.WriteLine("Digite uma tecla para retornar ao menu");
//     Console.ReadKey();
//     Console.Clear();
//     ExibirMenu();

// };

// void RegistrarNotas()
// {
//     Console.Clear();
//     Menu.ExibirLogo();
//     ExibirCabecalho("Avalie as Bandas");

//     Console.Write("Qual banda quer avaliar?");
//     string bandaEscolhida = Console.ReadLine()!;
//     Banda bandaEncontrada = bandasLista.ConfereBanda(bandaEscolhida);
    
//     if( bandaEncontrada != null)
//     {
//         Console.Write($"\nQual sua nota para a banda {bandaEncontrada.Nome}?");
//         Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
//         Console.WriteLine($"A {bandaEncontrada.Nome} recebeu a nota: {nota.Nota}");
//         bandaEncontrada.AddNota(nota);
//         bandaEncontrada.ExibeNotas();
//         Thread.Sleep(2000);
//         ExibirMenu();
//     }else 
//     {
//     Console.WriteLine($"A {bandaEscolhida} não existe");
//     Thread.Sleep(2000);
//     ExibirMenu();
//     };
// };

// void ExibirMedia() 
// {
//     Console.Clear();
//     Menu.ExibirLogo();
//     ExibirCabecalho("Avalie as Bandas");

//     Console.Write("Qual banda você quer saber a média? ");
//     string bandaEscolhida = Console.ReadLine()!;
//     Banda bandaEncontrada = bandasLista.ConfereBanda(bandaEscolhida);

//     if(bandaEncontrada != null)
//      {
//         if(bandaEncontrada.RetornaLista().Count != 0)
//         {
//             bandaEncontrada.ExibirMedia();
//             Console.WriteLine("Digite qualquer tecla para retornar");
//             Console.ReadKey();
//             ExibirMenu();
//         }else{
//             Console.WriteLine($"A banda {bandaEscolhida} não recebeu nenhum voto");
//             Thread.Sleep(2000);
//             ExibirMenu();
//         }
//     }else   
//     {
//     Console.WriteLine($"A {bandaEscolhida} não existe");
//     Thread.Sleep(2000);
//     ExibirMenu();
//     };


// };

//void ExibirMusicas() 
// {
//     Console.Clear();
    
//     ExibirCabecalho("Músicas cadastradas");
    

//     banda.ExbirDiscografia();
//     album.ExibirMusicas();
//     musica.ExibirInformacoes();
//     musica2.ExibirInformacoes();

// }

// void RegistrarAlbum()
// {
//     Console.Clear();
//     Menu.ExibirLogo();
//     ExibirCabecalho("Avalie as Bandas");

//     Console.WriteLine("Deseja adicionar um album para qual banda");
//     string bandaEscolhida = Console.ReadLine()!;
//     Banda bandaEncontrada = bandasLista.ConfereBanda(bandaEscolhida);
//     if(bandaEncontrada != null)
//     {
//         Console.Write($"Digite o nome do algum da banda {bandaEncontrada.Nome}: ");
//         Album novoAlbum = new(Console.ReadLine()!);
//         bandaEncontrada.AddAlbum(novoAlbum);
//         bandaEncontrada.ExbirDiscografia();
//         Console.Write("Deseja incluir músicas nesse algum?(s/n)");
//         string opcaoEscolhida = Console.ReadLine()!;

//         if(opcaoEscolhida == "s" )
//         {
//             RegistraMusica(bandaEncontrada, novoAlbum);
//             Thread.Sleep(2000);
//             ExibirMenu();

//         }else
//         {
//             Thread.Sleep(2000);
//             ExibirMenu();
//         }

//     }else
//     {
//         Console.WriteLine($"A {bandaEscolhida} não existe");
//         Thread.Sleep(2000);
//         ExibirMenu();
//     }

// }

// void RegistraMusica(Banda banda, Album novoAlbum) 
// {
//     Console.Write("Digite o nome da música");
//     string nomeEscolhido = Console.ReadLine()!;
//     Musica novaMusica = new(banda, nomeEscolhido);
//     Console.Write("Digite a duração dessa música: ");
//     novaMusica.Duracao = int.Parse(Console.ReadLine()!);
//     novaMusica.Disponibilidade = true;

//     novoAlbum.AddMusica(novaMusica);
//     novoAlbum.ExibirMusicas();

// }

// void ExibirCabecalho(string titulo) 
// {
//     Menu.ExibirLogo();
//     int quantidadeLetras = titulo.Length;
//     string separador = string.Empty.PadRight(quantidadeLetras,'-');
//     Console.WriteLine(separador);
//     Console.WriteLine(titulo);
//     Console.WriteLine(separador + "\n");

// };



//ExibirMenu();