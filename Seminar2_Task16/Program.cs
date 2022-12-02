//Напишите программу, которая принимает на вход два числа
// и проверяет, является ли одно число квадратом другого.
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
//второй варик
/*Console.WriteLine("является ли одно число квадратом другого ?");
Console.Write("Введите первое число: ");
int firstNumber;
bool isNumber = int.TryParse(Console.ReadLine(), out firstNumber);
validate(isNumber);

Console.Write("Введите второе число: ");
int secondNumber;
isNumber = int.TryParse(Console.ReadLine(), out secondNumber);
validate(isNumber);

Console.WriteLine(isSqrt(firstNumber,secondNumber)? "Да" : "Нет");

void validate(bool isNumber){
    if (!isNumber){
        Console.WriteLine("Вы ввели не число, выход");
        Environment.Exit(0);
    }
}

bool isSqrt(int a, int b){
    return (a*a == b) || (b*b == a) ;
}*/

//третий варик
void Test(int i, int j)
{
    bool result = ((i / j) == j);
    if (result == true)
    {
        Console.WriteLine("Число " + i + " является квадратом числа " + j);
    }
    else
    {
        Console.WriteLine("Число " + i + " не является квадратом числа " + j);
    }
}

int number1 = int.Parse(Console.ReadLine() ?? "0");
int number2 = int.Parse(Console.ReadLine() ?? "0");

Test(number1, number2);
Test(number2, number1);