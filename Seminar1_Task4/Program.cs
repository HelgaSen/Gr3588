//Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число"); //Запрашиваем входные данные
string? inputLine1 = Console.ReadLine(); //Считываем данные с консоли

Console.WriteLine("Введите второе число");
string? inputLine2 = Console.ReadLine();

Console.WriteLine("Введите третье число");
string? inputLine3 = Console.ReadLine();

if (inputLine1 != null && inputLine2 != null && inputLine3 != null) //Проверяем, чтобы данные не были пустыми
{
    int[] numbers = new int[3]; //создаем новый массив numbers, состоящий из трех целочисленных элементов 
    numbers[0] = int.Parse(inputLine1); //присваиваем значения элементам массива из входных данных
    numbers[1] = int.Parse(inputLine2);
    numbers[2] = int.Parse(inputLine3);

    Array.Sort(numbers); //используем метод sort для сортировки элементов массива по возрастанию
    Console.WriteLine("Максимальное из введенных чисел " + numbers[numbers.Length - 1]); //выводим результат в консоль. Максимальное число после сортировки - это последний элемент массива
}