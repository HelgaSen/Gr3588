// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int arrLen = ReadArrayLength("Введите длину массива.");

int[] startArray = GenArray(arrLen,-10,10);
PrintArray(startArray);

int[] inversedArray = ArrayInvers(startArray);
PrintArray(inversedArray);

int ReadArrayLength(string msg) //запрашиваем и считываем длину массива
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

int[] ArrayInvers(int[] array)
{
    int[] outArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        outArray[i] = array[i] * (-1);
    }
    return outArray;
}
