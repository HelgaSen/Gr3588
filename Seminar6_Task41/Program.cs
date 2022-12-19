// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// //Вариант первый
// int[] nums = ReadStringData("Введите несколько целых чисел через запятую");
// PrintArray(nums); //печатаем полученный преобразованный массив чисел
// int posNumQuantity = CountPositiveNumbers(nums); 
// PrintData("Вы ввели чисел больше нуля: ", posNumQuantity);

// //Методы
// int[] ReadStringData(string msg)//метод преобразует строку, полученную из консоли, в массив целых чисел с помощью системного метода Split. Разбиваем строку над подстроки, парсим их как int
// {
//     Console.WriteLine(msg);
//     string inputData = Console.ReadLine() ?? "0";
//     string[] numbersString = inputData.Split(',');
//     int[] nums = new int[numbersString.Length];
//     for (int i = 0; i < numbersString.Length; i++)
//     {
//         nums[i] = int.Parse(numbersString[i]);
//     }
//     return nums;
// }

// void PrintArray(int[] arr) //метод выводит в консоль массив
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ",");
//     }
//     Console.Write(arr[arr.Length - 1] + "]" + "\n");
// }

// void PrintData(string msg, int res)//метод выводит результат в консоль
// {
//     Console.WriteLine(msg + res);
// }

// int CountPositiveNumbers(int[] array)//метод подсчитывает количество положительных элементов в массиве
// {
//     int res = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) res = res+1;
//     }
//     return res;
// }

// //Второй вариант
// int numberM = ReadData("Введите натуральное число");
// int posNumQuantity = CountPositiveNumbers(numberM);
// PrintData("Вы ввели чисел больше нуля: ",posNumQuantity);

// //Методы
// int ReadData(string msg)//метод запрашивает и ситывает данные с консоли
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// void PrintData(string msg, int res)//метод выводит результат в консоль
// // {
// //     Console.WriteLine(msg + res);
// // }

// int CountPositiveNumbers(int num)//метод подсчитывает количество введенных положительных чисел, запрашивая числа по одному num раз
// {
//     int res = 0;
//     while(num >0)
//     {
//         if(ReadData("Введите целое число")>0) res++;
//         num = num - 1;
//     }
//     return res;
// }

//вариант со звёздочкой

using System.Text.RegularExpressions; //без явного указания сборки не работают регулярные выражения.

int taps = ReadData("Введите количество нажатий");

string inputLine = ReadLineData("Введите любые символы с клавиатуры.");

FindNumbersInString(inputLine,taps);

//Методы
int ReadData(string msg)//метод запрашивает и ситывает данные с консоли
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

string ReadLineData(string msg) //метод считывает нажатие клавиш на клавиатуре заданное количество раз и собирает данные в строку через запятую
{
Console.WriteLine(msg);
string line = "";
for (int i = 0; i < taps; i++)
{
    var key = Console.ReadKey(true); //параметр true указан для того, чтобы после нажатия клавиш ничего не появлялось в консоли
    line = line + String.Format(key.KeyChar.ToString()) + ","; 
}
line = line.TrimEnd(','); //кусь последнюю запятую
return line;
}

void FindNumbersInString(string str, int count)//метод для поиска десятичных цифр в строке с помощью регулярных выражений
{
Regex regex = new Regex(@"\d");//задаем для поиска параметр "любая десятичная цифра"
MatchCollection matches = regex.Matches(str); //задаем коллекциюЮ состоящую из найденных по условию выражений 
int posNums = 0;
if (matches.Count > 0) //если цифры найдены, то накапливаем результат. Каждая найденная цифра +1 к итогу.
{
    foreach (Match match in matches)
    {
        posNums = posNums + 1;
    }
    Console.WriteLine($"Вы совершили нажатий: {count}. Среди введенных символов найдено чисел: {posNums}");
}
else
{
    Console.WriteLine($"Вы совершили нажатий: {count}. Среди введенных символов чисел не найдено");
}
}
