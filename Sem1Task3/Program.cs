// Задача №3
// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру

// Считываем данные с консоли
string? inputNum = Console.ReadLine();

// Проверяем, чтобы данные были не пустуми
if(inputNum!=null)
{
// Преобразуем строку в целочисленное
int nameDay = int.Parse(inputNum);

// Создаем массив
string[ ] dayWeek = new string[7];

// Заполняем массив
dayWeek[0] = "понедельник";
dayWeek[1] = "вторник";
dayWeek[2] = "среда";
dayWeek[3] = "четверг";
dayWeek[4] = "пятница";
dayWeek[5] = "суббота";
dayWeek[6] = "воскресенье";

// Выводим ответ
Console.WriteLine(dayWeek[nameDay-1]);

// // ВАРИАНТ 2
    // int inputNumber = int.Parse(inputLine);
    // string dayWeek = string.Empty;
    // switch (inputNumber)
    // {
    //     case 1: dayWeek = "понедельник"; break;
    //     case 2: dayWeek = "вторник"; break;
    //     case 3: dayWeek = "среда"; break;
    //     case 4: dayWeek = "четверг"; break;
    //     case 5: dayWeek = "пятница"; break;
    //     case 6: dayWeek = "суббота"; break;
    //     case 7: dayWeek = "воскресенье"; break;
    //     default: dayWeek = "это не день недели"; break;
    // }
    // Console.WriteLine(dayWeek);

    // ВАРИАНТ 3

    // string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputNum));
    // Console.WriteLine(outDayOfWeek);
}
