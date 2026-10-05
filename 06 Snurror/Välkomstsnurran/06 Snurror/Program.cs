string lösenord;
do
{
    Console.Write("Ange lösenord: ");
    lösenord = Console.ReadLine();
    if (lösenord != "hemligt")
    {
        Console.WriteLine("Fel lösenord, försök igen.");
    }
} while (lösenord != "hemligt");

Console.WriteLine("Lösenord korrekt!");



Console.Write("Tryck på en tangent för att avsluta...");
Console.ReadKey();