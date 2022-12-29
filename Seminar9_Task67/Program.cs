// Напишите программу, которая примает на вход число и возвращает сумму цифр числа

int numberN = ReadData("Enter number N: ");
int Sum = RecSumDig(numberN);
PrintResult(Sum);

//==========МЕТОДЫ==============

//Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Вывод результата в консоль
void PrintResult(int prefix)
{
    Console.Write(prefix);
}

//Рекурентный метод нахождения суммы цифр числа
int RecSumDig(int n)
{
    if (n<= 10) return n;
    int result = n%10 + RecSumDig(n/10);
    return result;
}