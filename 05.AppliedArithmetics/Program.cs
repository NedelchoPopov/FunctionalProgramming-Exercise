/*
1 2 3 4 5
add
add
print
end

5 10
multiply
subtract
print
end

 */

int[] inputNumbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

string command;

Func<int[], string, int[]> applyAritmetics
    = (numbers, operation) =>
    {
        return operation == "add"
        ? numbers.Select(x => x + 1).ToArray()
        : operation == "multiply"
        ? numbers.Select(x => x * 2).ToArray()
        : numbers.Select(x => x - 1).ToArray();
    }; 

while ((command = Console.ReadLine()) != "end")
{
    if (command == "print")
    {
        Console.WriteLine(string.Join(" ", inputNumbers));
    }
    else
    {
        inputNumbers = applyAritmetics(inputNumbers, command);
    }
}
    