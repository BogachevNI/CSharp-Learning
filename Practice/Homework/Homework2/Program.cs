// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// _restart:
// Console.WriteLine("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number < 100 || number > 999)
// {
//     Console.WriteLine("Число не трехзначно!");
//     goto _restart;
// }
// int secondDigit(int number)
// {
//     int secondDigit = (number / 10) % 10;
//     return secondDigit;
// }
// Console.WriteLine($"Второй цифрой числа {number} является {secondDigit(number)}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool noThirdNumber(int num)
{
    if (num < 100)
    {
        Console.WriteLine($"{num} -> третьей цифры нет");
        return false;
    }
    else return true;
}
int getThirdRank (int num)
{
    while (num>999)
    {
        num /= 10;
    }
    return num% 10;
}
if (noThirdNumber(number) == true)
{
    Console.WriteLine($"{number} -> {getThirdRank(number)}");
}

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// _restart:
// Console.WriteLine("Введите цифру: ");
// int number = Convert.ToInt32(Console.ReadLine());

// bool dayOfTheWeek (int num)
// {
//     if ((num < 1) || (num > 7)) 
//     {
//         Console.WriteLine("Число не попадает в диапазон от 1 до 7.");
//         return false;
//     }
//     return true;
// }
// bool validateWeekend (int num)
// {
//     if ((num == 6) || (num == 7)) return true;
//     else return false;
// }

// if (dayOfTheWeek(number) == false) goto _restart;
// else if (validateWeekend(number) == true) Console.WriteLine($"{number} -> да");
//         else Console.WriteLine($"{number} -> нет");