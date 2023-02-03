// Задача №1
// Напишите программу, которая на вход принимает
// два числа и проверяет, является ли первое число
// квадратом второго

// Считываем данные с консоли первое число
string? inputNum1 = Console.ReadLine();
// Считываем данные с консоли второе число
string? inputNum2 = Console.ReadLine();

if ((inputNum1!=null) && (inputNum2!=null))
{
    if ((int)Math.Pow(int.Parse(inputNum2), 2) == int.Parse(inputNum1))
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }
}

// // Проверяем, чтобы данные были не пустуми
// if(inputNum1!=null && inputNum2!=null)

// {

//     // Персим 1 введенное число
//     int number1 = int.Parse(inputNum1);
//     // Персим 2 введенное число
//     int number2 = int.Parse(inputNum2);

//     if(number1==number2*number2)
//     {
//         Console.WriteLine("Первое число квадрат второго!");
//     }
//     else
//     {
//         Console.WriteLine("Первое число не квадрат второго!");
//     }
// }


