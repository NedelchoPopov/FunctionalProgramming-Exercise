/*
10
1 1 1 2

100
2 5 10 20

 */

int range = int.Parse(Console.ReadLine());
List<int> numbers = Enumerable.Range(1, range)
    .ToList();

int[] dividers = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Func<int, int[], bool> isDivisible = (number, divs) =>
divs.All(x => number % x == 0);

List<int> result = numbers
    .Where(number => isDivisible(number, dividers))
    .ToList();

Console.WriteLine(string.Join(" ", result));