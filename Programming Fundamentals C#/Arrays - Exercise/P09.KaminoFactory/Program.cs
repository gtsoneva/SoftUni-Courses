

int dnaLength = int.Parse(Console.ReadLine());

int[] longestSequence = new int[dnaLength];
int bestSequenceStartIndex = 0;
int bestSequenceSum = 0;
int bestLength = 0;
int dnaNumber = 0;
int count = 0;



while (true)
{
    string input = Console.ReadLine();
    if (input == "Clone them!")
    {
        break;
    }
    count++;
    int[] currentSequence = input
        .Split("!", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    int bestCurrentLength = 0;
    int currentStartIndex = 0;
    int currentSequenceSum = 0;



    foreach (var item in currentSequence)
    {
        if (item == 1)
        {
            bestCurrentLength++;
        }
        else if (item == 0 && bestCurrentLength > 0)
        {
            break;
        }
    }

    currentStartIndex = Array.IndexOf(currentSequence, 1);
    currentSequenceSum = currentSequence.Sum();


    if ((bestCurrentLength > bestLength) ||
        (bestCurrentLength == bestLength && currentStartIndex < bestSequenceStartIndex) ||
        (bestCurrentLength == bestLength && currentStartIndex <= bestSequenceStartIndex && currentSequenceSum > bestSequenceSum))
    {
        bestLength = bestCurrentLength;
        bestSequenceStartIndex = currentStartIndex;
        bestSequenceSum = currentSequenceSum;
        longestSequence = currentSequence.ToArray();
        dnaNumber = count;
    }


}


Console.WriteLine($"Best DNA sample {dnaNumber} with sum: {bestSequenceSum}.");
Console.WriteLine(string.Join(" ", longestSequence));