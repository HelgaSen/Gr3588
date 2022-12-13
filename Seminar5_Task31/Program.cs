// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

int posSum = 0;
int negSum = 0;

int[] testArray = GenArray(12,-9,9);
NegPosSum(testArray);
PrintData("Текст ", posSum);
PrintData("Текст ", negSum);
PrintArray(testArray);

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
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}
void PrintArray(int[] arr) //метод для формирования строки отображения массива
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}
void NegPosSum(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            posSum += array[i];
        }
        else
        {
            negSum += array[i];
        }
    }
}
