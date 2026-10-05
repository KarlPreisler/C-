

/*
 * 10 En reklambyrå vill hålla koll på sina anställda. 
 * Varje rad skall innehålla en del blandade data: 
 * Förnamn, efternamn, födelsedatum, anställningsnummer (27560000 till 27569999). 
 * Deklarera de nödvändiga variablerna som behövs för att hantera informationen om 
 * en enskild anställd. Använd lämpliga datatyper och beskrivande namn.
*/


uint numberOfEmployees = 3;
Employees[] employees = new Employees[numberOfEmployees];

// Fyll på med data:
employees[0].firstName = "Peter";
employees[0].lastName = "Johansson";
employees[0].age = 33;
employees[0].gender = 'm';
employees[0].BirthDate = 1111111;
employees[0].UniqueEN = 27560001;

employees[1].firstName = "Alexandra";
employees[1].lastName = "Todorova";
employees[1].age = 28;
employees[1].gender = 'f';
employees[1].BirthDate = 2222222;
employees[1].UniqueEN = 27560002;

employees[2].firstName = "Pesho";
employees[2].lastName = "Yordanov";
employees[2].age = 43;
employees[2].gender = 'm';
employees[2].BirthDate = 3333333;
employees[2].UniqueEN = 27560003;

PrintEmployees(employees);

void PrintEmployees(Employees[] employees)
{
    Console.WriteLine("Lista över anställda:\n");

    for (int i = 0; i < employees.Length; i++)
    {
        Console.WriteLine("Namn: {0} {1}", employees[i].firstName, employees[i].lastName);
        Console.WriteLine("Ålder: {0}", employees[i].age);
        Console.WriteLine("Kön: {0}",
            employees[i].gender == 'm' ? "Man" : (employees[i].gender == 'f' ? "Kvinna" : "Annat"));
        Console.WriteLine("Födelsedatum: {0}", employees[i].BirthDate);
        Console.WriteLine("Anställningsnummer: {0}", employees[i].UniqueEN);

        Console.WriteLine();
    }
}

internal struct Employees
{
    internal string firstName;
    internal string lastName;
    internal byte age;          // 0 - 255
    internal char gender;
    internal long BirthDate;
    internal uint UniqueEN;     // 27560000 till 27569999
}