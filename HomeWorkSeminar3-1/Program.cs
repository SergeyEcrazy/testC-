// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да 

int InputNumber(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}
bool VerificationNumbers(int numbers)
{
    if (numbers < 10000)
    {
        System.Console.WriteLine("Число не пятизначное!!!");
        return false;
    }
    return true;
}
bool IsPalindrome(int number)
{
    int initialNumber = number;
    int reverse = 0;
    while (number > 0)
    {
        int value = number % 10;
        reverse = reverse * 10 + value;
        number /= 10;
    }
    return initialNumber == reverse;
}
int numbers = InputNumber("Введите здесь пятизначное число ------>> ");
if (!VerificationNumbers(numbers))
{
    return;
}
if (IsPalindrome(numbers))
{
    System.Console.WriteLine($"Число {numbers} является полиндромом");
}
else
{
    System.Console.WriteLine($"Число {numbers} не является полиндромом");
}