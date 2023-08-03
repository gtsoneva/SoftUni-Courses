int n = int.Parse(Console.ReadLine());

int[] numbers = new int[n];

for (int i = 0; i < numbers.Length; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    numbers[i] = currentNumber;
}
numbers = numbers.Reverse().ToArray();
Console.WriteLine(string.Join(' ', numbers));

