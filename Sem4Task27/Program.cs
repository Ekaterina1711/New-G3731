// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в
// числе.

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

// Метод принимает на вход число и выдаёт сумму цифр в числе.
int SumSym(int num)
{
    int res = 0;
    while (num>0)
    {
        res = res + num%10;
        num = num/10;
    }
    return res;
 
}

int numA = ReadData("введите число:");
int result = SumSym(numA);
PrintData("Сумма чисел: ", result);



