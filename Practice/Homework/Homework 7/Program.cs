// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     double[,] newArray = new double[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
//         }
//     }
//     return newArray;
// }

// void print2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine(); // для новой строки
// }

// Console.WriteLine("Input array row amount: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input array column amount: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input array minimum: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input array maximum: ");
// int max = Convert.ToInt32(Console.ReadLine());
// double[,] myArray = create2DRandomArray(rows, columns, min, max);
// print2DArray(myArray);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine(); // для новой строки
// }

// void printElement(int[,] array, int indexR, int indexC)
// {
//     if (indexR < array.GetLength(0) && indexC < array.GetLength(1)) Console.WriteLine($"Значение, соответствующее введённым индексам: {array[indexR, indexC]}");
//     else Console.WriteLine($"Значения, соответствующего введённым индексам, не существует в массиве!");
// }

// Console.WriteLine("Input array row amount: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input array column amount: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input array minimum: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input array maximum: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = create2DRandomArray(rows, columns, min, max);
// print2DArray(myArray);

// Console.WriteLine("Input array row index: ");
// int indexRow = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input array column index: ");
// int indexCol = Convert.ToInt32(Console.ReadLine());
// printElement(myArray, indexRow, indexCol);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine(); // для новой строки
}

double[,] createAverageArray(int[,] array)
{
    double[,] arrayAverageByCol = new double[1,array.GetLength(1)];
    int i, j;
    double avg;
     for (j = 0; j < array.GetLength(1); j++)
     {
        avg = 0;
        for (i = 0; i < array.GetLength(0); i++)
        {
            avg += array[i,j];
        }
        avg /= array.GetLength(0);
        arrayAverageByCol[0,j] = avg;
     }
     return arrayAverageByCol;
}

void printArrayAvg(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine(); // для новой строки
}

Console.WriteLine("Input array row amount: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input array column amount: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input array minimum: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input array maximum: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = create2DRandomArray(rows, columns, min, max);
print2DArray(myArray);
double[,] arrayAverageByCol = createAverageArray(myArray);
printArrayAvg(arrayAverageByCol);