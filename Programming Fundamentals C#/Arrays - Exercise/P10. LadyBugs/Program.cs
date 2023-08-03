int fieldSize = int.Parse(Console.ReadLine());
int[] ladyBugIndexes = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] field = new int[fieldSize];

for (int i = 0; i < ladyBugIndexes.Length; i++)
{
    int bugStartIndex = ladyBugIndexes[i];
    if (bugStartIndex >= 0 && bugStartIndex < field.Length)
    {
        field[ladyBugIndexes[i]] = 1;
    }
}

string command = "";
while ((command = Console.ReadLine()) != "end")
{
    string[] instruction = command.Split();
    int ladyBugIndex = int.Parse(instruction[0]);
    string direction = instruction[1];
    int flyLength = int.Parse(instruction[2]);

    if (ladyBugIndex < 0 || ladyBugIndex > field.Length - 1 || field[ladyBugIndex] == 0)
    {
        continue;
    }
    field[ladyBugIndex] = 0;

    if (direction == "right")
    {
        int landIndex = ladyBugIndex + flyLength;

        if (landIndex > field.Length-1)
        {
            continue;
        }
        if (field[landIndex] == 1)
        {
            while (field[landIndex] == 1)
            {
                landIndex += flyLength;

                if (landIndex > field.Length - 1)
                {
                    break;
                }
            }
        }
        if (landIndex <= field.Length-1)
        {
            field[landIndex] = 1;
        }
    }
    
    else if (direction == "left")
    {
        int landIndex = ladyBugIndex - flyLength;

        if (landIndex < 0)
        {
            continue;
        }
        if (field[landIndex] == 1)
        {
            while (field[landIndex] == 1)
            {
                landIndex -= flyLength;

                if (landIndex < 0)
                {
                    break;
                }
            }
        }
        if (landIndex >= 0)
        {
            field[landIndex] = 1;
        }
    }
}
Console.WriteLine(string.Join(' ', field));