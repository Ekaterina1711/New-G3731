// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

char[] digit = Console.ReadLine().ToCharArray();

if(digit.Length>=3)
{
    Console.WriteLine(digit[2]);
}
else
{
    Console.WriteLine("Третий цифры нет");
}
