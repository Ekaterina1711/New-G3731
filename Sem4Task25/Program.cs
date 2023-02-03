// №25 Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// Метод читает данные от пользователя
int ReadData(string msg)
 {
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
 }

//  Метод вывода результата пользователю
void PrintData(string msg1, int msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

// Метод возводящий число А в натуральную степень B
int Pow(int a, int b)
{
    int res = 1;
    while (b>0)
    {
        b = b - 1;
        res = res * a;
    }
    return res;
 
}

int numA = ReadData("введите число A:");
int numB = ReadData("введите число B:");
int result = Pow(numA,numB);
PrintData("Натуральная степень: ", result);


// Вариант 2
// int numberA = ReadInt("Введите число A: ");
// int numberB = ReadInt("Введите число B: ");
// ToDegree(numberA, numberB);


// // Функция возведения в степень
// void ToDegree(int a, int b)
// {
//     int result = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         result = result * a;
//     }
//     Console.WriteLine(result);
// }

// // Функция ввода
// int ReadInt(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
