// Вывести массив MxN
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

//Задача 4. задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

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
//     // Console.WriteLine(); // для новой строки
// }

// int CalcDiag(int[,] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i==j) sum+= array[i,j];
//         }
//     }
//     return sum;
// }

// Console.WriteLine("Input 2D-array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Input array column amount: ");
// // int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input array minimum: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input array maximum: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = create2DRandomArray(size, size, min, max);
// print2DArray(myArray);
// Console.WriteLine($"Сумма элементов главной диагонали равна {CalcDiag(myArray)}");

// Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

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
//     // Console.WriteLine(); // для новой строки
// }

// int[,] Pow2(int[,] array)
// {
//     int [,] newArray = array;
//     for (int i = 0; i < newArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < newArray.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0) newArray[i,j] = newArray[i,j]*newArray[i,j];
//         }
//     }
//     return newArray;
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
// Console.WriteLine();
// int[,] newArray = Pow2(myArray);
// print2DArray(newArray);

//Задача 2. ****Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.

int[,] create2DRandomArray(int rows, int columns/*, int minValue, int maxValue*/)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = i+j;
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
    // Console.WriteLine(); // для новой строки
}

Console.WriteLine("Input array row amount: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input array column amount: ");
int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input array minimum: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input array maximum: ");
// int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = create2DRandomArray(rows, columns/*, min, max*/);
print2DArray(myArray);