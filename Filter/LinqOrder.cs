using ScreenSound.Modules;

namespace ScreenSound.Filter;

internal class LinqOrder
{
    public static void OrderArtists(List<Song> songs)
    {
        var artistsOrdered = songs.OrderBy(song => song.Artist).Select(song => song.Artist).Distinct().ToList();

        foreach(var artist in artistsOrdered)
        {
            Console.WriteLine($"- {artist}");

        }
    }
}