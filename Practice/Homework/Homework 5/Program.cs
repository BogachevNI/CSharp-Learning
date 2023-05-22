// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
_refresh:
Console.WriteLine("Введите минимальное значение массива"); // 100
int min = Convert.ToInt32(Console.ReadLine());
if (min < 100)
{
    Console.WriteLine("Введено некорректное минимальное трехзначное число");
    goto _refresh;
}
_refresh1:
Console.WriteLine("Введите максимальное значение массива"); // 999
int max = Convert.ToInt32(Console.ReadLine());
if (max < min || max > 999)
{
    Console.WriteLine("Введено некорректное максимальное трехзначное число");
    goto _refresh1;
}

int[] array = createArray(size, min, max);
printArray(array);
Console.WriteLine($"Количество чётных чисел в массиве равно {countEvenNumbers(array)}");

int[] createArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

int countEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.WriteLine("Введите размерность массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение массива"); // 100
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение массива"); // 999
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = createArray(size, min, max);
// printArray(array);
// Console.WriteLine($"Сумма нечётных позиций массива равна {sumOddPos(array)}");

// int[] createArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void printArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]+" ");
//     }
//     Console.WriteLine();
// }

// int sumOddPos(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0) sum += array[i];
//     }
//     return sum;
// }

// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// Console.WriteLine("Введите размерность массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение массива");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение массива");
// int max = Convert.ToInt32(Console.ReadLine());

// double[] array = createArray(size, min, max);
// printArray(array);
// Console.WriteLine($"{difference(array)} - разница между максимальным и минимальным элементом массива");

// double[] createArray(int size, int min, int max)
// {
//     double[] array = new double[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//         array[i] += new Random().NextDouble();
//     }
//     return array;
// }

// void printArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]+" ");
//     }
//     Console.WriteLine();
// }

// double difference(double[] array)
// {
//     double diff;
//     double max = array[0];
//     double min = array[0];

//     for (int i = 1; i < array.Length; i++)
//     {
//         if (max < array[i]) max = array[i];
//         if (min > array[i]) min = array[i];
//     }
//     diff = max - min;
//     return diff;
// }