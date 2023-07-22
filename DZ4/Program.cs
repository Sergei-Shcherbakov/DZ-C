// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



// int f(int a, int b)
// {
//     int c = 1;
//     for (int i = 0; i < b; i++)
//     {
//         c *= a;
//     }
//     return c;
// }

// bool f1(int b)
// {
//     if (b<0)
//     {
//         Console.WriteLine("Второе число должно быть больше 0 ");
//         return false;
//     }
//     return true;
// }


// Console.Clear();
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (f1(b))
// {
//     Console.Write($"Число {a} в степени {b} равно {f(a,b)}");
// }



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// int Sum(int a)
// {
//     int result = 0;
//     while (a>0)
//     {
//         result += a%10;
//         a = a /10;
//     }
//     return result;
// }



// Console.Clear();
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма всех цифр в числе {a} равна: {Sum(a)}");



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(0, 100); 
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");