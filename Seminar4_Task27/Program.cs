//Программа, которая принимает на вход число и выдаёт сумму цифр в числе.

int number = ReadData("Введите число");

int result1 = DigitSum(number);

PrintData("Сумма цифр введенного числа ", result1);

//Методы
int ReadData(string msg) //запрашиваем и считываем число
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int DigitSum(int num) //считаем сумму цифр в числе циклом через остаток отделения на 10
{
    int sum = 0;
    while (num >0)
    {
        sum = sum + num%10;
        num = num/10;
    }
    return sum;
}

void PrintData(string msg, int result) //выводим результат в консоль
{
    Console.WriteLine(msg + result);
}
