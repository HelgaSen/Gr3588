// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int x = ReadData("Введите количество элементов X ");
int y = ReadData("Введите количество элементов Y ");
int z = ReadData("Введите количество элементов Z ");

// int[,,] arr3D = Fill3DArray(x, y, z, 0, 9);
// Print3DArrayColor(arr3D);
// Console.WriteLine();

int listInfo = ReadData("Какими неповторяющимися числами будем заполнять массив? Введите ответ в формате цифры, где 2 - двузначные, 3 - трехзначные и т.д. Ваш ответ: ");

int listLen = (int)Math.Pow(10,listInfo)-(int)Math.Pow(10,listInfo-1);
int statrPos = (int)Math.Pow(10,listInfo-1);

if(x*y*z < listLen)
{
List<int> numbers = FillList(listLen,statrPos);
int[,,] array3D = Fill3DArrayUnicNums(x,y,z,numbers);
Print3DArrayColor(array3D);
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Вывести массив с указанными параметрами невозможно, т.к. числа начнут повторяться");
    Console.ResetColor();
}

//============МЕТОДЫ============

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Создание списка последовательных целых чисел в заданном диапазоне
List<int> FillList(int listLength, int startNum)
{
    List<int> numbers = new List<int>();
    for (int i = 0; i < listLength; i++)
    {
        numbers.Add(startNum + i);
    }
    return numbers;
}

// // Генерируем трехмерный массив, заполненный случайными числами
// int[,,] Fill3DArray(int countRow, int countColumn, int count3, int topBorder, int downBorder)
// {
//     System.Random rand = new System.Random();
//     int[,,] array3D = new int[countRow, countColumn, count3];
//     for (int i = 0; i < countRow; i++)
//     {
//         for (int j = 0; j < countColumn; j++)
//         {
//             for (int k = 0; k < count3; k++)
//             {
//                 array3D[i, j, k] = rand.Next(topBorder, downBorder + 1);
//             }
//         }
//     }
//     return array3D;
// }

//Печать трехмерного массива с цветовой раскраской
void Print3DArrayColor(int[,,] matrix)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.ForegroundColor = col[matrix[i, j, k] % 15];
                Console.Write(matrix[i, j, k]);
                Console.ResetColor();
                Console.Write("(" + i + "," + j + "," + k + ")" + "     ".Substring(matrix[i, j, k].ToString().Length));// + "     ".Substring(matrix[i, j, k].ToString().Length)
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

// Выбор случайного числа из списка с последующим удалением 
int GenUnicNum(List<int> num)
{
    int index = new Random().Next(0, num.Count);
    int outnum = num[index];
    num.RemoveAt(index);
    return outnum;
}

//Заполнение трехмерного массива неповторяющимися числами N.B.(!) Метод в методе
int[,,] Fill3DArrayUnicNums(int countRow, int countColumn, int count3, List<int> nums)
{
    int[,,] array3D = new int[countRow, countColumn, count3];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            for (int k = 0; k < count3; k++)
            {
                array3D[i, j, k] = GenUnicNum(nums);
            }
        }
    }
    return array3D;
}

