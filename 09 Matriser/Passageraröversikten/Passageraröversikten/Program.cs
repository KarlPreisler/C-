string[,] sittplatser = new string[4, 2];
for (int rad = 0; rad < sittplatser.GetLength(0); rad++)
{
    for (int stol = 0; stol < 2; stol++)
    {
        sittplatser[rad, stol] = "ledig";
    }
}

sittplatser[0, 0] = "Anna";
sittplatser[2, 1] = "Björn";

for (int rad = 0; rad < sittplatser.GetLength(0); rad++)
{
    for (int stol = 0; stol < sittplatser.GetLength(1); stol++)
    {
        Console.WriteLine($"Rad {rad + 1}, Stol {stol + 1}: {sittplatser[rad, stol]}");
    }
    Console.WriteLine();
}



Console.Write("Tryck på valfri tangent för att avsluta programmet...");
Console.ReadKey();


