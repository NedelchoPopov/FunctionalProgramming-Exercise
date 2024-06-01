/*
1 10
odd

20 30
even

 */

int[] range = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

string type = Console.ReadLine();



int start = range[0];
int end = range[1];

var numbers = Enumerable.Range(start, end - start + 1)
    .ToList();

Predicate<int> isEven = x => x % 2 == 0;
//Predicate<int> isOdd = x => x % 2 != 0;

var filter = numbers.FindAll(x => type == "even"
? isEven(x)
: !isEven(x));

var result = string.Join(" ", filter);

Console.WriteLine(result);

