// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Fill2DArray(row, column, 10, 100);//задаем параметры для создания двумерного массива
Console.WriteLine("Сгенерирован массив:");
Print2DArray(arr2D); //печать массива для проверки
Console.WriteLine(); //перенос строки, чтобы не было мешанины в консоли
int[] index2D = ReadStringData("Введите позицию элемента в двумерном массиве в виде x,y: ");

int x = index2D[0]; 
int y = index2D[1];

int result = SearchElement(arr2D, x, y); 
Console.WriteLine(); 
PrintData(result);
Console.WriteLine();

int fibLen = ReadData("Введите количество чисел Фибоначчи: ");
int[] fibArray = FillArrayFibonacci(fibLen);
Console.WriteLine($"Ряд чисел Фибоначчи из {fibLen} элементов: ");
PrintArray(fibArray);
Console.WriteLine();

int[,] fib2DArray = Fill2DArrayFib(fibArray, row, column);
Console.WriteLine($"Ниже зелёным цветом выделен элемент массива с индексом {x},{y}, который Вы указали ранее ");
Console.WriteLine();
Print2DArrayFibColor(fib2DArray, x, y);

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
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[] ReadStringData(string msg)//метод преобразует строку, полученную из консоли, в массив целых чисел с помощью системного метода Split. Разбиваем строку над подстроки, парсим их как int
{
    Console.Write(msg);
    string inputData = Console.ReadLine() ?? "0";
    string[] numbersString = inputData.Split(',');
    int[] nums = new int[numbersString.Length];
    for (int i = 0; i < numbersString.Length; i++)
    {
        nums[i] = int.Parse(numbersString[i]);
    }
    return nums;
}

int SearchElement(int[,] array, int rowNum, int colNum)//метод поиска в двумерном массиве элемента с заданным индексом
{
    int res = -1; //задаем значение для вывода информации об отсутсвии заданного элемента в виде цифра, т.к. метод int
    if (rowNum < array.GetLength(0) && colNum < array.GetLength(1))
    {
        res = array[rowNum, colNum];
    }
    return res;
}

void PrintData(int res)//метод выводит результат в консоль
{
    if (res < 0)
    {
        Console.WriteLine("Элемент с такой позицией в массиве отсутствует.");
    }
    else
    {
        Console.WriteLine("На указанной позиции находится элемент " + res);
    }
}

int[] FillArrayFibonacci(int num)//метод заполняет одномерный массив указанным количеством чисел Фибоначчи 
{
    int[] fibonacci = new int[num];
    fibonacci[0] = 0;
    fibonacci[1] = 1;
    for (int i = 2; i < num; i++)
    {
        fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
    }
    return fibonacci;
}

void PrintArray(int[] arr) //метод выводит в консоль массив
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]" + "\n");
}

int[,] Fill2DArrayFib(int[] array, int rowNum, int colNum)//метод заполняет двумерный массив числами Фибоначчи в случайном порядке
{
    int len = array.Length;
    int[,] matrix = new int[rowNum, colNum];
    for (int i = 0; i < rowNum; i++)
    {
        for (int j = 0; j < colNum; j++)
        {
            matrix[i, j] = array[new System.Random().Next(0, len)];
        }
    }
    return matrix;
}

void Print2DArrayFibColor(int[,] matrix, int x, int y) //метод печати двумерного массива с подсвечиванием заданного элемента цветом
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == x && j == y)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(matrix[i, j] + " ");
                Console.ResetColor();
            }
            else
            {
                Console.Write(matrix[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}
