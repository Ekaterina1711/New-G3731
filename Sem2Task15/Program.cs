// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
int day = int.Parse(Console.ReadLine()??"0");

if((day>7) || (day<1))
{
    Console.WriteLine("Не день недели");
}
else
{
    if(day>5)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }

}
