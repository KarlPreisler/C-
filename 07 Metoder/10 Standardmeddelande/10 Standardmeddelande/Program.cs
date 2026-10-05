void loggaMeddelande(string meddelande, string loggTyp = "INFO") 
{
    Console.WriteLine($"[{loggTyp}] - {meddelande}");
}

loggaMeddelande("Något gick fel", "ERROR");
loggaMeddelande("Allt gick bra", "SUCCESS");


Console.Write("Tryck på valfri tangent för att avsluta...");