// Напишите программу, которая на вход принимает два числа и выдаёт, какое число
// большее, а какое меньшее.

// Считываем данные с консоли первое число
string? inputNum1 = Console.ReadLine();
// Считываем данные с консоли второе число
string? inputNum2 = Console.ReadLine();

// Проверяем, чтобы данные были не пустуми
if ((inputNum1!=null) && (inputNum2!=null))
{
// Парсим введенное первое и второе число
    int numberA = int.Parse(inputNum1);
    int numberB = int.Parse(inputNum2);
   
    // сравниваем два числа 
    if(numberA > numberB)
    {
    //    выводим результат 
        Console.WriteLine("первое число больше второго");
    }
    else
    {
        Console.WriteLine("первое число меньше второго");
    }
}
