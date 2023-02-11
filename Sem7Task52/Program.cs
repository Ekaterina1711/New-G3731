// №52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце.

int n = InputNum("Ваше число столбцов: ");
int m = InputNum("Ваше число строк: ");
int[,] matrix = Gen2DArr(n, m);
Print2DArr(matrix);
Console.WriteLine();
Arithmetic(matrix);

// Метод считывание данных
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод генерации массива
int[,] Gen2DArr(int n, int m)
{
    int[,] arr = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i, j] = j+i;
        }
    }
    return arr;
}
//  метод печати массива 
void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}
// метод поиска среднее арифметическое 
void Arithmetic(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double result = 0.0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            result = result + matrix[j, i];
        }
        System.Console.WriteLine($"Среднее арифметическое столбца {i}: {Math.Round(result / matrix.GetLength(0), 2)}");
    }
}



