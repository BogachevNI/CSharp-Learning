﻿// ДЗ:
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// void ShowNumbers(int N)
// {
//     if (N > 0)
//     {
//         Console.Write(N + " ");
//         ShowNumbers(N - 1);
//     }
// }
// ShowNumbers(5);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
//вторая задача семинара, включая бОльшее число
int FindSum(int M, int N)
{
    if (M < N)
    {
        //Console.WriteLine();
        return M + FindSum(M + 1, N);
    }
    else if (M > N)
    {
        // Console.Write(m + " ");
        // m++;
        // PrintDiap(m, n);
        // Console.WriteLine();
        return N + FindSum(M, N + 1);
    }
    else return M;
}
Console.WriteLine(FindSum(1, 15));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
//Функция Аккермана - найти в Интернете