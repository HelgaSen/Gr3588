//Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int xh = ReadData("Введите xh: ");
int xv = ReadData("Введите xv: ");
int yh = ReadData("Введите yh: ");
int yv = ReadData("Введите yv: ");

double CalculateLength(int x1, int x2, int y1, int y2)
{
    double res = 0;
    res = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
    return res;
}


void PrintData(string msg, double result)
{
    Console.WriteLine(msg + result);
}

PrintData("Расстояние между точками ", CalculateLength(xh, xv, yh, yv));