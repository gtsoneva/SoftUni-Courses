string[] array = Console.ReadLine()
    .Split()
    .ToArray();
array = array.Reverse().ToArray();
Console.WriteLine(string.Join(' ',array));
