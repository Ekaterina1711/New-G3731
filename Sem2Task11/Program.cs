// Задача №11
// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.

System.Random numSintezator = new System.Random();
int num = numSintezator.Next(100,1000);
// Console.WriteLine(num);

int digitfir = num/100;
int digitlst = num%10;
Console.WriteLine(num);
Console.WriteLine(digitfir*10 +digitlst);

