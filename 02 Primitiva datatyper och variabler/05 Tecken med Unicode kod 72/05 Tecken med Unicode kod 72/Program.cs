/*
 * Deklarera en character-variabel och ge tilldela den tecknet med Unicode-värdet 72. 
 * Tips: använd Windows Kalkylatorn för att hitta hexadecimala motsvarigheten till 72.
*/

char symbol = '\u0048'; // Unicode for character 'H'

Console.WriteLine("Unicode värdet {0:X}(hex) är tecknet '{1}'", (int)symbol, symbol);