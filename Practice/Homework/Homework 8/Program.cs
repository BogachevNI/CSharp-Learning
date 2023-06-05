// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

// int[,] sortInRows(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             int max = array[i, j];
//             for (int k = j + 1; k < array.GetLength(1); k++)
//             {
//                 if (max < array[i, k])
//                 {
//                     max = array[i, k];
//                     array[i,k] = array[i,j];
//                     array[i,j] = max;
//                 }
//             }
//         }
//     }
//     return array;
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
// myArray = sortInRows(myArray);
// print2DArray(myArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
//     Console.WriteLine(); // для новой строки-пропуска
// }

// int[] SumRowArray(int[,] array)
// {
//     int[] SumByRowArray = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i, j];
//             SumByRowArray[i] = sum;
//         }
//     }
//     return SumByRowArray;
// }

// void defineLowerstSumByRow(int[] array)
// {
//     int minSum = 0;
//     int minSumIndex = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[i] < array[j]) 
//             {
//                 minSum = array[i];
//                 minSumIndex = i;
//             }
//             else 
//             {
//                 minSum = array[j];
//                 minSumIndex = j;
//             }
//         }
//     }
//     Console.WriteLine($"Row with lowest sum is {minSumIndex + 1}");
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
// int[] mySumByRowArray = SumRowArray(myArray);
// defineLowerstSumByRow(mySumByRowArray);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

// int ReturnElement(int[,] array1, int[,] array2, int I, int K)
// {
//     int result = 0;
//     for (int j = 0; j < array1.GetLength(1); j++)
//     {
//         result += ReturnMultiplification(array1, array2, I, K, j);
//     }
//     return result;
// }

// int ReturnMultiplification(int[,] array1, int[,] array2, int i, int k, int j)
// {
//     return array1[i, j] * array2[j, k];
// }

// Console.WriteLine("Input array row amount of first matrix: ");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input array column amount of first matrix: ");
// int columns1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input array minimum: ");
// int min1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input array maximum: ");
// int max1 = Convert.ToInt32(Console.ReadLine());
// int[,] myArray1 = create2DRandomArray(rows1, columns1, min1, max1);
// print2DArray(myArray1);

// Console.WriteLine("Input array row amount of second matrix: ");
// int rows2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input array column amount of second matrix: ");
// int columns2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input array minimum: ");
// int min2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input array maximum: ");
// int max2 = Convert.ToInt32(Console.ReadLine());
// int[,] myArray2 = create2DRandomArray(rows2, columns2, min2, max2);
// print2DArray(myArray2);

// int[,] myNewArray = new int[rows1, columns2];
// for (int i = 0; i < rows1; i++)
// {
//     for (int k = 0; k < columns2; k++)
//     {
//         myNewArray[i,k] = ReturnElement(myArray1, myArray2, i, k);
//     }
// }
// print2DArray(myNewArray);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] create2DArray(int size)
{
    int[,] array = new int[size, size];
    return array;
}
void FillRight(int[,] array, int IndexRow, int IndexCol, int k)
{
    int i = IndexRow;
    if (k == 0)
    {
        for (int j = IndexCol + k; j < array.GetLength(1) - k; j++)
        {
            IndexCol = j;
            array[i, j] = j + 1;
        }
        Console.WriteLine($"{IndexRow}, {IndexCol}, {k}");
        if (k < 2) FillDown(array, IndexRow, IndexCol, k);
    }
    else
    {
        for (int j = IndexCol + k; j < array.GetLength(1) - k; j++)
        {
            IndexCol = j;
            array[i, j] = array[i, j - 1] + 1;
        }
        Console.WriteLine($"{IndexRow}, {IndexCol}, {k}");
        if (k < 2) FillDown(array, IndexRow, IndexCol, k);
    }
}
void FillDown(int[,] array, int IndexRow, int IndexCol, int k)
{
    int j = IndexCol;
    for (int i = IndexRow + 1; i < array.GetLength(0) - k; i++)
    {
        IndexRow = i;
        array[i, j] = array[i - 1, j] + 1;
    }
    Console.WriteLine($"{IndexRow}, {IndexCol}, {k}");
    //return array;
    if (k < 2) FillLeft(array, IndexRow, IndexCol, k);
}
void FillLeft(int[,] array, int IndexRow, int IndexCol, int k)
{
    int i = IndexRow;
    for (int j = IndexCol - 1; j >= k; j--)
    {
        IndexCol = j;
        array[i, j] = array[i, j + 1] + 1;
    }
    Console.WriteLine($"{IndexRow}, {IndexCol}, {k}");
    if (k < 2) FillUp(array, IndexRow, IndexCol, k);
}
void FillUp(int[,] array, int IndexRow, int IndexCol, int k)
{
    int j = IndexCol;
    for (int i = IndexRow - 1; i > k; i--)
    {
        IndexRow = i;
        array[i, j] = array[i + 1, j] + 1;
    }
    Console.WriteLine($"{IndexRow}, {IndexCol}, {k}");
    k++;
    if (k < 2) FillRight(array, IndexRow, IndexCol, k);
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
    Console.WriteLine(); // для новой строки-пропуска
}

Console.WriteLine("Input the quantity of rows and columns: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] myArray = create2DArray(size);
FillRight(myArray, 0, 0, 0);
print2DArray(myArray);