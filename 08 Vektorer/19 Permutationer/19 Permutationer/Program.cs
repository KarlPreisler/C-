/*
 * 19   Skriv ett program som läser ett tal N och genererar och skriver ut alla 
 *      permutationer av talen [1 … N]. 
 *      
 *      Exempel:
 *      n = 3 -> {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}
 */

Console.Write("Enter a number N: ");
int n = int.Parse(Console.ReadLine());
int k = n;

// Initialize the array with ones 'k' times 
int[] elem = Enumerable.Repeat(1, k).ToArray();

int c;

do
{
    c = 1;

    if (ContainsDifferentElements(elem)) PrintElements(elem);

    for (int i = 0; i < k; i++)
    {
        elem[i] += c;

        if (elem[i] <= n)
        {
            c = 0; break;
        }
        else
        {
            elem[i] = c = 1;
        }
    }
}
while (c != 1);



Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();



bool ContainsDifferentElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        for (int j = i + 1; j < arr.Length; j++)
            if (arr[i] == arr[j])
                return false;

    return true;
}

void PrintElements(int[] arr)
{
    for (int i = arr.Length - 1; i >= 0; i--)
        Console.Write(arr[i] + " ");
    Console.WriteLine();
}
