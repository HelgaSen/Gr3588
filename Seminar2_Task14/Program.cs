//Программа, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число некратно первому, то программа выводит остаток от деления.

int number = int.Parse(Console.ReadLine()??"0");

int result1 = number%7;
int result2 = number%23;

if ((result1) ==0 && (result2==0))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

