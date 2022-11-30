//Программа, которая выводит название дня по заданному номеру

/*//Запрашиваем входные данные
Console.WriteLine("Введите число от 1 до 7");
//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные не были пустыми
if (inputLine != null)
{
    //Именуем массив
    string[] weekDay = new string[7];
    weekDay[0] = "Понедельник";
    weekDay[1] = "Вторник";
    weekDay[2] = "Среда";
    weekDay[3] = "Четверг";
    weekDay[4] = "Пятница";
    weekDay[5] = "Суббота";
    weekDay[6] = "Воскресенье";

    //Переводим в числовой формат (целочисленное значение)
    int dayNum = int.Parse(inputLine);
          
    //Выводим результат в консоль. 
    Console.Write(inputLine);
    Console.Write(" это ");
    Console.WriteLine(weekDay[dayNum-1]);
}
*/

/*//Второй вариант
//Запрашиваем входные данные
Console.WriteLine("Введите число от 1 до 7");
//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные не были пустыми
if (inputLine != null)
{
    //Переводим в числовой формат (целочисленное значение)
    int dayNum = int.Parse(inputLine);

    //Именуем переменную для оператора switch
    string outDayOfWeek = string.Empty;

    switch (dayNum)
    {
        case 1: outDayOfWeek = "Понедельник"; break;
        case 2: outDayOfWeek = "Вторник"; break;
        case 3: outDayOfWeek = "Среда"; break;
        case 4: outDayOfWeek = "Четверг"; break;
        case 5: outDayOfWeek = "Пятница"; break;
        case 6: outDayOfWeek = "Суббота"; break;
        case 7: outDayOfWeek = "Воскресенье"; break;
        default: outDayOfWeek = "Ну ты чего? В неделе всего 7 дней!"; break;
    }

    //Выводим результат в консоль. 
    // Console.Write(inputLine);
    // Console.Write(" это ");
    Console.WriteLine(outDayOfWeek);
}
*/
//Третий вариант.
//Запрашиваем входные данные
Console.WriteLine("Введите число от 1 до 7");
//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные не были пустыми
if (inputLine != null)
{
    //Переводим в числовой формат (целочисленное значение)
    int dayNum = int.Parse(inputLine);

    string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(dayNum));

    //Выводим результат в консоль. 
    Console.Write(inputLine);
    Console.Write(" это ");
    Console.WriteLine(outDayOfWeek);
}

