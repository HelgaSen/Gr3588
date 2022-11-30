Console.WriteLine("Введите целое число"); //Запрашиваем входные данные
string? inputLine = Console.ReadLine(); //Считываем данные с консоли

if (inputLine != null) //Проверяем, чтобы данные не были пустыми
{
    int number = int.Parse(inputLine); //Переводим в числовой формат (целочисленное значение)

    //Находим квадрат числа. Ниже два варианта, как это можно сделать. 
    //int outResult = number * number; // первый вариант
    int outResult = (int)Math.Pow(number, 2); //второй вариант

    Console.WriteLine("Квадрат заданного числа равен " + outResult); //Выводим результат в консоль. Предварительно выводим текст, описывающий, что именно посчиталось
    
    //Второй вариант решения задачи. В одно действие
    //Console.WriteLine(Math.Pow(int.Parse(inputLine), 2));
}



