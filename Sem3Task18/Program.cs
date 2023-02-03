// Задача №18
// Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных
// координат точек в этой четверти (x и y).

// просим пользователя ввести номер четверти 
int qNum=ReadData("Введите номер четверти");

PrintCoordTest();     //Вызов метода 

// Метод читает данные от пользователя
int ReadData(string msg)
 {
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
// // Метод определяет допустимого диапозона координат точек по етверти 
void PrintCoordTest()
{
    if (qNum > 0 && qNum < 5)
    {
        if(qNum == 1) Console.WriteLine("X > 0, Y > 0");
        if(qNum == 2) Console.WriteLine("X > 0, Y < 0");
        if(qNum == 3) Console.WriteLine("X < 0, Y < 0");
        if(qNum == 4) Console.WriteLine("X < 0, Y > 0");
    }
    else Console.WriteLine("Вы ввели не номер четверти!");
   
}
