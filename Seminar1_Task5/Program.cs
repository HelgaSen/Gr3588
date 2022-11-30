//Программа, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите число"); //Запрашиваем входные данные
string? inputLine = Console.ReadLine(); //Считываем данные с консоли

if (inputLine != null) //Проверяем, чтобы данные не были пустыми
{
    int num = int.Parse(inputLine); //Переводим в числовой формат (целочисленное значение)

    int minusNum = num * (-1); //Создаем новую переменную -N

    string outLine = ""; //можно string.Empty// Создаем переменную для вывода результата

    while (minusNum < num)
    {
        outLine = outLine + minusNum + ",";
        minusNum++; //Это то же самое, что и minusNum = minusNum + 1;
    }

    outLine = outLine + num;
    Console.WriteLine(outLine);
}