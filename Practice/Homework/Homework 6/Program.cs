// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Input quantity of numbers: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] myArray = createArrayManually(size);
// //printArray(myArray);
// Console.WriteLine($"The quantity of positive numbers in array is {countPositiveNumbers(myArray)}");

// int[] createArrayManually(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.WriteLine($"Input {i + 1} element: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// // void printArray(int[] array)
// // {
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         Console.Write(array[i] + " ");
// //     }
// //     Console.WriteLine();
// // }

// int countPositiveNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count++;
//     }
//     return count;
// }

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//y = k1*x+b1; y = k2*x+b2;
//k1*x+b1 = k2*x+b2;    5x+2 = 9x+4;
//k1*x-k2*x = b2-b1;      5x-9x = 4-2;
//x = (b2-b1)/(k1-k2);     x=(4-2)/(5-9); 

double k1 = coefInput("Input k1 of line 1:");
double b1 = coefInput("Input b1 of line 1:");
double k2 = coefInput("Input k2 of line 2:");
double b2 = coefInput("Input b2 of line 2:");
double[] pointOfIntersection = computeIntersection(k1, b1, k2, b2);
printArray(pointOfIntersection);

double coefInput(string message)
{
    Console.WriteLine(message);
    double inputNumber = Convert.ToInt32(Console.ReadLine());
    return inputNumber;
}
double[] computeIntersection(double k1, double b1, double k2, double b2)
{
    double[] pointOfIntersection = {k1, k2};

    for (int i = 0; i < pointOfIntersection.Length; i++)
    {
        if (i == 0) pointOfIntersection[i] = (b2 - b1) / (k1 - k2);
        else pointOfIntersection[i] = k1 * pointOfIntersection[i - 1] + b1;
    }
    return pointOfIntersection;
}

void printArray(double[] pointOfIntersection)
{
    for (int i = 0; i < pointOfIntersection.Length; i++)
    {
        Console.Write(pointOfIntersection[i] + " ");
    }
    Console.WriteLine();
}