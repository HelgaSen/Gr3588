// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Fill2DArray(row, column, 10, 100);//задаем параметры для создания двумерного массива
Console.WriteLine("Сгенерирован массив:");
Print2DArray(arr2D); //печать массива для проверки
Console.WriteLine(); //перенос строки, чтобы не было мешанины в консоли

string res = Avg(arr2D);
Console.WriteLine("Среднее арифметическое по столбцам: " + "\n" + res);

//Методы
int ReadData(string line) //метод считывает информацию с консоли и преобразовывает в переменную типа int
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder) // Универсальный метод генерации и заполнение двумерного массива
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder);
        }
    }
    return array2D;
}

void Print2DArray(int[,] matrix) //метод печати двумерного массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "      ");
        }
        Console.WriteLine();
    }
}

string Avg(int[,] array)//метод считает среднее арифметическое по столбцам двумерного массива и выводит результат строкой
{
    string result = string.Empty;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        double average = Math.Round((sum / array.GetLength(0)),2);
        result = result + average + "   ";
    }
    return result;
}