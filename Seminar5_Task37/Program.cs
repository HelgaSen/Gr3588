// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] startArray = GenArray(10,1,35);
PrintArray(startArray);
int[] resultArray = ConvertArray(startArray);
PrintArray(resultArray);

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
    Console.Write("\n"+"[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

int[] ConvertArray(int[] array)
{
    int[] outArray = new int[array.Length/2];
    for (int i = 0; i < array.Length/2; i++)
    {

            outArray[i] = array[i]*array[array.Length-1-i];
        
    }
    return outArray;
}

