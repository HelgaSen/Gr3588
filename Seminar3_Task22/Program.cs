//программа, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.


int number = ReadData("Введите число N: ");

string outLine = LineBuilder(number, 1 );
PrintData("", outLine);

outLine = LineBuilder(number, 2 );
PrintData("", outLine);

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg, string result)
{
    Console.WriteLine(msg + result);
}

string LineBuilder(int num, int power)
{
    string line = string.Empty;
    for (int i = 1; i < num; i++) 
    {
        line = line + Math.Pow (i, power) + " ";
    }
    line = line + Math.Pow(num,power);
    return line;
}