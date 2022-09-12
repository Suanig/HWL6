// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Программа вычисления координат точки пересечения линий, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.Write("Введите число параметр k1 первой прямой: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число параметр b1 первой прямой: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число параметр k2 второй прямой: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число параметр b2 второй прямой: ");
int b2 = Convert.ToInt32(Console.ReadLine());

double cross(int k1, int k2, int b1, int b2)
{
    int crossX = 0;
    crossX = (b2 - b1) / (k1 - k2);
    return crossX;
}

if (k1 == k2)
{
    Console.Write("Прямые с заданными параметрами параллельны");
}
else
{
    double x = cross(k1, k2, b1, b2);
    double y = (x * k1) + b1;
    Console.WriteLine($"Координаты точки пересечения прямых = ({x};{y})");
}