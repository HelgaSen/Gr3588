// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int number = ReadData("Введите число N: ");
string resultLine = LineGenRec(number);
PrintResult(resultLine);

//========МЕТОДЫ==========

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//Формирование строки натуральных числе в промежутке от N до 1 рекурентным методом
string LineGenRec(int num)
{
    if (num <= 0)
    {
        return string.Empty;
    }
    else
    {
        string outLine = num + "," + LineGenRec(num - 1);
        return outLine = outLine.TrimEnd(',');
    }
}

// Печать результата
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}
