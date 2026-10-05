/*
 * 2    Skriv ett program som läser två vektorer från konsolen 
 *      och jämför dem element för element
 */

Console.Write("Ange storleken på första vektorn: ");
int[] firstArray = new int[int.Parse(Console.ReadLine())];
InitializeArray(firstArray);

Console.Write("\nAnge storleken på andra vektorn: ");
int[] secondArray = new int[int.Parse(Console.ReadLine())];
InitializeArray(secondArray);

CompareTwoArrays(firstArray, secondArray);

Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();


void InitializeArray(int[] array)
{
    Console.WriteLine("\nFyll vektorn med {0} tal: ", array.Length);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("   {0}: ", i + 1);
        array[i] = int.Parse(Console.ReadLine());
    }
}

void CompareTwoArrays(int[] firstArray, int[] secondArray)
{
    if (firstArray.Length > secondArray.Length)
    {
        Console.WriteLine("\nResultat -> Den första vektorn är större än den andra.\n");
    }
    else if (firstArray.Length < secondArray.Length)
    {
        Console.WriteLine("\nResultat -> Den andra  vektorn är större än den första.\n");
    }
    else
    {
        Array.Sort(firstArray);
        Array.Sort(secondArray);

        Console.WriteLine("\nResultat: ");
        Console.WriteLine("1) Båda vektorerna har samma storlek.");

        // Compares two arrays element-by-element 
        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                Console.WriteLine("2) Och olika innehåll.\n");
                return;
            }
        }

        Console.WriteLine("2) Och samma innehåll.\n");
    }
}

