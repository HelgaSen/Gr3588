//Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Dictionary<int, int> Palindroms = new Dictionary<int, int>();
int x1 = 0;
for (int i = 1000; i < 10000; i++)
{
    if (i / 1000 == i % 10 && (i / 100) % 10 == (i / 10) % 10)
    {
        x1 = x1 + 1;
        Palindroms.Add(x1, i);
    }
}

// foreach (var kvp in Palindroms) {
//             Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
//         }

int number = ReadData("Введите пятизначное число: ");
int numberForCheck = (number / 10000) * 1000 + ((number / 1000) % 10) * 100 + ((number / 10) % 10) * 10 + number % 10;
//Console.WriteLine(numberForCheck);

bool digitIsPalindrome = Palindroms.ContainsValue(numberForCheck);

PrintData("Указанное число палиндром - " + digitIsPalindrome);

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)
{
    Console.WriteLine(msg);
}
