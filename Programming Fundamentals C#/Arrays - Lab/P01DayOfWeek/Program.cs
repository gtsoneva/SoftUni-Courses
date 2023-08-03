string[] dayOfWeek = {"Monday","Tuesday","Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
int day = int.Parse(Console.ReadLine());

switch (day)
{
	case 1:
    case 2:
    case 3:
    case 4:
    case 5:
    case 6:
    case 7:
        Console.WriteLine(dayOfWeek[day - 1]);
		break;
    default:
        Console.WriteLine("Invalid day!");
        break;
}