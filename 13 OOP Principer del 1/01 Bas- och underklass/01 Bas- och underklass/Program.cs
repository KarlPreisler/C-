namespace _01_Bas__och_underklass;

public class Fordon
{
    public string Märke;
}

public class Bil : Fordon
{
    public int AntalDörrar;
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 1: Enkelt arv ---\n\n");

        Bil minBil = new Bil();
        minBil.Märke = "Volvo";     // Ärvt fält
        minBil.AntalDörrar = 5;     // Eget fält

        Console.WriteLine($"Bilen är en {minBil.Märke} med {minBil.AntalDörrar} dörrar.");





        Console.Write("\n\nTryck på en tangent för att stänga fönstret");
        Console.ReadKey();
    }
}