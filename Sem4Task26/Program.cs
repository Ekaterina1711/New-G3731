// Задача №26
// Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе

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

// Метод нахождения кол-ва цифр в числе 
int SumDigit(int num)
{
    int res = 0;
    while (num > 0)
    {
        res++;
        num = num/10;
    }
    return res;
}

// Метод#2 нахождения кол-ва цифр в числе 
int SumDigStr(int num)
{
    int res = 0;
    res = num.ToString().Length;
    
    return res;
}

// Метод#3 нахождения кол-ва цифр в числе 
int VarianLog(int num)
{
    int count = (int)Math.Log10(num)+1;
    return count;
}

int number = ReadData("введите число А");

int res1 = SumDigit(number);
PrintData("Вариант (SumSimple): ",res1);

int res2 = SumDigStr(number);
PrintData("Вариант (SumDigStr): ",res2);

int res3 = VarianLog(number);
PrintData("Вариант (VarianLog): ",res3);


