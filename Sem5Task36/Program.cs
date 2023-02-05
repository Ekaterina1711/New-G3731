// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.




int[] testArr = Gen1DArr(12,0,100);
Print1DArr(testArr);
int res = SumPos(testArr);  
PrintData("Сумма нечетных чисел в массиве: ", res);

void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

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

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]+"]");
}

int SumPos(int[] arr)
{
    int res = 0;
    for(int i=1;i<arr.Length;i+=2)
    {
       res+=arr[i];
    }
    return res;
}