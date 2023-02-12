// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполняем массив случайными числами
int[,] Gen2DArray(int raw, int col, int min, int max)
{
    int[,] matr = new int[raw,col];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matr;
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Метод произведение матриц
int[,] MatrixMultiplication(int[,] A, int[,] B)
{
  int[,] C = new int[A.GetLength(0), B.GetLength(1)];
  for (int i = 0; i < A.GetLength(0); i++)
  {
    for (int j = 0; j < B.GetLength(1); j++)
    {
      C[i, j] = 0;
      for (int k = 0; k < A.GetLength(1); k++)
      {
        C[i, j] += A[i, k] * B[k, j];
      }
    }
  }
  return C;
}

int n = ReadData("Количество строк матрицы: ");
int m = ReadData("Количество столбцов матрицы: ");
int[,] matrixA = Gen2DArray(n, m, 0, 21);
Print2DArray(matrixA);

int[,] matrixB = Gen2DArray(m, n, 0, 21);
Print2DArray(matrixB);

Console.WriteLine("Произведение матриц: ");
int[,] matrixC = MatrixMultiplication(matrixA, matrixB);
Print2DArray(matrixC);