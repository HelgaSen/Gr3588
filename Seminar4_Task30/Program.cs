// Программа, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int arrLen = ReadData("Введите длину массива.");
int[] array = GenArray(arrLen);
PrintData("Сгенерированный массив:", array);

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[] GenArray(int len)
{
    int[] outArray = new int[len];
    for (int i = 0; i < len; i++)
    {
        outArray[i] = new Random().Next(0, 2);
    }
    return outArray;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] +",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

void PrintData(string msg, int[] arr)
{
    Console.WriteLine(msg);
    PrintArray(arr);
}
