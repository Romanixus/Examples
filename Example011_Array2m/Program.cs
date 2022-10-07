Console.Clear();
//Двумерный массив
int rows = 0;
int columns = 0;

int[,] matr = new int[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
}

// Заполнение массива случайными числами
int[,] matrix = new int[55, 28];
//PrintArray(matrix); // Выводим пустой массив
FillArray(matrix); // Заполняем массив
Console.WriteLine();
PrintArray(matrix); // Выводим полный массив

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(100, 1000);//[10; 100)
        }
    }
}

