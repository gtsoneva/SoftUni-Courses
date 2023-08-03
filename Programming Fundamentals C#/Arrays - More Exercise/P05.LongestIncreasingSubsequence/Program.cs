int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int maxLength = 0;
int lastIndex = -1;
int[] lenghtOfLongestSequence = new int[numbers.Length];
int[] previousPosition = new int[numbers.Length];

for (int i = 0; i < numbers.Length; i++)
{
    lenghtOfLongestSequence[i] = 1;
    previousPosition[i] = -1;

    for (int j = 0; j < i; j++)
    {
        if (numbers[j] < numbers[i] && lenghtOfLongestSequence[j] + 1 > lenghtOfLongestSequence[i])
        {
            lenghtOfLongestSequence[i] = lenghtOfLongestSequence[j] + 1;
            previousPosition[i] = j;
        }
    }
    if (lenghtOfLongestSequence[i] > maxLength)
    {
        maxLength = lenghtOfLongestSequence[i];
        lastIndex = i;
    }
}
int[] LIS = new int[maxLength];
int currentIndex = maxLength - 1;

while (lastIndex != -1)
{
    LIS[currentIndex] = numbers[lastIndex];
    currentIndex--;
    lastIndex = previousPosition[lastIndex];
}

Console.WriteLine(string.Join(" ", LIS));
        