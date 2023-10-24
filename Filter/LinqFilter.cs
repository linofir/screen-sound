using ScreenSound.Modules;

namespace ScreenSound.Filter;

internal class LinqFilter
{
    public static void FilterGenre(List<Song> songs)
    {
        var genresFiltered = songs.Select(genre => genre.Genre).Distinct().ToList();
        foreach (var genre in genresFiltered)
        {
            Console.WriteLine($"- {genre}");
            
        }
    }

    public static void FilterArtistsByGenre(List<Song> songs, string genre)
    {
        var artistsByGenre = songs.Where(song => song.Genre!.Contains(genre)).Select(song => song.Artist).Distinct().ToList();
        foreach(var artist in artistsByGenre)
        {
            Console.WriteLine($"- {artist}");
        }
    }

    public static void FilterMusicsByArtist(List<Song> songs, string artist)
    {
        var songsByArtist = songs.Where(song => song.Artist!.Equals(artist)).ToList();

        Console.WriteLine($"Músicas do {artist}");
        foreach(var song in songsByArtist)
        {
            Console.WriteLine($"- {song.Name}");
        }
    }

    public static void FilterMusicToAdd(List<Song> songs, string chosenSong, SelectedSongs chosenList)
    {
        var selectedSong = songs.Where(song => song.Name!.Equals(chosenSong)).ToList();
        foreach(var song in selectedSong)
        {
            chosenList.AddLikedSong(song);
        }

    }

    public static void FilterByTune(List<Song> songs, string chosenTune)
    {
        int numericalChosenTune = Song.tuneList.IndexOf(chosenTune);
        if(numericalChosenTune != -1)
        {
            var songsByTune = songs.Where(song => song.NumericalTune.Equals(numericalChosenTune)).Select(song => song.Name);

            Console.WriteLine($"Essas são as músicas na tonalidade {chosenTune}:");
            foreach(var song in songsByTune)
            {
                Console.WriteLine(song);
            }
        }else Console.WriteLine("Nenhuma música com essa tonalidade");
        
    }
}