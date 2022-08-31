Console.WriteLine ("Введите координату x: ");
int x = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите координату y: ");
int y = int.Parse (Console.ReadLine());

if ((x != 0) && (y != 0))
{
    if ((x > 0) && (y > 0))
    {
        Console.WriteLine("1 четверть плоскости координат!");
    }
    else if ((x > 0) && (y < 0))
    {
        Console.WriteLine("2 четверть плоскости координат!");
    }
    else if ((x < 0) && (y > 0))
    {
        Console.WriteLine("3 четверть плоскости координат!");
    }
    else if ((x < 0) && (y < 0))
    {
        Console.WriteLine("4 четверть плоскости координат!");
    }
}
