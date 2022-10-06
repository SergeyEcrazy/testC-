// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да

System.Console.Write("Введите первое число: ");
int a = int.Parse (System.Console.ReadLine() ?? "0");
System.Console.Write("Введите второе число: ");
int b = int.Parse (System.Console.ReadLine() ?? "0");
if (b == a*a)
{
    System.Console.Write($"Число {a} является квадратом {b}.");
}
else
{
    System.Console.Write($"второе число не является квадратом первого.");
}