// Напишите программу, которая заполнит спирально массив 4 на 4.

int squareSide = ReadData("Введите целое число ");
int[,] array = new int[squareSide, squareSide];
int i = 0; //задаем переменную для индекса по строке
int j = 0; //задаем переменную для индекса по столбцу
int step = 1; //переменная "шага" и первый элемент массива. 

while (squareSide != 0) //цикл будет работать, пока есть куда "шагать"
{
    int k = 0; //переменная для использования в циклах, чтобы считать шаги
    do { array[i, j++] = step++; } while (++k < squareSide - 1); //нужно, чтобы при нечетной длине стороны серединка не оставалась пустой. Инкремент ++ ставим перед переменной, т.к. сначала получаем значение увеличенной переменной, а потом работаем с резульататом
    for (k = 0; k < squareSide - 1; k++) //тут у нас индекс по столбцу уже накоплен. Для первого прохода он равен максимальному. Записываем следующие числа в крайний правый столбец, увеличивая индекс строки, т.е. спускаемся вниз
    {
        array[i++, j] = step++;
    }
    for (k = 0; k < squareSide - 1; k++)//сейчас мы в нижнем правом углу квадрата с указанной стороной. Идем влево по нижней строке, т.е. уменьшаем индекс столбца.
    {
        array[i, j--] = step++;
    }
    for (k = 0; k < squareSide - 1; k++)//теперь мы в нижнем левом углу. Идем вверх, уменьшая индекс строки. Индекс столбца теперь снова 0.
    {
        array[i--, j] = step++;
    }
    i++; 
    j++;//перемещаемся вниз вправо по диагонали для продолжения
    if (squareSide < 2)
    {
        squareSide = 0;
    }
    else
    {
        squareSide = squareSide - 2; //рамка уже заполнена, т.е. нужно заполнить квадрат внутри. Его сторона на 2 короче заданной.
    }
}
Print2DArrayColor(array);

//============МЕТОДЫ==============

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
//Печать двумерного массива с цветовой раскраской
void Print2DArrayColor(int[,] matrix)
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
            Console.ForegroundColor = col[matrix[i, j] % 15];
            Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}