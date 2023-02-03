// / Задача №5
// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.

// Считываем данные с консоли
string? inputNumLine = Console.ReadLine();

// Проверяем, чтобы данные были не пустуми
if(inputNumLine!=null)
{
    // Персим введенное число
    int inputNumberA = int.Parse(inputNumLine);

    int inputNumberB = inputNumberA*(-1);

    string outNumLine = string.Empty;

    while(inputNumberB < inputNumberA)
    {
        outNumLine = outNumLine + inputNumberB + ",";
        
        inputNumberB = inputNumberB +1;
        
    }
    outNumLine = outNumLine + inputNumberA;
    Console.WriteLine(outNumLine);

}


