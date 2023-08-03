int wantedFibonacciNumber = int.Parse(Console.ReadLine());

int[] fibonacciSequence = new int[50];
fibonacciSequence[0] = 1;
fibonacciSequence[1] = 1;

if (wantedFibonacciNumber > 2)
{
    for (int i = 2; i < wantedFibonacciNumber; i++)
    {
        fibonacciSequence[i] = fibonacciSequence[i - 1] + fibonacciSequence[i - 2];
    }
}
Console.WriteLine(fibonacciSequence[wantedFibonacciNumber - 1]);
