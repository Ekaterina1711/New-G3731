// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 1. Метод читает данные от пользователя
int ReadData(string msg)
 {
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
 }

// 2. Метод PalinTest - определения палиндрома 
 bool PalinTest(int n)
 {
    int d1 = n / 10000;
    int d2 = (n / 1000) % 10;
    int d3 = (n / 10) % 10;
    int d4 = n % 10;
    bool res = ((d1 == d4) && (d2 == d3)) ? true : false;
    return res;
 }
 // 3. Метод вывода результата пользователю
 void PrintData(string msg1)
 {
    Console.WriteLine(msg1);
 }

//Программа
//   ввод данных
 int num = ReadData("Введите число: ");
 bool result = PalinTest(num);
if (result)
{
    PrintData("Число является палиндромом");
}
else
{
    PrintData("Число не является палиндромом");
}

