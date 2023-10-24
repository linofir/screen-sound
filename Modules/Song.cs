using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace ScreenSound.Modules;

internal class Song
{
    public static List<string> tuneList = new(){"C","C#","D","D#","E","F","F#","G","G#","A","A#","B"};
    public static Dictionary<int,string> tuneTable = new()
    {
        {0,"C"},
        {1, "C#"},
        {2, "D"},
        {3, "D#"},
        {4, "E"},
        {5, "F"},
        {6, "F#"},
        {7, "G"},
        {8, "G#"},
        {9, "A"},
        {10, "A#"},
        {11, "B"},
    };

    [JsonPropertyName("key")]
    public int NumericalTune { get; set;}
    public Song()
    {
        //TuneConverter();
    }

    [JsonPropertyName("song")]
    public string? Name { get; set; }

    [JsonPropertyName("artist")]
    public string? Artist { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duration { get; set; }

    [JsonPropertyName("genre")]
    public string? Genre { get; set; }

    public string? Tune { get => tuneTable[NumericalTune];}

    public string Description => $"A música {Name} do {Artist} que tem como genero {Genre} e o tempo de duração é {Duration/1000}s, seu tom é {Tune}";

}