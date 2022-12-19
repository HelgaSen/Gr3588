// Программа, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double b1 = ReadData("Введите коэффициент b1");
double k1 = ReadData("Введите коэффициент k1");
double b2 = ReadData("Введите коэффициент b2");
double k2 = ReadData("Введите коэффициент k2");

string result = CrossCoordinate(b1, k1, b2, k2);

PrintData(result, "- координаты точки пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.");

double ReadData(string msg)
{
    Console.WriteLine(msg);
    return double.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res, string msg)
{
    Console.WriteLine(res + msg);
}

string CrossCoordinate(double b1, double k1, double b2, double k2)
{
    double y = (b2 * k1 - k2 * b1) / (k1 - k2);
    double x = (y - b1) / k1;
    string res = "(" + Math.Round(x, 1) + ";" + Math.Round(y, 1) + ")";
    return res;
}