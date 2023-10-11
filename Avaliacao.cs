class Avaliacao
{
    public Avaliacao( double nota, Banda banda )
    {
        Nota = nota;
        NomeBanda = banda.Nome;
        Notas.Add(nota);
        //banda.Notas = Notas;

    }
    private List<double> Notas = new List<double>();
    public string NomeBanda { get; set; }
    public double Nota { get; set; }
    
    public void AddNota(int nota)
    {
        Notas.Add(nota);
        
    }

    public void ExibeNotas()
    {
        int contador = 0;
        Console.WriteLine($"Notas da banda {NomeBanda}:\n");
        foreach (var nota in Notas)
        {   
            contador += 1;
            Console.WriteLine($"Nota {contador}: ${nota}");
            
        }
    }

    void ExibirMedia(string BandaEsolhida)
    {
        

    }
}