// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// void InputMatrix(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(-10, 10), 2);
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Clear();
// Console.Write("Введите размеры матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// double[,] matrix = new double[size[0], size[1]];
// InputMatrix(matrix);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// int Prompt(int[,] matrix)
// {
// //     Console.Write(message);
// //     string value = Console.ReadLine();
// //     int result = Convert.ToInt32(value);
// //     return result;
//     int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// }

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] =  new Random().Next(0, 50);
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }


// void ReleaseMatrix(int[,] matrix)
// {
//     Console.Write("Введите позицию элемента в массиве: ");
//     int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
//     if (0 >= size[0] || size[1] <= 0 || size[0] >= matrix.GetLength(0) || size[1] >= matrix.GetLength(1)) 
//     {
//         Console.WriteLine("Такого элемента нет");
//         return;
//     }
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if (i == size[0] - 1 && j == size[1] - 1)
//             Console.WriteLine($"Значение элемента в массиве: {matrix[i, j]}");
//         else if (10 * i + j != 10 * size[0] + size[1] && i == matrix.GetLength(0) && j == matrix.GetLength(1))
//             Console.WriteLine($"Значение элемента в массиве нет");
//     }

// }

// }


// Console.Clear();
// int[,] matrix = new int[new Random().Next(2, 10), new Random().Next(2, 10)];
// InputMatrix(matrix);
// ReleaseMatrix(matrix);
// // Пользователь не знает что отсчет с 0 поэтому 1 1 самый первый элемент, если считать с 0 :
// // изменение 65 строчки if (0 > size[0] || size[1] < 0 || size[0] >= matrix.GetLength(0) || size[1] >= matrix.GetLength(1)) 
// // изменение 74 строчки if (i == size[0]  && j == size[1] )




// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6;
// 3.


// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(0, 10);
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// void ReleaseMatrix(int[,] matrix, int[] size)
// {
//     double average = 0;
//     double sumi = 0;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         sumi *= 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             sumi += matrix[i, j];
//         }
//         average = sumi / size[0];
//         average = Math.Round(average, 2);
//         Console.WriteLine($"Среднее арифметическое {j} столбца: {average}");   // Для пользователя j + 1

//     }

// }

// Console.Clear();
// Console.Write("Введите размеры матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// Console.Write("\n");
// ReleaseMatrix(matrix, size);