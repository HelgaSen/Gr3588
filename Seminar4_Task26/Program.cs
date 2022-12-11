//программу, которая принимает на вход число и выдаёт количество цифр в числе.

int number = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;
int res1 = DigitCountSimple(number);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = DigitCountLog(number);
Console.WriteLine(DateTime.Now - d2);

DateTime d3 = DateTime.Now;
int res3 = DigitCountString(number);
Console.WriteLine(DateTime.Now - d3);

PrintData("Вы ввели число, состоящее из  ", res1);
PrintData("Вы ввели число, состоящее из  ", res2);
PrintData("Вы ввели число, состоящее из  ", res3);


int DigitCountLog(int num)
{
    int res = 0;
    res = (int)Math.Log10(num)+1;
    return res;
}

int DigitCountSimple(int num)
{
    int res = 0;
    while(num >0)
    {   
        res++;
        num = num/10;
    }
    return res;
}

int DigitCountString(int num)
{
    int res = 0;
    res = num.ToString().Length; 
    return res;
}

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg, int result)
{
    Console.WriteLine(msg + result);
}
