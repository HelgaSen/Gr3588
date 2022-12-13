// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

int arrLen = ReadArrayLength("Введите длину массива.");
int[] array = GenArray(arrLen, 1, 100);
PrintArray(array);
int number = ReadData("Введите число от 1 до 100");
int result = SearchNumber(array);
PrintData(result);

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int ReadArrayLength(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] outArray = new int[len];
    for (int i = 0; i < len; i++)
    {
        outArray[i] = new Random().Next(minValue, maxValue);
    }
    return outArray;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]" + "\n");
}

int SearchNumber(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number)
        {
            res = i;
        }
    }
    return res;
}

void PrintData(int res)
{
    if (res != 0)
    {
        Console.WriteLine("Число найдено в массиве. Индекс элемента: " + res);
    }
    else
    {
        Console.WriteLine("Число в массиве не найдено");
    }
}