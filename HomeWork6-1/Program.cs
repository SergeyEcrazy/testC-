/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
Разделить ввод данных, от расчета данных (Одна функция вводит данные, другая функция подсчитывает количество положительных)
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int InputNumber(string message)
{
    System.Console.Write(message);
    int number = int.Parse(Console.ReadLine() ??"0");
    return number;
}

int[] FillArray(int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\nВведите значение индекса {i}:\t");
        array[i] = int.Parse(Console.ReadLine() ??"0");
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine("\nВывод массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
}

int PositiveElements(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum++;
    }
    Console.Write($"Положительных элементов: {sum}");
    return sum;
}

int number = InputNumber("Задайте длину массива: ");
int[] myArray = FillArray(number);
PrintArray(myArray);
PositiveElements(myArray);

