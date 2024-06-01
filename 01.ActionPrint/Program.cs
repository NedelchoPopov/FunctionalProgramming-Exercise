/*

Lucas Noah Tea

Teo Lucas Harry

Ashurbanipal Napoleon Caeser

 */
string[] names = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

Action <string[]> printNames = allNames =>
Console.WriteLine(string.Join(Environment.NewLine, allNames));

printNames(names);