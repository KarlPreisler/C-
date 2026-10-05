/*
 * 7    Att sortera en vektor innebär att arrangera om dess element i stigande ordning. 
 *      Skriv ett program som sorterar en vektor. 
 *      
 *      Använd algoritmen Urvalssortering (Wikipedia: https://sv.wikipedia.org/wiki/Urvalssortering)
 */

Console.Write("Enter a number N (size of array): ");
int n = int.Parse(Console.ReadLine());

int[] numbers = new int[n];
Console.WriteLine("\nEnter a {0} number(s) to array: ", n);
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("   {0}: ", i + 1);
    numbers[i] = int.Parse(Console.ReadLine());
}

Console.Write("\nBefore sorting: ");
Console.WriteLine(string.Join(" ", numbers));

numbers = SelectionSort(numbers);

Console.Write("\nAfter sorting: ");
Console.WriteLine(string.Join(" ", numbers) + "\n");




Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();

// Classical implementation of Selection Sort Algorithm
int[] SelectionSort(int[] numbers)
{
    int index, swap;

    for (int i = 0; i < numbers.Length - 1; i++)
    {
        index = i;

        for (int j = i + 1; j < numbers.Length; j++)
            if (numbers[j] < numbers[index])
                index = j;

        swap = numbers[i];
        numbers[i] = numbers[index];
        numbers[index] = swap;
    }

    return numbers;
}
