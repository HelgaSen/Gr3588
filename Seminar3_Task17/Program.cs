// программа, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
//Первый вариант решения. Не оптимальный, с ветвлением.
//(1 этап) Ввод данных
Console.WriteLine("Введите x: ");
int x = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите y: ");
int y = int.Parse(Console.ReadLine() ?? "0");

//(2 этап) Решение
if (x > 0 && y > 0)
{
    Console.WriteLine("Точка в четверти 1");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("Точка в четверти 2");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("Точка в четверти 3");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("Точка в четверти 4");
}
*/

//Второй вариантю Предпочтительный. С методами.
//(1 этап) с методом

//Метод читает данные от пользователя
int ReadData(string msg) 
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int x = ReadData("Введите x: ");
int y = ReadData("Введите y: ");

//Метод определяет четверть по координатам
void PrintQuterTest()
{
if (x > 0 && y > 0) Console.WriteLine("Точка в четверти 1");
if (x > 0 && y < 0) Console.WriteLine("Точка в четверти 2");
if (x < 0 && y < 0) Console.WriteLine("Точка в четверти 3");
if (x < 0 && y > 0) Console.WriteLine("Точка в четверти 4");
}

PrintQuterTest();