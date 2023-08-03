int[] arrayOfNumbers = Console.ReadLine()
    .Split()
	.Select(int.Parse)
	.ToArray();
int count = 1;
int longestSequence = 0;
int index = 0;
for (int i = 0; i < arrayOfNumbers.Length-1; i++)
{
if (arrayOfNumbers[i] == arrayOfNumbers[i+1])
		{
			count++;
		}
		else
		{
		count = 1; ;
		}
			if (count>longestSequence)
			{
		longestSequence = count;
		index = arrayOfNumbers[i];
	}
}
for (int j = 1; j <= longestSequence; j++)
{
    Console.Write(index + " ");
}