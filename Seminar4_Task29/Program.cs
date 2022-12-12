// Программа, которая задаёт массив из 8 элементов и выводит их на экран. * Ввести с клавиатуры длину массива и диапазон значений элементов

int arrLen = ReadArrayLength("Введите длину массива.");
int[] valueRange = ReadValueRange("Введите диапазон значений элементов через запятую (например, 2,19)");

int startRange = valueRange[0];
int endRange = valueRange[1];
int[] array = GenArray(arrLen, startRange, endRange);

PrintData("Сгенерированный массив:", array);

//Методы
int ReadArrayLength(string msg) //запрашиваем и считываем длину массива
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[] ReadValueRange(string msg) //запрашиваем и считываем диапазон значений
{
    Console.WriteLine(msg);
    string inputString = Console.ReadLine() ?? "0";
    int commaPlace = inputString.IndexOf(",");
    int firstDigit = int.Parse(inputString.Substring(0, commaPlace).Trim());
    int secondDigit = int.Parse(inputString.Substring(commaPlace + 1).Trim());
    int[] consoleData = { firstDigit, secondDigit };
    return consoleData;
}

int[] GenArray(int len, int start, int finish) //формируем массив с заданными параметрами
{
    int[] outArray = new int[len];
    for (int i = 0; i < len; i++)
    {
        outArray[i] = new Random().Next(start, finish + 1);
    }
    return outArray;
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

void PrintData(string msg, int[] arr) //выводим результат в консоль
{
    Console.WriteLine(msg);
    PrintArray(arr);
}
