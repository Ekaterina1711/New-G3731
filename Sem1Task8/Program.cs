// Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.

// Считываем данные с консоли
string? inputNum = Console.ReadLine();

// Проверяем, чтобы данные были не пустуми
if(inputNum!=null)
{
     // Персим введенное число
    int N = int.Parse(inputNum);

    string result = string.Empty;

    for(int i = 2; i < N; i = i + 2)
    {
        result = result + i + ",";
    }
    if(N%2==0)
    {
        result = result + N;
        Console.WriteLine(result);
    }

}

