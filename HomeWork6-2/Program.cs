/*  Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */


double InputNumber(string message)
{
    System.Console.Write(message);
    double number = double.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PointIntersectionLines(double arg1, double arg2, double arg3, double arg4)
{
    double x = 0;
    double y = 0;

    if (arg1 == arg2 && arg3 == arg4) Console.WriteLine("Прямые совпадают!!!");
    else
    {
        if (arg1 == arg3) Console.WriteLine("Прямые параллельны!!!");
        else
        {
            x = -(arg1 - arg2) / (arg3 - arg4);
            y = (arg2 * -(arg1 - arg3)) / (arg2 - arg4) + arg1;
            System.Console.WriteLine($"Точка пересечения прямых >>>> ({x};{y})");
        }
    }
}

double b1 = InputNumber("Введите число b1:");
double k1 = InputNumber("Введите число k1:");
double b2 = InputNumber("Введите число b2:");
double k2 = InputNumber("Введите число k2:");

PointIntersectionLines(b1, k1, b2, k2);
