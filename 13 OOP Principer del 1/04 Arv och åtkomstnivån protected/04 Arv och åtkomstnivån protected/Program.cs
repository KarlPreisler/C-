namespace _04_Arv_och_åtkomstnivån_protected;

public class Konto
{
    // Endast synlig i denna klass samt underklasser
    protected string KontoNummer = "999-555";
}

public class Sparkonto : Konto
{
    public void SkrivUtKontoNummer()
    {
        Console.WriteLine($"Kontonummer: {KontoNummer}");
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 4: Protected åtkomst ---\n\n");

        Sparkonto konto = new Sparkonto();
        konto.SkrivUtKontoNummer();


        // Avkommentera för att visa att det blir kompileringsfel (VS vägrar)
        //konto.KontoNummer = "Nytt nummer";





        Console.Write("\n\nTryck på en tangent för att stänga fönstret");
        Console.ReadKey();
    }
}