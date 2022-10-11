// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6 

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int PrintNumber(int msg)
{
    if (msg > 99) System.Console.Write($"-> {msg % 10}");
    else
    {
        if (msg < -99) System.Console.Write($"-> {(msg % 10) * -1}");
        else
        {
            System.Console.Write("-> число не трехзначое!");
        }
    }
    return msg;
}
int DevisionNumber(int N)
{
    while (N > 1000 || N < -1000)
    {
        N /= 10;
    }
    System.Console.Write($"{number} ");
    return N;
}

int max = (PrintNumber(DevisionNumber(number)));