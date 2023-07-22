
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(100, 1000); 
// }

// void ReleaseArray(int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] % 2 == 0)
//             result++;
//         Console.Write(result);
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// Console.Write("Количество четных чисел в массиве: ");
// ReleaseArray(array);



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-99, 100); 
// }

// void ReleaseArray(int[] array)
// {
//     int result = 0;
//     for (int i = 1; i < array.Length; i+=2)
//         result += array[i];
//     Console.Write(result);
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// Console.Write("Сумма элементов массива стоящих на нечетных позициях: ");
// ReleaseArray(array);


//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76



// void InputArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//          array[i] = Convert.ToDouble(new Random().Next(1000, 10000))/ 100;
//  }

// void ReleaseArray(double[] array)
// {
//     double max = array[0];
//     double min = array[0];
//     for (int i = 0; i < array.Length; i++)
//         if (array[i]> max)
//             max = array[i];
//     for (int i = 0; i < array.Length; i++)
//         if (array[i]< min)
//             min = array[i];
//     Console.WriteLine($"Максимальный элемент массива: {max}");
//     Console.WriteLine($"Минимальный элемент массива: {min}" );
//     Console.WriteLine($"Разность максимального и минимального элементов массива: {Math.Round((max-min),2)}");
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[n];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// ReleaseArray(array);