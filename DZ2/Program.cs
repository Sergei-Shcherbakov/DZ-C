// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Clear();
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// while (a>999 || a<100)
//  {
//     Console.Write("Введите число: ");
//     a = Convert.ToInt32(Console.ReadLine());
//  }
//  int b = a/10%10;
//  Console.WriteLine($"Вторая цифра числа: {b} ");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



// Console.Clear();
// bool ValNum(int a)
// { 
//     if (a<100)  
//         {Console.Write("Третьей цифры нет");
//     return false;
//         }
//     return true;
// }
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (ValNum(a))  
//     {
//     while (a>999)
//     {
//         a/=10;
//     }
//     Console.WriteLine($"Третья цифра: {a%10}");

//     }



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


// Console.Clear();
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
//  while (a>7 || a<1)
//   {
//     Console.Write("Введите число: ");
//      a = Convert.ToInt32(Console.ReadLine());
//   }
// if (a==1 || a==2 || a==3 || a==4 || a==5)
//     Console.WriteLine("Это будний день");
// else if (a==6 || a == 7)
//     Console.WriteLine("Ура, выходной!");
