// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4



// void Sum(int[] array)
// {
//     int summ = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//             summ++;
//     }
//     Console.WriteLine($"Колличество чисел больше нуля: {summ}");
// }
// Console.Clear();
// Console.Write("Введите числа через пробел: ");
// int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// Sum(array);



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// x=(b2-b1)/(k1-k2)
// y= k1*((b2-b1)/(k1-k2)+b1)



// void ReleaseFormuls(double a, double c, double b, double d)
// {
//     double x = 0;
//     double y = 0;
//     x = (d - c) / (a - b);
//     y = (a * d - b * c) / (a - b);
//     Console.WriteLine($"Координаты точки пересечения прямых: ({x}; {y})");
// }
// Console.Clear();
// Console.Write("Введите k1 = ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите b1 = ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите k2 = ");
// int k2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите b2 = ");
// int b2 = Convert.ToInt32(Console.ReadLine());
// ReleaseFormuls(k1, b1, k2, b2);