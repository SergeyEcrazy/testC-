/*  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

int InputNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine() ??"0");
    return number;
}

double[,] RandomMatrixFill(int lenRows, int lenColumns)
{
    double[,] array = new double[lenRows, lenColumns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-10, 10)) / 1.1;
        }
    }
    return array;
}

void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f1}\t");
        }
        Console.WriteLine();
    }
}

int firstNumber = InputNumber("Введите количество строк: ");
int secondNumber = InputNumber("Введите количество столбцов: ");
Console.WriteLine();
double[,] myArray = RandomMatrixFill(firstNumber, secondNumber);
PrintMatrix(myArray);