namespace ScreenSound.Modules;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        Nota = nota;
    }

    public int Nota { get; set; }

    public static Avaliacao Parse(string notaTexto)
    {
        int nota = int.Parse(notaTexto);
        return new Avaliacao(nota);
    }
}