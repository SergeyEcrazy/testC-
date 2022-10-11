// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write("Введите число: ");
int week = Convert.ToInt32(Console.ReadLine());

int PrintWeeks(int msg)
{
    if (msg >= 6 && msg <= 7) System.Console.Write($"{msg} -> Выходной день недели.");
    else
    {
        if (msg >= 1 && msg <= 5) System.Console.WriteLine($"{msg} -> Рабочая неделя.");
        else
        {
            System.Console.WriteLine($"{msg} -> Такой недели не существует.");
        }
    }
    return msg;
}


int max = PrintWeeks(week);

