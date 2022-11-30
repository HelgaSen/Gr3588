//Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//Первый вариант решения

Console.WriteLine("Введите натуральное число"); //Запрашиваем входные данные
string? inputLine = Console.ReadLine(); //Считываем данные с консоли

if (inputLine != null) //Проверяем, чтобы данные не были пустыми
{ 
    int number = int.Parse(inputLine); //Переводим в числовой формат (целочисленное значение)
    if(number<2) //проверка корректности входных данных
    {
        Console.WriteLine("Решения нет"); //сообщение, если входные данные некорректны
    } 
    else //если данные прошли проверку корректности, то запишем все четные числа в массив
    {
        int index = 0; //создаем переменную индекса элементов массива
        int evenNumber = 1; //переменная для вычисления четных элементов
        int arrayLength = number/2; //переменная для определения длины массива
        int[] evenNumbers = new int[arrayLength]; //создаем массив целочисленных элементов
            while(evenNumber <= number)  //запускаем цикл вычисления четных элеменнтов
            {   
                if(evenNumber%2 == 0) //если остаток от деления на два равен 0, то записываем элемент в массив
                {
                    evenNumbers[index] = evenNumber; 
                    index = index + 1; 
                }
            evenNumber = evenNumber + 1;
            }
        Console.WriteLine(string.Join(", ", evenNumbers));//вывод в консоль ответа    
    }        
}

//Второй вариант решения
/*
Console.WriteLine("Введите натуральное число"); //Запрашиваем входные данные
string? inputLine = Console.ReadLine(); //Считываем данные с консоли

if (inputLine != null) //Проверяем, чтобы данные не были пустыми
{
    int number = int.Parse(inputLine); //Переводим в числовой формат (целочисленное значение)
    if (number < 2) //проверка корректности входных данных
    {
        Console.WriteLine("Решения нет"); //сообщение, если входные данные некорректны
    }
    else //если входные данные корректны, то вычисляем четные элементы
    {
    int evenNumber = 2; //Создаем переменную для вычисления чётных чисел
    string outLine = ""; //Создаем переменную для вывода результата

        while (number + 1 > evenNumber) //задаем условие цикла
        {
            if (evenNumber%2 == 0) //если остаток от деления на два равен 0, то записываем число в строку ответа
            {
                outLine = outLine + evenNumber + ",";
            }
            evenNumber = evenNumber + 2; //Это то же самое, что и minusNum = minusNum + 1;
        }
        Console.WriteLine(outLine.Substring(0,outLine.Length - 1));
    }
}
*/

