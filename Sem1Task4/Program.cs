// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из
// этих чисел.

// Считываем данные с консоли первое число
string? inputNum1 = Console.ReadLine();
// Считываем данные с консоли второе число
string? inputNum2 = Console.ReadLine();
// Считываем данные с консоли третье число
string? inputNum3 = Console.ReadLine();

// Проверяем, чтобы данные были не пустуми
if ((inputNum1!=null) && (inputNum2!=null) && (inputNum3!=null))
{
// Парсим введенное 1,2,3 число
    int numberA = int.Parse(inputNum1);
    int numberB = int.Parse(inputNum2);
    int numberC = int.Parse(inputNum3);
    
    
    if(numberA > numberB)
    {
        if(numberA > numberC)
        {
             Console.WriteLine (numberA);
        }
        else
        {
            Console.WriteLine (numberC);
        }
    }
    else
    {
        if(numberB > numberC)
        {
            Console.WriteLine (numberB);
        }
        else
        {
            Console.WriteLine (numberC);
        }

    }   
    
}

