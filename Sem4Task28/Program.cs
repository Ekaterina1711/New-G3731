// Задача №28
// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.

using System.Numerics;


// 1. Метод читает данные от пользователя
int ReadData(string msg)
 {
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
 }

// 2 Метод вывода результата пользователю
void PrintData(string msg1, BigInteger msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

// Метод факториал числа 
// BigInteger CalcFact(int num)
// {
//     BigInteger res = 1;

//     return res;
// }

BigInteger CalcFact(int num)
{
    BigInteger res = 1;
    for (int i=1; i<=num; i++)
    {
        res = res*i;
    }
    return res;
}

int number = ReadData("введите число:");

BigInteger fact = CalcFact(number);
PrintData("Факториал равен: ",fact);
