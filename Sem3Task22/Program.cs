// Задача №22
// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел от 1 до
// N.

// 1. Метод читает данные от пользователя
int ReadData(string msg)
 {
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
 }

// 3. Метод вывода результата пользователю
void PrintData(string msg1, string msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

// 2. вывод нахождения степени числа от 1 до N
string LineBuilder(int n, int p)
{
    string s = "";
    for (int i = 1; i <= n; i++)
    {
        s += Math.Pow(i, p).ToString() + "\t";
    }
    return s;
}

// ввод данных
int num = ReadData("Введите N: ");

// собираем первую строку 
string line1 = LineBuilder(num, 1);
// собираем вторую строку 
string line2 = LineBuilder(num, 2);

// вывод данных 
PrintData(line1,line2);

