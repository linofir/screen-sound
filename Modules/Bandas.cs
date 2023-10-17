namespace ScreenSound.Modules;

internal class Bandas 
{
    private List<Banda> BandasLista = new List<Banda>();

    public void AddBanda(Banda banda)
    {
        BandasLista.Add(banda);
    }
    public void ExibirBandas()
    {
        int count = 0;
        foreach (var banda in BandasLista)
        {
            count += 1;
            Console.WriteLine($"Banda {count}: {banda.Nome}");
        }
    }

    public Banda ConfereBanda(string bandaEscolhida)
    {
        Banda bandaEncontrada = BandasLista.Find(banda => banda.Nome == bandaEscolhida)!;
        return  bandaEncontrada!;

    }

}