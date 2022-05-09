// See https://aka.ms/new-console-template for more information
using DumbAwardCoTest;
int[] test = { 1, 2, 5, 5, 4, 1, 4, 6, 8, 3, 9, 10, 5, 1, 4, 5,5,5,5,5,5,5,5};

ParseArray parse = new ParseArray();
int[] expected = parse.ParseArrayForUniqueNumbers(test);

Console.WriteLine("Out of the numbers in test array: ");

Console.WriteLine("There are " + expected.Length + " unique numbers");
Console.WriteLine("those numbers being:");
foreach (int numbers in expected)
{
    Console.WriteLine(numbers);
}

Console.WriteLine("total Duplicates: " + parse.arrayToList.Count + " Duplicates being:");
foreach (int number in parse.arrayToList)
{
    Console.WriteLine(number);
}
Console.ReadLine();




