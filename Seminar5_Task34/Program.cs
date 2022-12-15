//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] RandomArray = GenArray(120, 100, 1000);//вызываем метод создания массива, передаем параметры.
PrintArray(RandomArray); //вызываем метод печати созданного массива.
int result = CountEvenElements(RandomArray); //создаем переменную для хранения результата, вызываем метод подсчета четных элементов массива
PrintData(result); //выводим резульат в консоль

BubbleUpSort(RandomArray); //вызываем метод сортировки по возрастанию
Console.WriteLine("\n" + "Отсортированный по возрастанию массив:");
PrintArray(RandomArray);//вызываем метод печати отсортированного массива.

SinkingStoneSort(RandomArray); //вызываем метод отсортированного по убыванию
Console.WriteLine("\n" + "Отсортированный по убыванию массив:");
PrintArray(RandomArray);

//методы
int[] GenArray(int len, int minValue, int maxValue) //метод для созднания нового массива случайных чисел
{
    Random rnd = new Random();
    int[] outArray = new int[len];
    for (int i = 0; i < len; i++)
    {
        outArray[i] = new Random().Next(minValue, maxValue);
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

bool EvenCheck(int number) //метод проверки числа на четность
{
    bool even = false;
    if (number % 2 == 0) even = true;
    return even;
}

int CountEvenElements(int[] array) //метод считает количество чётных элементов в массиве
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (EvenCheck(array[i]) == true) res++; //если остаток от деления на 2 равен 0, то накапливаем результат
    }
    return res;
}

void BubbleUpSort(int[] array) //метод сортировки пузырьком по возрастанию. Перебираем все элементы массива, начиная с первого. Сравниваем со следующим, если первый больше, то меняем их местами
{
    int temp = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}

void SinkingStoneSort(int[] array) //метод сортировки пузырьком по убыванию. Перебираем все элементы массива, начиная с первого. Сравниваем со следующим, если первый больше, то меняем их местами
{
    int temp = 0;
    for (int i = array.Length - 1; i >= 0; i--)
    {
        for (int j = i - 1; j >= 0; j--)
        {
            if (array[i] > array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}

void PrintData(int res) //метод для вывода в консоль результата
{
    if (res != 0)
    {
        Console.WriteLine("\n" + $"В массиве найдено чётных чисел: {res}");
    }
    else
    {
        Console.WriteLine("\n" + "В массиве отсутствуют чётные числа");
    }
}