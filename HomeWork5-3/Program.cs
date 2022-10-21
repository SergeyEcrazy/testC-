/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */


double[] CreateArray(int len)
{
    double[] array = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 100);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

double Max(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= max)
        {
            max = array[i];
        }
    }
    return max;
}

double Min(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double Difference(double min, double max)
{
    double sum = max - min;
    return sum;
}

double[] myArray = CreateArray(5);
PrintArray(myArray);
System.Console.WriteLine($"{Max(myArray)} - {Min(myArray)} = {Difference(Min(myArray), Max(myArray))}");



