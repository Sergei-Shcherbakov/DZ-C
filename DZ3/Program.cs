// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
 
// void F(string a)
// {   if (a[0]==a[4] && a[1]==a[3])
//         Console.WriteLine("Это полиндром");
//     else 
//         Console.WriteLine("Это не полиндром");
// }
// Console.Clear();
// Console.Write("Введите пятизначное число: ");
// string n = Convert.ToString(Console.ReadLine());
// F(n);




// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



// Console.Clear();
//  Console.Write(" x1 = ");
// int x1 = Convert.ToInt32(Console.ReadLine());
//  Console.Write(" y1 = ");
// int y1 = Convert.ToInt32(Console.ReadLine());
//  Console.Write(" z1 = ");
// int z1 = Convert.ToInt32(Console.ReadLine());
//  Console.Write(" x2 = ");
// int x2 = Convert.ToInt32(Console.ReadLine());
//  Console.Write(" y2 = ");
// int y2 = Convert.ToInt32(Console.ReadLine());
//  Console.Write(" z2 = ");
// int z2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)+ Math.Pow(z1 - z2, 2)), 2));



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for(int i = 1; i<=n; i++)
// Console.Write($"{Math.Pow (i, 3)} ");