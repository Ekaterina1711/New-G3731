// №29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.




int lenArray = ReadData("Введите длинну массива: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}


// Функция ввода
int ReadData(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}