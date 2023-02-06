// // №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
// // пользователь.



void CountingPositiveNumbers(string values) 
{
    int[] arrayNumbers = Array.ConvertAll(values.Split(), int.Parse);

    int count = 0;
    for (int i = 0; i < arrayNumbers.Length; i++)
    {
        if (arrayNumbers[i] > 0)
        {
            count += 1;
        }
    }

    Console.WriteLine($"Количество введенных чисел > 0: {count}");
}


Console.Write("Введите некоторое количество чисел от -100 до 100 через пробел: ");
string? acceptedValues = Console.ReadLine();

if (String.IsNullOrEmpty(acceptedValues))
{
    Console.WriteLine("Не введено ни одного числа");
}
else
{
    CountingPositiveNumbers(acceptedValues);
}



