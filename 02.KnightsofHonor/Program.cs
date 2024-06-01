/*

Eathan Lucas Noah Arthur

Lucas Jade Hugo

Ashurbanipal Napoleon Caeser

 */


using System.Threading.Channels;

string[] names = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

Action <string[]> addHonor = allNmaes =>
Console.WriteLine(string.Join(Environment.NewLine,
(allNmaes.Select(name => "Sir " + name))));

addHonor(names);