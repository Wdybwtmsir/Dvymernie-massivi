//Двумерные массивы
using System;
using System.ComponentModel.DataAnnotations;

int[,] mas1 = new int[3,4];//Массив 3 на 4 из нулей
int[,] mas2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
Random random = new Random();
int[,] mas3 = new int[3, 4];
int max_row = int.MinValue, min_row = int.MaxValue;
for (int i = 0; i < mas3.GetLength(0); i++)
{
    for (int j = 0; j < mas3.GetLength(1); j++)
    {
        mas3[i,j]=random.Next(10, 100);
        Console.Write(mas3[i,j]+" ");
        
        if (mas3[i, j] > max_row) max_row = mas3[i, j];
        if (mas3[i, j] < min_row) min_row = mas3[i, j];
    }
    Console.WriteLine($"max={max_row}min = {min_row}");
}
//Найти max и min матрицы и каждой строки
int max = int.MinValue, min = int.MaxValue;
for (int i = 0; i < mas3.GetLength(0); i++)
{
    for (int j = 0; j < mas3.GetLength(1); j++)
    {
        if (mas3[i,j]  >max) max = mas3[i,j];
        
        if (mas3[i,j]  <min) min = mas3[i,j];
    }
}
Console.WriteLine($"max={max} min={min}");
//Сумма элементов строк и столбцов и сумма всей матрицы:
int[,] mas4=new int[random.Next(3,6),random.Next(3,6)];
int S = 0;
for (int i = 0; i < mas3.GetLength(0); i++)
{
    for (int j = 0; j < mas3.GetLength(1); j++)
    {
        mas4[i, j] = random.Next(10, 100);
        Console.Write(mas4[i,j]+" ");
        S += mas4[i, j];
    }
    Console.WriteLine();
}
Console.WriteLine("S="+S);