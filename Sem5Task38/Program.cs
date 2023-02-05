// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.


int[] testArr = Gen1DArr(12,0,100);
Print1DArr(testArr);
int res = MinMax(testArr);
PrintData("Разница между максимальным и минимальным элементом:" ,res);

//  Метод вывода результата пользователю
void PrintData(string res, double value)
{
    Console.WriteLine(res + value);
}

// Метод генерации массива 
int[] Gen1DArr(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}
// Метод вывода сгенерированного массива 
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]+"]");
}
// Метод вычисления разницы между мах и мин элементами массива 
int MinMax(int[] arr)
{
    int max = arr[0];
    int min = arr[0];
    for(int i=0;i<arr.Length;i++)
    {
       if(arr[i]>max)  max=arr[i];
       if(arr[i]<min)  min=arr[i];
    }
    return(max-min);
}



// int size = 10;
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// int max = numbers[0];
// int min = numbers[0];

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > max)
//     {
//         max = numbers[i];
//     }
//     else if (numbers[i] < min)
//     {
//         min = numbers[i];
//     }
// }

// Console.WriteLine($"Минимальное число: {min}");
// Console.WriteLine($"Минимальное число: {max}");
// Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");



// void FillArrayRandomNumbers(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 555);
//     }
// }


// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }