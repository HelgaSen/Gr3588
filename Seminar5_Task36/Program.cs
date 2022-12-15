// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] RandomArray = GenArray(10, 10, 20);//вызываем метод создания массива, передаем параметры.
PrintArray(RandomArray);//выводим массив в консоль

DateTime d1 = DateTime.Now; //засекаем время работы метода
int result1 = SumOdd(RandomArray);//вызываем метод поиска суммы элементов массива с нечетным индексом
PrintData(result1); //выводим результат в консоль
Console.WriteLine("\n" + "Время выполнения через FOR и вложенный метод проверки четности  " + (DateTime.Now - d1)); //выводим в консоль время работы метода

DateTime d2 = DateTime.Now;
int result2 = SumOddWhile(RandomArray);
Console.WriteLine("Время выполнения через WHILE  " + (DateTime.Now - d2) + "\n");

//HARD_Найдите все пары в массиве и выведите пользователю

string pairs = FindCouple(RandomArray);
Console.WriteLine("Пары в массиве и их индексы:" + "\n" + pairs);

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

void PrintData(int res) //метод для вывода в консоль результата
{
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {res}");
}

int SumOdd(int[] array) // метод для нахождения суммы элементов массива, имеющих нечетный индекс
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (EvenCheck(i) == false) res = res + array[i];
    }
    return res;
}

int SumOddWhile(int[] array) //метод для нахождения суммы элементов массива, имеющих нечетный индекс через цикл While. Так экономится время и память.
{
    int res = 0;
    int i = 1;
    while (i < array.Length)
    {
        res += array[i];
        i = i + 2;
    }
    return res;
}

string FindCouple(int[] array) //метод поиска пар чисел в массиве
{
    string couple = string.Empty;
    List<int> checklist = new List<int>();//создаем список для хранения найденный индексов
    for (int i = 0; i < array.Length - 1; i++) // просматриваем элементы массива
    {
        bool exist = checklist.Contains(i); //проверяем, есть ли индекс в массиве, где хранятся уже задействованные ранее индексы
        if (exist) i = i + 1; //если индекс уже встречался, то переключаемся на следующий
        for (int j = i + 1; j < array.Length; j++) //берем следующий после i элемент и сравниваем с i, потом следующий тоже с i и т.д.
        {
            exist = checklist.Contains(j); //проверяем, есть ли индекс в массиве, где хранятся уже задействованные ранее индексы
            if (exist) j = j + 1; //если индекс уже встречался, то переключаемся на следующий
            if (array[i] == array[j]) //если найдено совпадение, записываем в переменную
            {
                couple = couple + array[i] + " - " + i + "," + j + "\n";
                checklist.Add(i); //добавляем индекс в список
                checklist.Add(j);
                break;
            }
        }
    }

    return couple;
}