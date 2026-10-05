/*
 * 21   Skriv ett program som läser två tal N och K och genererar 
 *      alla kombinationer av K distinkta element från datamängden [1…N]. 
 *      
 *      Exempel:
 *      N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
 */


Console.Write("Enter a number N: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Enter a number K: ");
int k = int.Parse(Console.ReadLine());

int[] elem = Enumerable.Repeat(1, k).ToArray();

int c;

do
{
    c = 1;

    if (IsElementsInIncreasingOrder(elem))
        PrintElements(elem);

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

bool IsElementsInIncreasingOrder(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        for (int j = i + 1; j < arr.Length; j++)
            if (arr[i] <= arr[j])
                return false;

    return true;
}

void PrintElements(int[] arr)
{
    for (int i = arr.Length - 1; i >= 0; i--)
        Console.Write(arr[i] + " ");
    Console.WriteLine();
}
