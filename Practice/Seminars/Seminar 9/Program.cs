//Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"
// void ShowNumbers(int N)
// {
//     if (N > 0)
//     {
//         ShowNumbers(N - 1);
//         Console.Write(N + " ");
//     }
// }

// ShowNumbers(5);

//Задание 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

//453 -> 12
//45 -> 9
// int FindSum (int number)
// {
//     if (number > 0)
//     {
//         return FindSum(number/10) + number % 10;
//     }
//     else return number;
// }
// Console.WriteLine(FindSum(453));
// Console.WriteLine(FindSum(45));
// Console.WriteLine(FindSum(6392));

//Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5, 6, 7, 8"

// void PrintDiap(int n, int m)
// {
//     if (n < m)
//     {
//         Console.Write(n + " ");
//         n++;
//         PrintDiap(n, m);
//     }
//     else if (n > m)
//     {
//         Console.Write(m + " ");
//         m++;
//         PrintDiap(m, n);
//     }
//     else Console.Write(n);
// }
// PrintDiap(1, 5);
// PrintDiap(5, 1);

//Задача 4.Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// int Stepen(int A, int B)
// {
//     if(B > 0)
//     {
//         return A * Stepen(A, B -1);
//     }
//     else return 1;
// }
// Console.WriteLine(Stepen(2,3));