﻿// Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

//Первый вариант решения

int digitLength = 0; //объявляем переменную для определния длины строки
int number = 0; //объявляем переменную для записи введенного числа
do
{
    Console.WriteLine("Пожалуйста, введите трехзначное число"); //запрашиваем ввод данных
    string digit = Console.ReadLine() ?? "0";    //считываем данные с консоли
        if(int.TryParse(digit,out number)) //проверяем, являются ли введенные данные числом
            {
                if(digit.Length == 3) //проверка на трехзначность
                    {
                        digitLength = digit.Length; //записываем значение в переменную для выхода из цикла
                        Console.WriteLine(((int)(number/10))%10); //выводим решение в консоль
                    }
                else
                    {
                        Console.Write("Вы ввели некорректное число. ");  //сообщение об ошибке, если ввели не трехзначное число
                    }
            }
        else
            {
                Console.Write("Вы ввели не число. "); //сообщение об ошибке, если ввели не число
            }
}
while (digitLength != 3);

//Второй вариант решения
/*
Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine() ?? "0"); 
Console.WriteLine(((int)(number/10))%10);
*/



