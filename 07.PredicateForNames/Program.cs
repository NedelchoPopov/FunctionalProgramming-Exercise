/*
4
Karl Anna Kris Yahto

4
Karl James George Robert Patricia

 */

int n = int.Parse(Console.ReadLine().Trim());

string[] inputNames = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

Func<int, string, bool> filter = (lenght, name)
    => lenght >= name.Length;

string[] result = inputNames
    .Where(name => filter(n, name))
    .ToArray();

Console.WriteLine(string.Join(Environment.NewLine, result));
//Console.ReadLine()
//    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
//    .Where(x => filter(n, x))
//    .ToList()
//    .ForEach(Console.WriteLine);