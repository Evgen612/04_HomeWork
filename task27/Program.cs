// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("введите число: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine($"сумма цифр в числе {A} -->{SumNums(A)}");

int SumNums(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}


