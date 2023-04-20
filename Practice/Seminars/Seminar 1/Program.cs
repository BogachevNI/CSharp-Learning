// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"You input {{{num}}} number");

// Task1. Запросить число и вывести его квадрат.

// Console.WriteLine("Input number 1: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Quad of {num} -> {Math.Pow(num, 2)}");

// Task2. Проверить, является ли первое число квадратом второго

// Console.WriteLine("Input number 1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number 2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 == Math.Pow(num2, 2))
// {
//     Console.WriteLine($"Число {num1} является квадратом {num2}");
// }
// else
// {
//     Console.WriteLine($"Число {num1} не является квадратом числа {num2}");
// }

// Task3. Написать программу, которая принимает на вход число N, а на выходе даёт последовательность от -N до N.

// Console.WriteLine("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n<0) Console.WriteLine("Invalid input");
// int count = n*(-1);
// while (count <= n)
// {
//     Console.Write(count + " ");
//     count += 1;
// }

// Task4. На вход принимаем 3хзначное число, вывести последнюю цифру данного числа.

// Console.WriteLine("Input three-digit number: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"The last digit is {n%10}");