// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
double[,] arr2D = Fill2DArray(row, column, 1, 100);//задаем параметры для создания двумерного массива

Print2DArray(arr2D); //печать массива для проверки
Console.WriteLine(); //перенос строки для разделения обычного и цветного массивов
Print2DArrayColorPerDigit(arr2D); //вывдим в консоль двумерный массив вещественных чисел, где каждая цифра любого числа окрашена в случайный цвет.

//Методы
int ReadData(string line) //метод считывает информацию с консоли и преобразовывает в переменную типа int
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

double[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder) // Универсальный метод генерации и заполнение двумерного массива
{
    System.Random rand = new System.Random();
    double[,] array2D = new double[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = Math.Round(rand.Next(topBorder, downBorder + 1) + rand.NextDouble(), 2);
        }
    }
    return array2D;
}

void Print2DArray(double[,] matrix) //метод печати двумерного массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Print2DArrayColorPerDigit(double[,] matrix)//метод вывода в консоль массива вещественных чисел, где каждая цифра элемента массива окрашена в случайный цвет
{
    //задаем массив из 16 доступных цветов
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            string buf = matrix[i, j].ToString(); //создаем локальную переменную для использования метода Substring, чтобы "покрасить" каждую цифру вещественного числа
            for (int k = 0; k < buf.Length; k++)
            {
                if (buf.Substring(k, 1) == ",")//условие для того, чтобы не красить запятую.
                {
                    Console.Write(buf.Substring(k, 1));
                }
                else//если условие не соблюдается, то красим подстроку в случайный цвет
                {
                    Console.ForegroundColor = col[new System.Random().Next(0, 16)];
                    Console.Write(buf.Substring(k, 1));
                    Console.ResetColor();
                }
            }
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}



