/*
 * 12 Sök online efter information om ASCII (American Standard Code for Information Exchange) 
 * och skriv ett program som skriver ut hela ASCII-tabellen med tecken på konsollen
*/

using System.Text;

Console.OutputEncoding = Encoding.UTF8;

string ASCII = @"ASCII includes definitions for 128 characters: 33 are non-printing control characters
that affect how text and space are processed and 95 printable characters, including the space.";

Console.WriteLine(ASCII);
Console.WriteLine("\nList of all visible ASCII symbols: ");

StringBuilder tableASCII = new StringBuilder();

for (byte symbol = 33; symbol < 126; symbol++)
{
    if ((symbol + 3) % 6 == 0)
    {
        tableASCII.AppendLine();
    }
    tableASCII.AppendFormat("{0:000}: {1,-8}", symbol, (char)symbol);
}

Console.WriteLine(tableASCII + Environment.NewLine);



