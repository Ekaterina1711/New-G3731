// Задача №24
// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.

// 1. Метод читает данные от пользователя
int ReadData(string msg)
 {
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
 }

// 2 Метод вывода результата пользователю
void PrintData(string msg1, int msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

// Метод суммы числа 
int SumSimple (int numA)
{
    int sumOfNum = 1;  //вводим переменную
    for(int i=2; i<=numA; i++)  //цикл 
    {
        sumOfNum+=i;
    }
    return sumOfNum;
}

// Метод формулы Гауса
int SumGauss (int numA)
{
    return (numA*(numA+1))/2;
}

int numberA = ReadData("введите число А");
int res1 = SumSimple(numberA);
int res2 = SumGauss(numberA);
PrintData("Сумма чисел от 1 до А(SumSimple): ",res1);
PrintData("Сумма чисел от 1 до А(SumGauss): ",res2);
