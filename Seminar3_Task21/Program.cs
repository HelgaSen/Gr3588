//Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

int[] aCoord = ReadData("Введите числовые значения координат точки A в формате (x,y,z): ");
int ax = aCoord[0];
int ay = aCoord[1];
int az = aCoord[2];
int[] bCoord = ReadData("Введите чичсловые значения координат точки B в формате (x,y,z): ");
int bx = bCoord[0];
int by = bCoord[1];
int bz = bCoord[2];

PrintData("Расстояние между точками ", CalculateLength(ax,ay,az,bx,by,bz));

int[] ReadData(string msg)
{
    Console.WriteLine(msg);
    string coordinte = Console.ReadLine() ?? "0";
    int first = coordinte.IndexOf(',');
    int second = coordinte.IndexOf(',', first + 1);
    int third = coordinte.IndexOf(')');
    int a1 = int.Parse(coordinte.Substring(1, first - 1));
    int a2 = int.Parse(coordinte.Substring(first + 1, second - first - 1));
    int a3 = int.Parse(coordinte.Substring(second + 1, third - second - 1));
    int[] coord = {a1, a2, a3};
    return coord;
}

double CalculateLength(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double res = 0;
    res = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow(z1 - z2, 2));
    return res;
}

void PrintData(string msg, double result)
{
    Console.WriteLine(msg + result);
}