namespace _03_Treledshierarki__Anställd___Manager___VD_;

public class Anställd
{
    public double Lön;
}

public class Manager : Anställd
{
    public string Avdelning;
}

public class VD : Manager
{
    public int antalAktier;
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 3: Hierarkier av klasser ---\n\n");

        VD företagsLedare = new VD();
        företagsLedare.Lön = 85_000;        // Från Anställd
        företagsLedare.Avdelning = "HQ";    // Från Manager
        företagsLedare.antalAktier = 500;   // Från VD

        Console.WriteLine($"VD Lön: {företagsLedare.Lön}, Avdelning: {företagsLedare.Avdelning}, Aktier: {företagsLedare.antalAktier}");





        Console.Write("\n\nTryck på en tangent för att stänga fönstret");
        Console.ReadKey();
    }
}