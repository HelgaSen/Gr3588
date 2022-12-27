// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] matrix = new int[row, column];

if (TTest(matrix))
{
    Fill2DArray(matrix, 1, 99);
    Print2DArray(matrix);
    Console.WriteLine();

    int[] sums = Sum2DArrayRows(matrix);
    Console.WriteLine("Сумма строк двумерного массива: ");
    PrintArray(sums, MinElememtIndex(sums));
    Console.WriteLine();
    PrintDataColorRes("Наименьшая сумма элементов по строке заданного массива: ", MinElement(sums), ". Это ", (MinElememtIndex(sums) + 1), " строка");
}

//=========МЕТОДЫ============

//Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполнение массива случайными числами
void Fill2DArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

// Печать двумерного массива
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));

        }
        Console.WriteLine();
    }
}

// Проверка является ли массив прямоугольным
bool TTest(int[,] arr)
{
    if (arr.GetLength(0) != arr.GetLength(1))
    {
        return true;
    }
    else
    {
        Console.WriteLine("Заданный массив не соответствует условию задачи (не прямоугольный)");
        return false;
    }
}

//Подсчет сумм по строкам двумерного массива
int[] Sum2DArrayRows(int[,] matr)
{
    int[] sumRes = new int[matr.GetLength(0)];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            rowSum = rowSum + matr[i, j];
        }
        sumRes[i] = rowSum;
    }
    return sumRes;
}

// Печать одномерного массива с выделением минимального элемента цветом
void PrintArray(int[] arr, int minElInd)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == minElInd)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(arr[i] + "\n");
            Console.ResetColor();
        }
        else
        {
            Console.Write(arr[i] + "\n");
        }
    }
}

// Вывод сообщения о результате в формате текст1-переменная1-текст2-переменная2-текст3 с цветом
void PrintDataColorRes(string msg, int var1, string msg2, int var2, string msg3)
{
    Console.Write(msg);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(var1);
    Console.ResetColor();
    Console.Write(msg2);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(var2);
    Console.ResetColor();
    Console.WriteLine(msg3);
}

//Поиск минимального значения в одномерном массиве
int MinElement(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

//Поиск индекса минимального значения в одномерном массиве
int MinElememtIndex(int[] array)
{
    int minElIndex = 0;
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            minElIndex = i;
        }
    }
    return minElIndex;
}
