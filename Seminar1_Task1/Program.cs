//Программа, которая принимает на вход 2 числа и проверяет, является ли первое квадратом второго

Console.WriteLine("Введите первое число"); //Запрашиваем входные данные
string? inputLine1 = Console.ReadLine(); //Считываем данные с консоли

Console.WriteLine("Введите второе число"); //Запрашиваем входные данные еще раз
string? inputLine2 = Console.ReadLine(); //Считываем данные с консоли еще раз

if (inputLine1 != null && inputLine2 != null) //Проверяем, чтобы данные не были пустыми
{
    //Переводим в числовой формат (целочисленное значение)
    /*int num1 = int.Parse(inputLine1);
    int num2 = int.Parse(inputLine2);*/

    //Записываем выражение первое число - это квадрат второго 

    //bool outResult = (num1 == (int)Math.Pow(num2,2));  

    //Выводим результат в консоль. Предварительно выводим текст, описывающий, что именно посчиталось
    //Console.Write("Первое число является квадратом второго " + outResult);

    //Второй вариант решения задачи. В одно действие
    Console.WriteLine((bool)(int.Parse(inputLine1) == Math.Pow(int.Parse(inputLine2), 2)));
}




