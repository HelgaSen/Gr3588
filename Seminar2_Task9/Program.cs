//Создаем экземпляр класса рандомайзер
/*System.Random numberSintezator = new System.Random();

//Первый вариант решения

//int number = numberSintezator.Next(10, 100); //Получем новое случайное число
//Console.WriteLine(number); //Выводим данные в консоль

//int firstNumber = number / 10; //Получаем первое и второе число поотдельности    
//int secondNumber = number % 10;
/*
//Сравниваем числа
if (firstNumber > secondNumber)
{
    Console.WriteLine(firstNumber);
}
else
{
    Console.WriteLine(secondNumber);
}
*/
/*char[] digits = numberSintezator.Next(10,100).ToString().ToCharArray();
Console.WriteLine(digits);

int firstNumber = ((int)digits[0])-48;
int secondNumber=((int)digits[1])-48;

int resultNumber = firstNumber>secondNumber?resultNumber=firstNumber:resultNumber=secondNumber;
Console.WriteLine(resultNumber);

//третий вариант
//объявить массив на все цифры с 10 до 99 и в каждый индекс положить ответ. Т.е.
*/
//Четвертый

System.Random numberSintezator = new System.Random();
int randomNumber = numberSintezator.Next(10, 100); //Получем новое случайное число
Console.WriteLine(randomNumber);
int max = 0; 

while (randomNumber > 0) {
    if (max < randomNumber%10) {
        max = randomNumber%10;
    }
    randomNumber =  randomNumber/10;
}

Console.WriteLine(max);
