//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

//Операция умножения двух матриц выполнима только в том случае, если число столбцов в первом сомножителе равно числу строк во втором

int rowA = ReadData("Введите количество строк первой матрицы: ");
int columnA = ReadData("Введите количество столбцов первой матрицы: ");
int[,] matrixA = new int[rowA, columnA];
Fill2DArray(matrixA, 1, 9);
Print2DArray(matrixA);
Console.WriteLine();

int rowB = ReadData("Введите количество строк второй матрицы: ");
int columnB = ReadData("Введите количество столбцов второй матрицы: ");
int[,] matrixB = new int[rowB, columnB];
Fill2DArray(matrixB, 1, 9);
Print2DArray(matrixB);
Console.WriteLine();

if (CanWeMultiplicateMatrixs(matrixA,matrixB))
{
int[,] resultMatrix = MatrixProduct(matrixA,matrixB);
Print2DArray(resultMatrix);
}
//=========МЕТОДЫ============

//Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполнение массива случайными числами
void Fill2DArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

// Печать двумерного массива
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));

        }
        Console.WriteLine();
    }
}

// Проверка согласованности матриц
bool CanWeMultiplicateMatrixs(int[,] arr, int[,] matr)
{
    if (arr.GetLength(1) == matr.GetLength(0))
    {
        return true;
    }
    else
    {
        Console.WriteLine("Матрицы не могут быть перемножены, так как число столбцов первой матрицы не равно числу строк второй матрицы.");
        return false;
    }
}

int [,] MatrixProduct(int[,] arr, int[,] matr)
{
    int[,] product = new int[arr.GetLength(0),matr.GetLength(1)];
    for(int i =0; i <arr.GetLength(0);i++)
    {
        for(int j = 0; j<matr.GetLength(1);j++)
        {
            int sum = 0;
            for(int m = 0; m<arr.GetLength(1);m++)
            {   
                sum = sum + arr[i,m]*matr[m,j];
                
            }
            product[i,j] = sum;
        }
    }
    return product;
}