//Программа, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int number = new Random().Next(100,1000);
Console.WriteLine(number);
/*
int fn = number/100;
int sn = number%10;
int result = fn*10 + sn;

Console.WriteLine(result);
*/
//короткий вариант
Console.WriteLine((number/100)*10 + number%10);