// Задача №7
// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе
// показывает последнюю цифру этого числа



// Считываем данные с консоли
string? inputNumLine = Console.ReadLine();

// Проверяем, чтобы данные были не пустуми
if(inputNumLine!=null)
{
    // Персим введенное число
    int inputNumberA = int.Parse(inputNumLine);

    int LastDigit = inputNumberA%10;

    Console.WriteLine(LastDigit);

}


