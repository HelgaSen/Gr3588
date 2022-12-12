// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

string[] inputDataArray = ReadData("Введите данные в формате: число1 авифметическое действие (+,-,*,/,^) число 2. ");

char operationType = Convert.ToChar(inputDataArray[0]);
int number1 = int.Parse(inputDataArray[1]);
int number2 = int.Parse(inputDataArray[2]);
int result = Calculator(operationType, number1, number2);

PrintData("Решение: ", result);

//Методы 
string[] ReadData(string msg) //запрашиваем и считываем данные
{
    Console.WriteLine(msg);
    string inputString = Console.ReadLine() ?? "0";

    char ActionTypeSearch(string inputStr) //метод для определения выбранного пользователем арифмитического действия
    {
        char actionType = 'f';
        if (inputStr.Contains('+')) actionType = '+';
        if (inputStr.Contains('-')) actionType = '-';
        if (inputStr.Contains('*')) actionType = '*';
        if (inputStr.Contains('/')) actionType = '/';
        if (inputStr.Contains('^')) actionType = '^';
        return actionType;
    }
    string opType = ActionTypeSearch(inputString).ToString();  //приводим данные к единому формату для записи в массив типа string
    int symbolPlace = inputString.IndexOf(opType); //определяем позицию символа
    string firstDigit = inputString.Substring(0, symbolPlace).Trim(); //делаем кусь спереди до символа, отсекаем лишние пробелы
    string secondDigit = inputString.Substring(symbolPlace + 1).Trim(); //делаем кусь после символа, отсекаем лишние пробелы
    string[] consoleData = { opType, firstDigit, secondDigit };//записываем инфо в массив для дальнейшей обработки
    return consoleData;
}

int Calculator(char actionType, int numA, int numB) //запускаем арифметическое вычисление в зависимости от указанного в консоли символа
{
    switch (actionType)
    {
        case '+': return numA + numB;
        case '-': return numA - numB;
        case '*': return numA * numB;
        case '/': return numA / numB;
        case '^': return (int)Math.Pow(numA, numB);
        default: return 0;
    }
}

void PrintData(string msg, int res) //выводим результат в консоль
{
    Console.WriteLine(msg + res);
}
