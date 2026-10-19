using _05b_Åtkomst_internal;

namespace _05_Åtkomstnivån_internal;

// Klassen är synlig inom samma assembly (projekt)
// Om vi kommenterar bort denna klassen, försöker VS att använda klassen i det andra projektet.
// DET KOMMER INTE ATT FUNGERA
internal class SystemModul
{
    public string Version = "1.0.3";
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 5: Internal åtkomst ---\n\n");
        var modul = new SystemModul();
        Console.WriteLine($"Modulversion: {modul.Version}");





        Console.Write("\n\nTryck på en tangent för att stänga fönstret");
        Console.ReadKey();
    }
}