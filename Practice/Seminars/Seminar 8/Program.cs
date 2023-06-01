//Задание 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//В итоге получается вот такой массив:
//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7

// int[,] RowsToColumns(int[,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1))
//     {
//         Console.WriteLine("Invalid input");
//         return array;
//     }
//     else
//     {
//         for (int i = 0; i < array.GetLength(0) - 1; i++)
//         {
//             for (int j = i + 1; j < array.GetLength(1); j++)
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array[j, i];
//                 array[j, i] = temp;
//             }
//         }
//     }
//     return array;
// }

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

// int[,] myArray = create2DRandomArray(rows, columns, min, max);
// print2DArray(myArray);

// myArray = RowsToColumns(myArray);
// print2DArray(myArray);


//Задание 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// то есть удалаем и строку и столбец в которой находится этот элемент

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

// int[,] findMinimum(int[,] array)
// {
//     //int min = array[0,0];
//     int minRow = 0;
//     int minCol = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < array[minRow, minCol])
//             {
//                 minRow = i;
//                 minCol = j;
//             }
//         }
//     }
//     //return array[minRow,minCol];

//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         array[i,minCol] = 0;
//     }
//     for (int j=0;j<array.GetLength(1);j++)
//     {
//         array[minRow,j] = 0;
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
// //Console.WriteLine($"Минимальное значение массива: {findMinimum(myArray)}");
// myArray = findMinimum(myArray);
// print2DArray(myArray);

//Задание 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//8 4 2 4
//5 9 2 3
//1 4 7 2

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

int[,] SwitchRows(int[,] array)
{
    int temp;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp = array[0,j];
        array[0,j] = array[array.GetLength(0)-1,j];
        array[array.GetLength(0)-1,j] = temp;
    }
    return array;
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
myArray = SwitchRows(myArray);
print2DArray(myArray);