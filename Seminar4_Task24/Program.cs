// Программа, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int number = ReadData("Введите число A: ");

DateTime d1 = DateTime.Now;
int result1 = SumSimpleOption(number);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int result2 = SumGaussOption(number);
Console.WriteLine(DateTime.Now - d2);

PrintData("Сумма чисел от 1 до A составляет (алгаритмический метод) ", result1);
PrintData("Сумма чисел от 1 до A составляет (аналитический метод) ", result2);

int SumSimpleOption(int numA)
{
    int sumOfNumbers = 0;
    for (int i = 1; i <= numA; i++)
    {
        sumOfNumbers += i;
    }
    return sumOfNumbers;
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

int SumGaussOption(int numA)
{
    int sumOfNumbers = 0;
    sumOfNumbers = ((1 + numA) * numA) / 2;
    return sumOfNumbers;
}