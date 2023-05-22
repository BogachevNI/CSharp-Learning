//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

// int[] createRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void printArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine(); // для новой строки
// }

// void PosNegSum(int[] array)
// {
//     int sumPos = 0;
//     int sumNeg = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] >= 0) sumPos += array[i];
//         else sumNeg += array[i];
//     }
//     Console.WriteLine($"Sum of positive elements -> {sumPos}, sum of negative elements -> {sumNeg} ");
// }

// Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input array minimum: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input array maximum: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = createRandomArray(size, min, max);
// printArray(myArray);

// PosNegSum(myArray);

//Задача 2. Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.

//[-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] createRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//        newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void printArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " "); // чтобы вывод был в строку, а не в столбец;
//     }
//     Console.WriteLine(); // для новой строки
// }

// int[] invertArray (int[]array)
// {
//     for (int i = 0; i <array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     return array;
// }

// Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input array minimum: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input array maximum: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = createRandomArray(size, min, max);
// printArray(myArray);
// myArray = invertArray(myArray);
// printArray(myArray);

//Задача 3.Задайте массив. 
// Напишите программу, которая определяет, присутствует ли заданное число в массиве. Переписать метод для ручного ввода.

int[] createArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue +1);
        Console.Write(newArray[i]+" ");
    }
    Console.WriteLine();
    return newArray;
}

bool isInArray(int[] array, int searchedValue)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (searchedValue == array[i]) return true;
    }
    return false;
}

Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input array minimum: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input array maximum: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input searched value: ");
int searchedValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = createArray(size, min, max);

Console.WriteLine(isInArray(myArray, searchedValue));

//Задача 4.****Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

//*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

// int[] createArray(int size, int min, int max)
// {
//     int[] myArray = new int[size];
//     for( int i =0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(min, max +1);
//         Console.Write(myArray[i] + " ");
//     }
//     Console.WriteLine();
//     return myArray;
// }

// int FindElementsNum(int[] array, int min, int max)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] >= min && array[i] <= max)
//         {
//             result ++;
//         }
//     }
//     return result;
// }

// int[] newArray = createArray(123, 0, 200);
// Console.Write($"Количество элементов больше 10 и меньше 99 равно {FindElementsNum(newArray, 10, 99)}");