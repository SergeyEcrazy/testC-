/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B 
(и в нулевую степень). Использовать свои функции, не использовать Math.Pow
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int InputNumber(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void MathPow(int values1, int values2)
{
    double result = 1;
    if (values2 >= 0)
    {
        for (int i = 0; i < values2; i++)
        {
            result = result * values1;
        }
        System.Console.WriteLine($"{values1}^{values2} = {result}");
    }
    else
    {
        if (values2 < 0)
        {
            for (int j = 0; j < values2 * -1; j++)
            {
                result = result * values1;
            }
        }
        System.Console.WriteLine($"{values1}^{values2} = {1 / result}");
    }
}

int numberOne = InputNumber("Введите первое любое число >>>>> ");
int numberTwo = InputNumber("Введите второе любое число >>>>> ");
MathPow(numberOne, numberTwo);