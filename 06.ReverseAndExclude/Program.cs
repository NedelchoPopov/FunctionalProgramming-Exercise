/*
1 2 3 4 5 6
2

20 10 40 30 60 50
3

 */

int[] inputNumbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .Reverse()
    .ToArray();

int n = int.Parse(Console.ReadLine());

Func<int, int, bool> filter = (number, div) 
    => number % div == 0;

int[] result = inputNumbers
    .Where(x => !filter(x, n))
    .ToArray();

Console.WriteLine(string.Join(" ", result));