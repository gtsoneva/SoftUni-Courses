string[] firstArray = Console.ReadLine()
    .Split();
string[] secondArray = Console.ReadLine()
    .Split();

for (int i = 0; i < secondArray.Length; i++)
{
    string currentElement = secondArray[i];

    if (firstArray.Contains(currentElement))
    {
        Console.Write($"{currentElement} ");
    }
}