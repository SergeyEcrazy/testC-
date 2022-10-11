// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 46
// 782 -> 72
// 918 -> 98 

int random = new Random().Next(-999, 1000);

int FilNumber(int numb)
{
    System.Console.Write($"Случайное трехзначное число: {random} ");
    return numb;
}
int DelNumber(int N)
{
    int n1 = (N % 1000) / 100;
    int n2 = random % 10;
    if (N > 100 && N < 1000) System.Console.Write($"-> {n1}{n2}");
    else
    {
    if (N > -999 && N < -99) System.Console.Write($"-> {n1}{n2 * -1}");
    else
    {
        System.Console.Write("- число не трехзначое!");
    }
    }

    return N;
}
int result = (DelNumber(FilNumber(random)));

