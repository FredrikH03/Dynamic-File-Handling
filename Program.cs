using System.Diagnostics.CodeAnalysis;

string userinput = Console.ReadLine();

int usernumber = int.Parse(userinput);

Console.WriteLine("user test{0}", usernumber);

string[] file = File.ReadAllLines("~/source/repos/Dynamic-File-Creation/files/test{0}.txt", usernumber);

Console.WriteLine(file);