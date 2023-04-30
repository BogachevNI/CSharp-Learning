// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Input 5-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// bool countNumberDigits (int inputNumber)
// {
//     if (Math.Abs(inputNumber).ToString().Length == 5) return true;
//     else 
//     {
//         Console.WriteLine($"The number {inputNumber} does not have 5 digits! Try again.");
//         return false;
//     }
// }

// void checkNumber (int inputNumber)
// {
//     if ((inputNumber / 10000 == inputNumber % 10) && (inputNumber / 1000 % 10 == inputNumber % 100 / 10))
//         Console.WriteLine($"Number {inputNumber} is a palindrome");
//     else Console.WriteLine($"Number {inputNumber} is not a palindrome");
// }
// if (countNumberDigits(number) == true) checkNumber(number);

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Console.WriteLine("Input coordinate X for the first point: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input coordinate Y for the first point: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input coordinate Z for the first point: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input coordinate X for the second point: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input coordinate Y for the second point: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input coordinate Z for the second point: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double calcDistance (int xa, int ya, int za, int xb, int yb, int zb)
// {
//     double distance = Math.Round(Math.Pow(Math.Pow(xb-xa,2)+Math.Pow(yb-ya,2)+Math.Pow(zb-za,2),0.5),2);
//     return distance;
// }
// Console.WriteLine($"The distance between point is {calcDistance(x1,y1,z1,x2,y2,z2)}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Input N: ");
int N = Convert.ToInt32(Console.ReadLine());

void Seq3 (int numberN)
{
    int count = 1;
    while(count <= numberN)
    {
        Console.Write($"{Math.Pow(count, 3)} ");
        count += 1;
    }
}
Seq3(N);