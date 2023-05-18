//Задача 1. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// int digitCount (int number)
// {
//     int count = 0;
//     while(number > 0)
//     {
//         count++;
//         number/=10;
//     }
//     return count;
// }

// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Number of digits in {num} -> {digitCount(num)}");

//Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в 
//случайном порядке.
// [1,0,1,1,0,1,0,0]

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
//     Console.WriteLine();
// }

// Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input array minimum: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input array maximum: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = createRandomArray(size, min, max);
// printArray(myArray);

//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

//4  -> 24
//5  -> 120

// Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int factorial(int N)
// {
//     int result = 1;
//     for (int i = 1; i <= N; i++)
//     {
//         result *= i;
//     }
//     return result;
// }

// Console.WriteLine($"{number} -> {factorial(number)}");

//Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int Sum(int N)
// {
//     int result = 0;
//     for (int i = 1; i <= N; i++)
//     {
//         result += i;
//     }
//     return result;
// }

// Console.WriteLine($"{number} -> {Sum(number)}");
