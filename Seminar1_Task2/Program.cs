//Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число"); //Запрашиваем входные данные
string? inputLine1 = Console.ReadLine(); //Считываем данные с консоли

Console.WriteLine("Введите второе число"); //Запрашиваем входные данные еще раз
string? inputLine2 = Console.ReadLine(); //Считываем данные с консоли еще раз

if (inputLine1 != null && inputLine2 != null) //Проверяем, чтобы данные не были пустыми
{
    Console.Write("Максимальное число "); //добавляем перед результатом поясняющую информацию 
    Console.WriteLine(Math.Max(int.Parse(inputLine1), int.Parse(inputLine2))); //выводим результат

    //Второй вариант решения с помощью оператора if

    /*int number1 = int.Parse(inputLine1); //Переводим в числовой формат (целочисленное значение)
    int number2 = int.Parse(inputLine2); 

    string maxNumber = string.Empty; //Создаем переменную для хранения результата
    if(number1 > number2) //задаем условие для нахождения результата
    {
        maxNumber = maxNumber + number1; //записываем в переменную типа string ответ
    }
    else //альтернативное условие 
    {
        maxNumber = maxNumber + number2;
    }
    Console.Write("Максимальное число ");
    Console.WriteLine(maxNumber);*/
}

//Еще можно не создавать отдельные переменные, а просто в условии записать if(int.Parse(inputLine1) > int.Parse(inputLine2)) 

