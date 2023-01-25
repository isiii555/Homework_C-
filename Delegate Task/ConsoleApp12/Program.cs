using ConsoleApp12;

Action<string> act;

MyClass armud = new();

act = armud.Space;
act += armud.Reverse;

Run run = new Run();

Console.WriteLine("Enter string :");
string? str = Console.ReadLine();

run.runFunc(act, str);