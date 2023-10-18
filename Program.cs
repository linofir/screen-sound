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

