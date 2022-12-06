//программа, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int ReadData(string msg) 
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int quaterNumber = ReadData("Введите номер четверти: ");

void PrintQuterRange(int num)
{
if (num == 1) Console.WriteLine("x > 0 И y > 0");
if (num == 2) Console.WriteLine("x > 0 И y < 0");
if (num == 3) Console.WriteLine("x < 0 И y < 0");
if (num == 4) Console.WriteLine("x < 0 И y > 0");
}
PrintQuterRange(quaterNumber);