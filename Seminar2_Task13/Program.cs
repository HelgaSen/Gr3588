//Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
//Первый вариант
Console.WriteLine("Введите число"); //запрашиваем ввод данных
string digit = Console.ReadLine() ?? "0"; //считываем данные с консоли
int checkNumber = 0; //объявляем переменную. Используется только для определения типа введенных данных
if (int.TryParse(digit, out checkNumber)) //условия корректности ввода, запись значения, если данные корректны
{
    if (digit.Length >= 3) //проверка наличия третьей цифры
    {
        char[] array = new char[digit.Length]; //создаем массив символов
        array = digit.ToCharArray(0, digit.Length); //записываем данные с консоли в массив
        Console.WriteLine(array[2]); //выводим в консоль третий элемент массива
    }
    else
    {
        Console.WriteLine("Третьей цифры нет"); //сообщение, если ввели число менее трех цифр
    }
}
else
{
    Console.WriteLine("Вы ввели не число"); //сообщение, если ввели не цифры
}
*/

//Второй вариант
Console.WriteLine("Введите число"); //запрашиваем ввод данных
int  number = int.Parse(Console.ReadLine()??"0"); //считываем данные
int digitCount = (int)Math.Log10(number) + 1; //находим количество цифр в числе

if(digitCount >=3)
{
    int power = digitCount - 3; //объявляем переменную для степени. Минус три - потому что нас интересует третья цифра числа. 
    Console.WriteLine("" + ((int)(number/(Math.Pow(10,power)))%10));
}
else
{
    Console.WriteLine("Третьей цифры нет"); //сообщение, если ввели число менее трех цифр 
}