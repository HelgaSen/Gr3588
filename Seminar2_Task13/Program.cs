//Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
string digit = Console.ReadLine() ?? "0";
int checkNumber = 0;
if(int.TryParse(digit,out checkNumber))
{
    if(digit.Length >=3) 
        {
            char[] array = new char[digit.Length]; 
            array = digit.ToCharArray(0,digit.Length);
            Console.WriteLine(array[2]);    
        }
    else
        {
            Console.WriteLine("Третьей цифры нет");   
        }
}
else
{
    Console.WriteLine("Вы ввели не число");   
}
