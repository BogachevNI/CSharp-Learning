// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.

// 78 -> 8
// 12-> 2
// 85 -> 8

//task1
// int MaxDigit (int randomNumber)
// {
//     int dec = randomNumber / 10;
//     int ed = randomNumber % 10;
//     if (dec > ed) return dec;
//     else return ed;
// }

// int num = new Random().Next(10, 100);
// int maxDigit = MaxDigit(num);
// Console.WriteLine($"{num} -> {maxDigit}");

//task2
// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если второе число не кратно числу первому, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно
// bool multiFactor (int num1, int num2)
// {
//     if (num1 % num2 == 0) return true;
//     else return false;
// }
// Console.WriteLine("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{num1}, {num2} -> {multiFactor(num1, num2)}, ost {num1%num2}");

//task3
// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14  ->  нет
// 46  ->  нет
// 161 ->  да
// bool multiFactor (int number)
// {
//     if ((number % 7 == 0) && (number % 23 ==0)) return true;
//     else return false;
// }
// Console.WriteLine("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{num} кратно 7 и 23? -> {multiFactor(num)}");

//task4
// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

Console.WriteLine("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool Square (int num1, int num2)
{
    if ((num1 == num2 * num2) || num2 == num1*num1) return true;
    else return false;
}
if (Square(num1, num2) == true) Console.WriteLine("Одно число является квадратом другого");
else Console.WriteLine("Числа не имеют степенную связь");