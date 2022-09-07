// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, 
// y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Console.WriteLine("Введите значение b1:");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k1:");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2:");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k2:");
int k2 = int.Parse(Console.ReadLine());


void CheckSameK1(int b1, int k1, int b2, int k2)
{
    if (k1 != k2)
    {
        int x = (b2 - b1)/(k1 - k2);
        int y = k2 * x + b2;
        Console.WriteLine($"x = {x}, y = {y}");
    }
    else
    {
        Console.WriteLine("Прямые параллельны. Решений нет!");
    }
}


CheckSameK1(b1, k1, b2, k2);
