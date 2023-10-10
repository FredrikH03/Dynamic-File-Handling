using System.Diagnostics.CodeAnalysis;

string userinput = Console.ReadLine();

int usernumber = int.Parse(userinput);

Console.WriteLine("user test{usernumber}");

string[] file = File.ReadAllLines($"../../../test{usernumber}.txt");

foreach (string line in file)
{
    Console.WriteLine(line);
}    