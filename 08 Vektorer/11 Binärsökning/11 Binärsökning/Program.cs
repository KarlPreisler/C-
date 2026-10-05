/*
 * 11   Skriv ett program som hittar indexet för ett givet element i en sorterad vektor av heltal. 
 *      Använd algoritmen binärsökning (Wikipedia: https://sv.wikipedia.org/wiki/Bin%C3%A4rs%C3%B6kning)
 */


Console.Write("Enter a number N (size of array): ");
int n = int.Parse(Console.ReadLine());

Console.Write("Enter a searched number: ");
int searchedNumber = int.Parse(Console.ReadLine());

int[] numbers = new int[n];
Console.WriteLine("\nEnter a {0} number(s) to array: ", n);
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("   {0}: ", i + 1);
    numbers[i] = int.Parse(Console.ReadLine());
}

Array.Sort(numbers);

int index = BinarySearch(numbers, searchedNumber, 0, numbers.Length);

if (index != -1) Console.WriteLine("\nNumber {0} found at index: {1}\n", searchedNumber, index);
else Console.WriteLine("\nNumber {0} not found!\n", searchedNumber);




Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();


// Searches for the specified object and returns the index of the first
// occurrence within the range of elements in the one-dimensional System.Array
// that starts at the specified index and contains the specified number of elements.
int BinarySearch(int[] numbers, int value, int startIndex, int endIndex)
{
    if (!numbers.Contains(value)) return -1; // Not found

    int middleIndex = (startIndex + endIndex) / 2;

    if (numbers[middleIndex] == value)
    {
        return middleIndex;
    }
    else if (numbers[middleIndex] > value)
    {
        return BinarySearch(numbers, value, 0, middleIndex - 1);
    }
    else
    {
        return BinarySearch(numbers, value, middleIndex + 1, numbers.Length - 1);
    }
}
