/* Напишите программу, которая из массива случайных чисел. Ищет второй максимум (число меньше 
максимального элемента, но больше всех остальных). Постарайтесь сделать одним циклом 
[1, 3, 5, 6, 6, 4] -> 5 */

Console.Clear();

int InputNumber(string message)
{
    System.Console.Write(message);
    int number = int.Parse(System.Console.ReadLine());
    return number;
}

void FillArray(int[] values)
{
    for (int i = 0; i < values.Length; i++)
    {
        values[i] = new Random().Next(0, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void SearchSecondMax(int[] array)
{
    int max = array[0];
    int secondMax = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            secondMax = max;
            max = array[i];
        }
        if (secondMax == max)
        {
            if (i < array.Length - 1)
            {
                secondMax = array[i + 1];
            }
        }
        if (array[i] > secondMax & array[i] != max)
        {
            secondMax = array[i];
        }
    }
    if (secondMax == max)
    {
        System.Console.WriteLine("Все числа в массиве максимальны!");
    }
    else
    {
        System.Console.WriteLine($"{secondMax} >>>> второй максимальный элемент данного массива");
    }
}

int number = InputNumber("Введите длину массива: ");
int[] myArray = new int[number];
FillArray(myArray);
PrintArray(myArray);
SearchSecondMax(myArray);