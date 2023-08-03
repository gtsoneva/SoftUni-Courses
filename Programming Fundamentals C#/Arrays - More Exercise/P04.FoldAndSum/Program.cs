int[] arrayOfNumbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int foldPoint = arrayOfNumbers.Length / 4;
int[] newArray = new int[foldPoint * 2];

for (int i = 0; i < foldPoint; i++)
{
    newArray[i] = arrayOfNumbers[i + foldPoint] + arrayOfNumbers[foldPoint - 1 - i];
    newArray[i + foldPoint] = arrayOfNumbers[i + 2 * foldPoint] + arrayOfNumbers[arrayOfNumbers.Length - 1 - i];
}

Console.WriteLine(string.Join (' ', newArray));