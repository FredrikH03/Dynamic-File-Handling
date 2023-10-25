using System.Diagnostics.CodeAnalysis;

string userinput = Console.ReadLine();

int usernumber = int.Parse(userinput);

Console.WriteLine("user test{usernumber}");

string[] file = File.ReadAllLines($"../../../test{usernumber}.txt");

foreach (string line in file)
{
    Console.WriteLine(line);
}


string path = @"receipts/";
Directory.CreateDirectory(path);
string[] files = Directory.GetFiles(path);
foreach (string file1 in files)
{
    Console.WriteLine(file1.Split(path)[1].Split(".csv")[0]);
}