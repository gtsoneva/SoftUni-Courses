int number = int.Parse(Console.ReadLine());

int[] firstArray = new int[number];
int[] secondArray = new int[number];

for (int i = 0; i < number; i++)
{
    int[] currentNumber = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

    if (i % 2 == 0)
    {
        firstArray[i] = currentNumber[0];
        secondArray[i] = currentNumber[1];
    }
    else
    {
        firstArray[i] = currentNumber[1];
        secondArray[i] = currentNumber[0];
    }
}
Console.WriteLine(string.Join(' ', firstArray));
Console.WriteLine(string.Join(' ', secondArray));