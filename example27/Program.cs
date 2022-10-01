/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int userNumber = ReadInt("Введите число: ");
int length = NumberLength(userNumber);
SumNumbers(userNumber, length);

int ReadInt(string number)
{
    Console.Write(number);
    return Convert.ToInt32(Console.ReadLine());
}
int NumberLength(int i)
{
    int index = 0;
    while (i > 0)
    {
        i /= 10;
        index++;
    }
    return index;
}
void SumNumbers(int n, int length)
{
    int sum = 0;
    for (int i = 1; i <= length; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"Сумма цифр числа равна {sum}");
}
