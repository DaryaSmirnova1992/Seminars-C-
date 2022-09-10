// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// int rows = Convert.ToInt32(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int [rows, columns];

// for(int i = 0; i < matrix.GetLength(0); i++)
// {
// for(int j = 0; i < matrix.GetLength(1); j++)
//  {
//     matrix[i,j] = new Random().Next(0,11);
//     Console.Write(matrix[i,j]+ "\t");

//  }
//     Console.WriteLine();
// }

// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int [rows, columns];

for(int i = 0; i < matrix.GetLength(0); i++)
{
 for(int j = 0; i < matrix.GetLength(1); j++)
  {
   matrix[i,j] = i + j;
   Console.Write(matrix[i,j]+ "\t");
  }
  Console.WriteLine();
}