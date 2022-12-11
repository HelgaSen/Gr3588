////программу, которая принимает на вход число и выдаёт количество цифр в числе.
using System.Numerics; //Добавили, чтобы понял BigInteger

int number = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;
BigInteger res1 = CalcFactor(number);
Console.WriteLine(DateTime.Now - d1);

PrintData("Факториал N равер ", res1);

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

BigInteger CalcFactor(int num)
{
    BigInteger res = 1;
    for (int i = 1; i <= num; i++)
    {
        res *= i;
    }
    return res;
}

void PrintData(string msg, BigInteger result)
{
    Console.WriteLine(msg + result);
}
