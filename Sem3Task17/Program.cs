﻿// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
// выдаёт номер четверти плоскости, в которой
// находится эта точка.

// просим пользователя ввести координаты 
int coordX=ReadData("Введите координаты Х");
int coordY=ReadData("Введите координаты Y");
PrintQuterTest();     //Вызов метода 

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
// Метод определяет четверть по координатам точки
void PrintQuterTest()
{
    if(coordX > 0 && coordY > 0) Console.WriteLine("Точка в четверти 1");
    if(coordX > 0 && coordY < 0) Console.WriteLine("Точка в четверти 2");
    if(coordX < 0 && coordY < 0) Console.WriteLine("Точка в четверти 3");
    if(coordX < 0 && coordY > 0) Console.WriteLine("Точка в четверти 4");
}
