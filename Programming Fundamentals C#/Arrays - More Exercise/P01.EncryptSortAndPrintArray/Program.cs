


using System;

int number = int.Parse(Console.ReadLine());
int[] arrayOfSum = new int[number];

int sum = 0;
int sumVowels = 0;
int sumConsonant = 0;
for (int i = 0; i < number; i++)
{
    string sequence = Console.ReadLine();


    for (int j = 0; j < sequence.Length; j++)
    {

        char currentLetter = sequence[j];

        if ((currentLetter == 97) || (currentLetter == 101) || (currentLetter == 105) || (currentLetter == 111) || (currentLetter == 117) ||
            (currentLetter == 65) || (currentLetter == 69) || (currentLetter == 73) || (currentLetter == 79) || (currentLetter == 85))
        {
            sumVowels += currentLetter * sequence.Length;
        }
        else
        {
            sumConsonant += currentLetter / sequence.Length;
        }

    }
    sum = sumVowels + sumConsonant;
    arrayOfSum[i] = sum;

    sum = 0;
    sumVowels = 0;
    sumConsonant = 0;
}
Array.Sort(arrayOfSum);
for (int i = 0; i < arrayOfSum.Length; i++)
{
    Console.WriteLine(arrayOfSum[i]);

}
