// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
// в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53 

const int X = 0;
const int Y = 1;
const int Z = 2;

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}

int[] InputPoint(int point)
{
    int[] answer = new int[3];
    answer[X] = Prompt($" Введите координаты точки X{point} --->> ");
    answer[Y] = Prompt($" Введите координаты точки Y{point} --->> ");
    answer[Z] = Prompt($" Введите координаты точки Z{point} --->> ");
    return answer;
}

double Power2(int arg)
{
    return Math.Pow(arg, 2);
}

int[] p1 = InputPoint(1);
int[] p2 = InputPoint(2);

double lenght = Math.Sqrt(
Power2(p1[X] - p2[X]) + 
Power2(p1[Y] - p2[Y]) + 
Power2(p1[Z] - p2[Z]));
Console.WriteLine($"{lenght:f2}");
