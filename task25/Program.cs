// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("введите число A: ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("введите число B: ");
int B = int.Parse(Console.ReadLine());


Console.WriteLine($"{A} , {B} -->{NatDegree(A, B)}");


int NatDegree(int number, int count)
{
    int sum = 1;
   
    while(count > 0)
    {
        sum = sum * number;
        count--;
    }
return sum;
}

