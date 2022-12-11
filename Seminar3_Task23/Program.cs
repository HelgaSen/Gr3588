// Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.1
int number = ReadData("Введите число N: ");
int numberLength = (int)Math.Log10(Math.Pow(number,3))+1;
char symbol = '-';

string outLine = LineBuilder(number, 1,numberLength);
PrintLine(symbol,outLine.Length);
PrintData("", outLine);
PrintLine(symbol,outLine.Length);

outLine = LineBuilder(number, 3,numberLength);
PrintData("", outLine);
PrintLine(symbol,outLine.Length);

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg, string result)
{
    Console.WriteLine(msg + result);
}

void PrintLine(char sym, int len)
{
    Console.WriteLine(new string(sym, len));
}

string LineBuilder(int num, int power, int numlength)
{
    string line = "|";
    for (int i = 1; i < num; i++)
    {
        string str = "";
        line = line + Math.Pow(i, power) + str.PadRight(numlength - ((int)Math.Log10(Math.Pow(i, power)))) + "|";
    }
    string str2 = "";
    line = line + Math.Pow(num, power) + str2.PadRight(numlength - ((int)Math.Log10(Math.Pow(num, power)))) + "|";
    //line = String.Format("")
    return line;
}
