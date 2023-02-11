// №50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.



int n = InputNum("Введите номер строки ");
int m = InputNum("Введите номер столбца ");
Console.WriteLine();

int [,] matrix = new int [5,5];
FillTwoDimArray(matrix);

SerchElem(matrix);
Console.WriteLine();


// Метод считывание данных
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод генерации массива
void FillTwoDimArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {        
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix [i,j] = new Random().Next(0, 11);
            }  
        }
}

// Метод поиска элемента
void SerchElem(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        } 
        Console.WriteLine();
    }
}
if (n > matrix.GetLength(0) || m > matrix.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента = {matrix[n-1,m-1]}");
}