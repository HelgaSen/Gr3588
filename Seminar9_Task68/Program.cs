// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int numberM = ReadData("Введите неотрицательное число M: ");
int numberN = ReadData("Введите неотрицательное число N: ");
int result = AckermannFunc(numberM,numberN);

PrintResult("Результат вычисления функции Аккермана для указанных чисел: ",result);

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//Вычисление функции Аккермана
int AckermannFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (n == 0)
        {
            return AckermannFunc(m - 1, 1);
        }
        return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
    }

}

// Печать результата
void PrintResult(string prefix, int res)
{
    Console.WriteLine(prefix + res);
}
