// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Input first number: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number: ");
// int B = Convert.ToInt32(Console.ReadLine());

// double Result(int A, int B)
// {
//     double result = Math.Pow(A, B);
//     return result;
// }
// Console.WriteLine($"{A}, {B} -> {Result(A, B)}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int inputNumber()
// {
//     Console.Write("Input number: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// int Sum(int number)
// {
//     int sum = 0;
//     while (number > 0)
//     {
//         sum = sum + (number % 10);
//         number = number / 10;
//     }
//     return sum;
// }
// int num = inputNumber();
// Console.WriteLine($"{num} -> {Sum(num)}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int Prompt(string message)
// {
//     Console.Write(message);
//     int inputNumber = Convert.ToInt32(Console.ReadLine());
//     return inputNumber;
// }

// int input = Prompt("Input size: ");
// int min = Prompt("Input array minimum value: ");
// int max = Prompt("Input array maximum value: ");

// int[] createNewRandomArray(int inputNumber, int minValue, int maxValue)
// {
//     int[] array = new int[inputNumber];
//     for (int i = 0; i < inputNumber; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void printArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] newArray = createNewRandomArray(input, min, max);
// printArray(newArray);