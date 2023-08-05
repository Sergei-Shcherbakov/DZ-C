// Задача 54: Задайте двумерный массив. Напишите программу,
//  которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int [,] Create2dArray (int[] size)
// {
//     int [,] createdArray = new int[size[0], size[1]];
//     for (int i = 0; i < size[0]; i++)
//         for (int j = 0; j < size[1]; j++)
//             createdArray[i,j] = new Random().Next(0,10);
//     return createdArray;
// }


// void ShowArray (int [,] showedArray)
// {
//     for (int i = 0; i < showedArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < showedArray.GetLength(1); j++)
//         {
//             Console.Write (showedArray[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// void ReleaseMatrix (int[,] matrix)
// {
//     int temp = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {   
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {   
//             for (int t = 0; t <  matrix.GetLength(1) -1; t++)
//             {
//                 if (matrix[i,t] < matrix[i, t+1])
//                 {
//                     temp = matrix[i,t+1];
//                     matrix[i,t+1] = matrix[i,t];
//                     matrix[i,t] = temp;
//                 }
//             } 
//         } 
//     }
// }

// Console.Clear();
// Console.Write("Введите размеры матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = Create2dArray (size);
// ShowArray (matrix);
// ReleaseMatrix(matrix);
// ShowArray (matrix);



// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7



// int [,] Create2dArray (int[] size)
// {
//     int [,] createdArray = new int[size[0], size[1]];
//     for (int i = 0; i < size[0]; i++)
//         for (int j = 0; j < size[1]; j++)
//             createdArray[i,j] = new Random().Next(0,10);
//     return createdArray;
// }

// void ShowArray (int [,] showedArray)
// {
//     for (int i = 0; i < showedArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < showedArray.GetLength(1); j++)
//         {
//             Console.Write (showedArray[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// void ReleaseMatrix (int[,] matrix)
// {
//     int sum;
//     int min = 99999;
//     int mini = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {   
//         sum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {   
//            sum += matrix[i,j];
//         } 
//         if (sum < min)
//             {
//                 min = sum;
//                 mini = i+1;  // для пользователя счет с 1
//             }
//     }
//     Console.WriteLine($"Строка с наименьшой суммой элементов: {mini}");
// }



// Console.Clear();
// Console.Write("Введите размеры матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = Create2dArray (size);
// ShowArray (matrix);
// ReleaseMatrix(matrix);



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



// int [,] Create2dArray (int[] size)
// {
//     int [,] createdArray = new int[size[0], size[1]];
//     for (int i = 0; i < size[0]; i++)
//         for (int j = 0; j < size[1]; j++)
//             createdArray[i,j] = new Random().Next(0,10);
//     return createdArray;
// }



// void ShowArray (int [,] showedArray)
// {
//     for (int i = 0; i < showedArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < showedArray.GetLength(1); j++)
//         {
//             Console.Write (showedArray[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }



// int [,] ReleaseMatrix (int[,] matrix1, int[,] matrix2 )
// {
//     int[,] finalmatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
//     for (int i = 0; i < matrix1.GetLength(0); i++)
//         for (int j = 0; j < matrix2.GetLength(1); j++)
//             for (int k = 0; k < matrix2.GetLength(0); k++)
//                 finalmatrix[i,j] += matrix1[i,k] * matrix2[k,j];
//     return finalmatrix;
// }




// Console.Clear();
// Console.Write("Введите размер первой матрицы: ");
// int[] size1 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// Console.Write("Введите размер второй матрицы: ");
// int[] size2 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix1 = Create2dArray (size1);
// int[,] matrix2 = Create2dArray (size2);
// ShowArray (matrix1);
// ShowArray (matrix2);
// if (size1[0] != size2[1])
//     Console.WriteLine("Ошибка! Колличество строк первой матрицы не равно колличеству столбцов второй матрицы!");
// int [,] resultManrix = ReleaseMatrix(matrix1, matrix2);
// ShowArray(resultManrix);



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



// int[,,] Create3dArray(int[] size)
// {
//     int[,,] createdArray = new int[size[0], size[1], size[2]];
//     int tempsize = size[0] * size[1] * size[2];
//     if (tempsize <= 90)
//     {
//         int[] temparr = UniqVal(tempsize);
//         int iTemp = 0;
//         for (int i = 0; i < size[0]; i++)
//             for (int j = 0; j < size[1]; j++)
//                 for (int z = 0; z < size[2]; z++)
//                     if (iTemp >= 0 && iTemp < tempsize)
//                     {
//                         createdArray[i, j, z] = temparr[iTemp];
//                         iTemp++;
//                     }
//     }
//     return createdArray;
// }




// void ShowArray (int [,,] showedArray)
// {
//     for (int i = 0; i < showedArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < showedArray.GetLength(1); j++)
//         {
//             for (int z = 0; z < showedArray.GetLength(2); z++)
//             {
//                  Console.Write ($"{showedArray[i,j,z]} ({i},{j},{z}) ");
//             }
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine(" ");
// }

// int [] UniqVal (int size)
// {
//     int [] uniqarr = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         uniqarr[i] = new Random().Next(10, 100);
//         if(i != 0)
//         {
//             for (int r = 0; r < i; r++)
//             {
//                 while (uniqarr[r] == uniqarr[i])
//                 {
//                     uniqarr[r] = new Random().Next(10, 100);
//                 }
//             }
//         }
//     }
//     return uniqarr;
// }
// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,,] matrix3d = Create3dArray (size);
// ShowArray (matrix3d);



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



// int[,] Create2dArray(int[] size)
// {

//     int[,] createdArray = new int[size[0], size[1]];
//     int side = 1;
//     int rowTemp = 0;
//     int collTemp = 0;
//     int numTemp = 1;
//     for (int i = 1; i <= size[0]*size[1]; i++)
//     {
//         createdArray[rowTemp,collTemp] = numTemp;
//         numTemp++;
//         if (side == 1)
//         {
//             if (collTemp+1 >= size[1] || createdArray[rowTemp,collTemp+1] != 0)
//             {
//                 side = 2;
//                 rowTemp++;
//             }
//             else
//                 collTemp++;
//         }
//         else if (side == 2)
//         {
//             if (rowTemp + 1 >= size[0] || createdArray[rowTemp + 1,collTemp] != 0)
//             {
//                 side = 3;
//                 collTemp--;
//             }
//             else
//                 rowTemp++;
//         }
//         else if (side == 3)
//         {
//             if (collTemp - 1 < 0 || createdArray[rowTemp,collTemp - 1] != 0)
//             {
//                 side = 4;
//                 rowTemp--;
//             }
//             else
//                 collTemp--;
//         }
//          else if (side == 4)
//         {
//             if (rowTemp - 1 < 0 || createdArray[rowTemp - 1,collTemp] != 0)
//             {
//                 side = 1;
//                 collTemp++;
//             }
//             else
//                 rowTemp--;
//         }

        
//     }
//     return createdArray;
// }

// void ShowArray (int [,] showedArray)
// {
//     for (int i = 0; i < showedArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < showedArray.GetLength(1); j++)
//         {
//             if(showedArray[i,j] < 10)
//                 Console.Write ("0");
//             Console.Write (showedArray[i,j] + " " );
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = Create2dArray (size);
// ShowArray (matrix);
