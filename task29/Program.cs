// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Массив из 8 элементовю");


Console.WriteLine($"Полученный массив: ");
PrintArray(FillArray(8));

int[] FillArray(int size)
{
    int[] array = new int[size];
    for(int i = 0;  i < array.Length; i++)
    {
        array[i] = new Random(). Next(-99, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[7] + ", ");
}


