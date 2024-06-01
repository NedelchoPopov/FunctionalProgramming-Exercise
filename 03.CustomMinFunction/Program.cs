/*
1 4 3 2 1 7 13

4 5 -2 3 -5 8

 */

int[] inputNumbers = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Func<int[], int> getMinNumbers = n =>
n.Min(x => x);

Console.WriteLine(getMinNumbers(inputNumbers));

