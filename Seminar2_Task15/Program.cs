//Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void DayOfWeekCheck(int day)
{
    string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(day));
    if (day >= 1 && day <= 5)
    {
        Console.WriteLine("Сегодня " + outDayOfWeek + " - это рабочий день");
    }
    if (day == 0 || day == 6)
    {
        Console.WriteLine("Сегодня " + outDayOfWeek + " - это выходной день");
    }
}

    Console.WriteLine("Введите число от 0 до 6");
    int weekDay = int.Parse(Console.ReadLine()??"0");
    if(weekDay >=0 && weekDay <=7)
    {
        DayOfWeekCheck(weekDay);
    }
    else
    {
        Console.WriteLine("Данные введены неверно. попробуйте еще раз");
    }







