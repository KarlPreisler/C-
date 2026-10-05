/*
 * 11   Skriv ett program som skriver ut alla möjliga kort från en standard 52-korts kortlek. 
 *      Korten skrivs ut med sina svenska namn. 
 *      Använd nästlade for-snurror och switch-case
 */

for (int färg = 1; färg <= 4; färg++)
{
    for (int värde = 2; värde <= 14; värde++)
    {
        switch (färg)
        {
            case 1: Console.Write("Spader "); break;
            case 2: Console.Write("Ruter "); break;
            case 3: Console.Write("Hjärter "); break;
            case 4: Console.Write("Klöver "); break;
            default: Console.Write(" FEL! "); break;
        }

        switch (värde)
        {
            case 2: Console.Write("Två\n"); break;
            case 3: Console.Write("Tre\n"); break;
            case 4: Console.Write("Fyra\n"); break;
            case 5: Console.Write("Fem\n"); break;
            case 6: Console.Write("Sex\n"); break;
            case 7: Console.Write("Sju\n"); break;
            case 8: Console.Write("Åtta\n"); break;
            case 9: Console.Write("Nio\n"); break;
            case 10: Console.Write("Tio\n"); break;
            case 11: Console.Write("Knekt\n"); break;
            case 12: Console.Write("Dam\n"); break;
            case 13: Console.Write("Kung\n"); break;
            case 14: Console.Write("Ess\n"); break;
            default: Console.Write(" FEL! "); break;
        }
    }
}



Console.Write("\n\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();