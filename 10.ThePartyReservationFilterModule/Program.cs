/*
Peter Misha Slav
Add filter;Starts with;P
Add filter;Starts with;M
Print

Peter Misha John
Add filter;Starts with;P
Add filter;Starts with;M
Remove filter;Starts with;M
Print

 */

List<string> names = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string command;

List<string> operations = new();

while((command = Console.ReadLine()) != "Print")
{
    string[] commandInfo = command
        .Split(";", StringSplitOptions.RemoveEmptyEntries);

    string filterCommand = commandInfo[0];
    string filter = commandInfo[1];
    string value = commandInfo[2];

    if (filterCommand == "Add filter")
    {
        operations.Add($"{filter};{value}");
    }
    else
    {
        operations.Remove($"{filter};{value}");
    }
        
}
//Func<List<string>, string, string, List<string>> filterNames =
//    (names, operation, value) =>
//    {
//        return operation == "Starts with"
//        ? names.Where(x => x.StartsWith(value)).ToList()
//        : operation == "Ends with"
//        ? names.Where(x => x.EndsWith(value)).ToList()
//        : operation == "Contains"
//        ? names.Where(x => x.Contains(value)).ToList()
//        : names.Where(x => x.Length == int.Parse(value)).ToList();
//    };

Dictionary<string, Func<string, string, bool>> predicates = new()
{
    { "Starts with", (name, value) => name.StartsWith(value) },
    { "Ends with", (name, value) => name.EndsWith(value) },
    { "Contains", (name, value) => name.Contains(value) },
    { "Lenght", (name, value) => name.Length == int.Parse(value) },

};
foreach (string item in operations)
{
    string[] operationInfo = item.Split(";",StringSplitOptions.RemoveEmptyEntries);

    string operation = operationInfo[0];
    string value = operationInfo[1];

    //List<string> filterdNames = filterNames(names, operation, value);

    //names = names.Where(x => !filterdNames.Contains(x))
    //    .ToList();
   names = names.Where(name => !predicates[operation](name, value)).ToList();
}

Console.WriteLine(string.Join(' ', names));