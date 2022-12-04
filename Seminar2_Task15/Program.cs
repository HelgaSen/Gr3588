//Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//Первый вариант решения.
void DayOfWeekCheck(int day) //создаем метод
{
    string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(day)); //получаем название дня недели
    if (day >= 1 && day <= 5) //условие для рабочих дней
    {
        Console.WriteLine("Сегодня " + outDayOfWeek + " - это рабочий день"); //вывод результата в консоль
    }
    if (day == 0 || day == 6) //условие для выходных дней
    {
        Console.WriteLine("Сегодня " + outDayOfWeek + " - это выходной день"); //вывод результата в консоль
    }
}

Console.WriteLine("Введите число от 0 до 6"); //запрос введения данных
int weekDay = int.Parse(Console.ReadLine() ?? "0"); //считываем данные, проверяя на NULL, преобразовываем в целочисленное значение
if (weekDay >= 0 && weekDay <= 6) //условие для корректных данных
{
    DayOfWeekCheck(weekDay); //используем ранее созданный метод
}
else
{
    Console.WriteLine("Данные введены неверно. попробуйте еще раз"); //сообщение о некорректных данных.
}

//Второй вариант решения
/*
void DayOfWeekCheck(int day)
{
    if (day >= 1 && day <= 5)
    {
        Console.WriteLine(day + " - рабочий день");
    }
    if (day == 6 || day == 7)
    {
        Console.WriteLine(day + " - выходной день");
    }
}

Console.WriteLine("Введите число от 1 до 7");
int weekDay = int.Parse(Console.ReadLine() ?? "0");
if (weekDay >= 1 && weekDay <= 7)
{
    DayOfWeekCheck(weekDay);
}
else
{
    Console.WriteLine("Данные введены неверно. попробуйте еще раз");
}
*/

