// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int numberM = ReadData("Введите натуральное число M: ");
int numberN = ReadData("Введите натуральное число N: ");
int sum = 0;
if (numberM == numberN) //проверка, если введены одинаковые числа
{
    sum = 0;
}
else
{
    if (CompareMN(numberM, numberN))
    {
        sum = SumMNRec(numberM, numberN);
    }
    else
    {
        sum = SumMNRec(numberN, numberM);
    }
}

PrintResult("Сумма натуральных элементов в промежутке от M до N составляет ", sum);

//=========МЕТОДЫ===========

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//Формирование строки натуральных числе в промежутке от N до 1 рекурентным методом
int SumMNRec(int m, int n)
{
    if (m >= n)
    {
        return n;
    }
    else
    {
        return m + SumMNRec(m + 1, n);
    }

}

// Печать результата
void PrintResult(string prefix, int res)
{
    Console.WriteLine(prefix + res);
}

// Проверка на большее число
bool CompareMN(int m, int n)
{
    if (m < n)
    {
        return true;
    }
    else
    {
        return false;
    }
}
