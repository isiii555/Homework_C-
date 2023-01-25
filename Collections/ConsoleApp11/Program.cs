using System.Collections;

Dictionary<int, string> dict = new();

dict.Add(1, "islam");

dict.Add(2, "namiq");

Console.WriteLine("Dictionary");

foreach (var item in dict)
{
    Console.WriteLine(item);
}

SortedList<int,string> list = new();

list.Add(2, "namiq");
list.Add(1, "islam");

Console.WriteLine("Sorted List");

foreach (var item in list)
{
    Console.WriteLine(item);
}


Hashtable table = new();

table.Add(1, "islam");
table.Add(2, "namiq");

Console.WriteLine("Hashtable");

foreach (DictionaryEntry item in table)
{
    Console.WriteLine($"{item.Key} {item.Value}");

}

