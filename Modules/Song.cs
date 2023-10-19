using System.Text.Json.Serialization;

namespace ScreenSound.Modules;

internal class Song
{
    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duration { get; set; }

    [JsonPropertyName("genre")]
    public string? Genre { get; set; }

    public string Description => $"A música {Nome} do {Artista} tem como genero {Genre} e o tempo de duração é {Duration/1000}s";


}