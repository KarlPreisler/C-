/*
 * 11   Skriv ett program som konverterar ett tal i intervallet [0..999] till text som 
 *      motsvarar dess svenska (eller engelska) uttal. Exempel:
 *      
 *      0 -> "Noll"
 *      273 -> "Tvåhundrasjuttiotre"
 *      400 -> "Fyrahundra"
 *      501 -> "Femhundraett"
 *      711 -> "Sjuhundraelva"
 *      
 *      NOTERA: engelska har mer komplicerade regler än svenska
*/


string[] Units =
{ "", "NOLL", "ETT", "TVÅ", "TRE", "FYRA", "FEM", "SEX", "SJU", "ÅTTA", "NIO" };
string[] Decimals =
{ "", "TIO", "ELVA", "TOLV", "TRETTON", "FJORTON", "FEMTON", "SEXTON", "SJUTTON", "ADERTON", "NITTON" };
string[] Hundreds =
{ "", "ETT", "TJUGO", "TRETTIO", "FYRTIO", "FEMTIO", "SEXTIO", "SJUTTIO", "ÅTTIO", "NITTIO" };

Console.Write("Ange ett tal [0;999]: ");

int number = int.Parse(Console.ReadLine());

if (number < 0 || number > 999)
{
    throw new ArgumentOutOfRangeException("Talet är utanför intervallet [0;999]...");
}

Console.Write("\n{0} -> ", number);
Console.WriteLine(GetHundreds(number) + GetDecimals(number) + GetUnits(number) + Environment.NewLine);




Console.Write("\n\nTryck på en tangent för att fortsätta...");
Console.ReadKey();


string GetHundreds(int number)
{
    if (number >= 100)
    {
        //return string.Format("{0} HUNDRED", Hundreds[number / 100]);
        return string.Format("{0} HUNDRA", Units[number / 100 + 1]);
    }

    return string.Empty;
}

string GetDecimals(int number)
{
    if (number > 9 && number < 20)
    {
        return Decimals[number % 10 + 1];
    }
    else if (number % 100 >= 10 && number % 100 <= 19)
    {
        if (number / 100 > 0)
            //return string.Format(" AND {0}", Decimals[Math.Abs(10 - number % 100) + 1]);
            return string.Format(" {0}", Decimals[Math.Abs(10 - number % 100) + 1]);
        else
            return Decimals[number / 10 % 10];
    }
    else if (number > 100 && number % 100 != 0 && number / 10 % 10 != 0)
    {
        //return string.Format(" AND {0}", Hundreds[number / 10 % 10]);
        return string.Format(" {0}", Hundreds[number / 10 % 10]);
    }
    else
    {
        return string.Format("{0}", Hundreds[number / 10 % 10]);
    }
}

string GetUnits(int number)
{
    if (number < 10)
    {
        return string.Format("{0}", Units[number % 10 + 1]);
    }
    else if (number / 10 % 10 >= 2 && number <= 100 && number % 10 != 0)
    {
        return string.Format(" {0}", Units[number % 10 + 1]);
    }
    else if (number > 100 && number / 10 % 10 >= 2 && number % 10 != 0)
    {
        return string.Format(" {0}", Units[number % 10 + 1]);
    }
    else if (number > 100 && number % 100 < 10 && number % 10 != 0)
    {
        //return string.Format(" AND {0}", Units[number % 10 + 1]);
        return string.Format(" {0}", Units[number % 10 + 1]);
    }

    return string.Empty;
}
