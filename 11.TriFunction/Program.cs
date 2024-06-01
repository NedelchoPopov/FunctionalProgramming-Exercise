/*
350
Rob Mary Paisley Spencer

666
Paul Thomas William

 */

int asciiSum = int.Parse(Console.ReadLine());
string[] names = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

Func<string, int, bool> filter = (name, sum) =>
name.Sum(x => x) >= sum;

Func<string[], Func<string, int, bool>, string> filterFirstName
    = (allNames, functFilter) =>
    allNames.FirstOrDefault(x => functFilter(x, asciiSum));

Console.WriteLine(filterFirstName(names, filter));

