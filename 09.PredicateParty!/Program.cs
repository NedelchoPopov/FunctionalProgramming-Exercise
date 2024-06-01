/*
Peter Misha Stephen
Remove StartsWith P
Double Length 5
Party!

Peter
Double StartsWith Pete
Double EndsWith eter
Party!

Peter
Remove StartsWith P
Party!

 */

using System.IO;

List<string> names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string command;

Func<List<string>, string, string, List<string>> filter
    = (listOfNames, operation, value) =>
    {
        return operation == "StartsWith"
        ? listOfNames.Where(x => x.StartsWith(value)).ToList()
        : operation == "EndsWith"
        ? listOfNames.Where(x => x.EndsWith(value)).ToList()
        : listOfNames.Where(x => x.Length == int.Parse(value))
        .ToList();
    };

while ((command = Console.ReadLine()) != "Party!")
{
    string[] arguments = command
        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

    string argument = arguments[0].Trim();
    string operation = arguments[1].Trim();
    string value = arguments[2].Trim();

    List<string> targetNames = filter(names, operation, value);

    if (argument == "Remove")
    {

        names = names.Where(x => !targetNames.Contains(x)).ToList();
    }
    else if(argument == "Double")
    {
        foreach (var item in targetNames)
        {
            int index = targetNames.IndexOf(item);
            names.Insert(index, item);
        }
    }
}

if (names.Count > 0)
{
    Console.WriteLine(string.Join(", ", names) + " are going to the party!");
}
else
{
    Console.WriteLine("Nobody is going to the party!");
}