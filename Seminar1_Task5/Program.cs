//Программа, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

//Запрашиваем входные данные
Console.WriteLine("Введите число");
//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные не были пустыми
if (inputLine != null)
{
    //Переводим в числовой формат (целочисленное значение)
    int num = int.Parse(inputLine);

    //Создаем новую переменную -N
    int minusNum = num * (-1);
    
    //Создаем переменную для вывода результата
    string outLine = ""; //можно string.Empty

    while(minusNum < num)
    {
        outLine = outLine + minusNum + ",";
        minusNum++; //Это то же самое, что и minusNum = minusNum + 1;
    }
    
    outLine = outLine + num;

    Console.WriteLine(outLine);
}