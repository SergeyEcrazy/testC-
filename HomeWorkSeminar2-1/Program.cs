// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 5
// 782 -> 8
// 918 -> 1 

System.Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

int Search(int Number)
{
    int result = (number % 100) / 10;
    if (number > 99 && number < 1000) System.Console.Write($"{result} - вторая цифра числа {number}");
else
{
    if (number > -1000 && number < -99) System.Console.Write($"{result * -1} - вторая цифра числа {number}");
    else
    {
        System.Console.WriteLine($"Число {number} не трехзначное!!!");
    }
}
return number;
}

int result = Search(number);