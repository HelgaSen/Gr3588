// Программа, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

int[] randomArray = GenArray(50, 10, 100);//вызываем метод создания массива, передаем параметры.
PrintArray(randomArray);//выводим массив в консоль

DateTime d1 = DateTime.Now;
int[] swapedArray = ArrayNewSwap(randomArray);
Console.WriteLine("\n" +  (DateTime.Now - d1)); 
PrintArray(swapedArray);

DateTime d2 = DateTime.Now;
int[] secondSwapedArray = SwapedArray(swapedArray);
Console.WriteLine("\n" +  (DateTime.Now - d2)); 
PrintArray(secondSwapedArray);

//методы
int[] GenArray(int len, int minValue, int maxValue) //метод для созднания нового массива случайных чисел
{
    Random rnd = new Random();
    int[] outArray = new int[len];
    for (int i = 0; i < len; i++)
    {
        outArray[i] = rnd.Next(minValue, maxValue);
    }
    return outArray;
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

int[] ArrayNewSwap(int[] array)
{
    int[] outArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        outArray[i] = array[array.Length-1-i];
    }
    return outArray;
}

int[] SwapedArray(int[] array)
{
    int bufElement = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        bufElement = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = array[i];
        array[i] = bufElement;
    }
    return array;
}