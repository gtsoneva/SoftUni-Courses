using System;

int[] firstArray = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int sum = 0;
int[] secondArray = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i] == secondArray[i])
    {
        sum += firstArray[i];
        continue;
    }
    if (firstArray[i] != secondArray[i])
    {
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
            return;
    }
}
Console.WriteLine($"Arrays are identical. Sum: {sum}");


