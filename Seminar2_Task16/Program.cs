//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

//Первый вариант решения
/*
int number1 = int.Parse(Console.ReadLine() ?? "0"); 
//Console.WriteLine(number1);

int number2 = int.Parse(Console.ReadLine() ?? "0");
//Console.WriteLine(number2);

if ((int)Math.Pow(number1, 2) == number2 | (int)Math.Pow(number2, 2) == number1)
{
    Console.WriteLine("Является");
}
else
{
    Console.WriteLine("Не является");
}
*/

//Второй вариант решения
/*
Console.WriteLine("является ли одно число квадратом другого ?");
Console.Write("Введите первое число: ");
int firstNumber;
bool isNumber = int.TryParse(Console.ReadLine(), out firstNumber);
validate(isNumber);

Console.Write("Введите второе число: ");
int secondNumber;
isNumber = int.TryParse(Console.ReadLine(), out secondNumber);
validate(isNumber);

Console.WriteLine(isSqrt(firstNumber,secondNumber)? "Да" : "Нет");

void validate(bool isNumber)
{
    if (!isNumber)
    {
        Console.WriteLine("Вы ввели не число, выход");
        Environment.Exit(0);
    }
}

bool isSqrt(int a, int b){
    return (a*a == b) || (b*b == a) ;
}
*/

//Третий вариант
void FindIfNumSquare(int firstNumber, int secondNumber)
{
    bool result = ((firstNumber / secondNumber) == secondNumber);
    if (result == true)
    {
        Console.WriteLine("Число " + firstNumber + " является квадратом числа " + secondNumber);
    }
    else
    {
        Console.WriteLine("Число " + firstNumber + " не является квадратом числа " + secondNumber);
    }
}

int number1 = int.Parse(Console.ReadLine() ?? "0");
int number2 = int.Parse(Console.ReadLine() ?? "0");

FindIfNumSquare(number1, number2);
FindIfNumSquare(number2, number1);