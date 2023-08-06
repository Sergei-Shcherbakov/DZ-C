// Задача 64: Задайте значение N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void ShowNumbers (int n)
// {

//     Console.Write(n + " ");
//     if (n>1) ShowNumbers(n - 1);
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// ShowNumbers(n);



// Задача 66: Задайте значения M и N.
//  Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumNumbers (int m, int n, int sum)
// {
//     sum += Math.Min(m,n);
//     if (Math.Min(m,n) > Math.Max(m, n)) return 0;
//     if (Math.Min(m,n) < Math.Max(m, n)) return SumNumbers (Math.Min(m,n) +1, Math.Max(m, n), sum);
//     return sum;
// }

// Console.Clear();
// Console.Write("Введите первое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите  второе число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// Console.Write($"Сумма чисел от {Math.Min(m,n)} до {Math.Max(m, n)} = {SumNumbers(m,n,sum)}");



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// int AckermanF (int m, int n)
// {
    
//     if (m == 0) 
//         return n + 1;
//     else if (m > 0 && n == 0) 
//         return AckermanF (m - 1, 1 );
//     else if 
//         (m > 0 && n > 0) return AckermanF (m - 1, AckermanF(m, n-1) );

//    return -1;
// }

// Console.Clear();
// Console.Write("Введите первое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите  второе число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int res = AckermanF(m,n);
// Console.Write($"Результат вычисления функции Акермана: {res}");
