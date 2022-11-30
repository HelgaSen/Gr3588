//Запрашиваем входные данные
Console.WriteLine("Введите целое число");

//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные не были пустыми
if (inputLine != null)
{
    //Переводим в числовой формат (целочисленное значение)
    int number = int.Parse(inputLine);
    
    //Находим квадрат числа. Ниже два варианта, как это можно сделать. 
    //int outResult = number * number; - первый вариант
    int outResult = (int)Math.Pow(number,2); //второй вариант

    //Выводим результат в консоль. Предварительно выводим текст, описывающий, что именно посчиталось
    Console.Write("Квадрат заданного числа равен ");
    //Console.WriteLine(outResult);

    //Второй вариант решения задачи. В одно действие
    Console.WriteLine(Math.Pow(int.Parse(inputLine),2));
}



