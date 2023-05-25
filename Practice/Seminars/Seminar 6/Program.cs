//Задача 2.Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
//самое важное знать правило, какждая сторона должна быть меньше(строго) суммы двух других сторон

// bool CheckTriangle(int a, int b, int c)
// {
//     if (a + b > c && a + c > b && b + c > a) return true;
//     else return false;
// }

// Console.WriteLine("Input A length: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input B length: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input C length: ");
// int c = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(CheckTriangle(a, b, c));

//Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
//числа фибоначчи последовательность чисел в которой первые 2 числа это 0 и 1, а последубщие это сумма двух передыдущих
//[0, 1, 1, 2, 3, 5, 8, 13, ... ]

// Console.WriteLine("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input sequence length: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] LikeFibonachi(int firstNum, int secondNum, int size)
// {
//     int[] array = new int[size];
//     array[0] = firstNum;
//     array[1] = secondNum;

//     for (int i = 2; i < size; i++)
//     {
//         array[i] = array[i - 1] + array[i - 2];
//     }
//     return array;
// }

// void printArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine(); // для новой строки
// }

// printArray(LikeFibonachi(num1, num2, size));
// int[] array = LikeFibonachi(num1, num2, size);
// printArray(array);

//Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)

//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

int[] createRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(); // для новой строки
}

int[] InvertArray(int[] array)
{
    int temp;
    for (int i = 0; i < array.Length / 2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
}

Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input array minimum: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input array maximum: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = createRandomArray(size, min, max);
printArray(myArray);
myArray = InvertArray(myArray);
printArray(myArray);