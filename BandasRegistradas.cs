using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

class Bandas 
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

    // public Banda ConfereBanda(string banda)
    // {
    //     //se banda já existe exibe menssagem
    //     if(Bandas.Contains(banda))
    //     {
    //         return banda

    //     }
    // }
}