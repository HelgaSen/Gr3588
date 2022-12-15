// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

double[] RandomArray = GenArray(10, -10, 20);//вызываем метод создания массива, передаем параметры.
PrintArray(RandomArray);//выводим массив в консоль

double min = RandomArray.Min();
double max = RandomArray.Max();

double result = max - min;

PrintData("Минимальный элемент массива: ", min);
PrintData("Максимальный элемент массива: ", max);
PrintData("Разница между максимальным и минимальным значениями: ", result);

InsertSort(RandomArray);
PrintArray(RandomArray);

//методы
double[] GenArray(int len, int minValue, int maxValue) //метод для созднания нового массива случайных чисел
{
    Random rnd = new Random();
    double[] outArray = new double[len];
    for (int i = 0; i < len; i++)
    {
        outArray[i] = rnd.Next(minValue, maxValue) + rnd.NextDouble();
    }
    return outArray;
}

void PrintArray(double[] arr) //метод выводит в консоль массив
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i].ToString("F" + 2) + "," + "\n");
    }
    Console.Write(arr[arr.Length - 1].ToString("F" + 2) + "]" + "\n");
}

void PrintData(string msg, double res) //метод для вывода в консоль результата
{
    Console.WriteLine(msg + res);
}

void Mix(double[] array, int i, int j)
{
    double temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}

void InsertSort(double[] array)
{
    double a = 0;
    int j = 0;
    for (int i = 1; i < array.Length; i++)
    {
        a = array[i];
        j = i;
        while (j > 0 && array[j - 1] > a)
        {
            Mix(array, j, j - 1);
            j -= 1;
        }
        array[j] = a;
    }
}