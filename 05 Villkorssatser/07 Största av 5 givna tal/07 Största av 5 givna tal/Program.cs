/*
 * 7    Skriv ett program som hittar det största av 5 givna tal
 */


decimal[] numbers = { -1, 5, -4, 3, 2 };
decimal max = numbers[0];

//Console.Write("Tal: {0}", numbers[0] + "  ");
//for (int i = 1; i < numbers.Length; i++)
//{
//    Console.Write(numbers[i] + "  ");

//    if (numbers[i] > max)
//    {
//        max = numbers[i];
//    }
//}

Console.Write("Tal: ");
foreach (var number in numbers)
{
    Console.Write(number + "  ");

    if (number > max)
    {
        max = number;
    }
}
Console.WriteLine("\n\nStörsta talet: {0}\n", max);




Console.Write("\n\nTryck på en tangent för att fortsätta...");
Console.ReadKey();
