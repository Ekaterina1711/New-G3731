// №47 Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

//1) Получение данных от пользователя
int n = InputNum("Количество строк матрицы ");
int m = InputNum("Количество строк матрицы ");

//2) Генерация двумерного массива
double[,] matix = FillTwoDimArray(n,m);

//3) Печатаем двумерный массив
PrintTwoDimArray(matix);

// Метод считывание данных
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


// Мпетод генерации массива
double[,] FillTwoDimArray(int countRow, int countColumn)
{
    Random rand = new Random();
    double[,] matr = new double[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            matr[i, j] = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 3);
        }
    }
    return matr;
}

//метод для печати двумерного массива
void PrintTwoDimArray(double[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            
           
            Console.Write(inputArray[i, j] + " ");
           
            j++;
        }
        Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}
