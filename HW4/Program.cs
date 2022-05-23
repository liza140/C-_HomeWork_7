// Спирально заполнить двумерный массив:
//  1  2  3  4
// 12 13 14  5
// 11 16 15  6
// 10  9  8  7 

// Создание массива
int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    return array;
}

// Спиральное заполнение массива
void SpiralFillArray(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int count = 1;
    for (int i = 0; i <= row / 2; i++)
    {
        for (int j = i; j < col - i; j++) // заполнение первой строки
        {
            if (array[i, j] == 0) array[i, j] = count++;
        }
        for (int k = i + 1; k < row - i; k++) // заполнение последнего столбца
        {
            if (array[k, col - 1 - i] == 0) array[k, col - 1 - i] = count++;
        }
        for (int l = col - 1 - i; l >= 0; l--) // заполнение последней строки
        {
            if (array[row - 1 - i, l] == 0) array[row - 1 - i, l] = count++;
        }
        for (int n = row - 1 - i; n > 0; n--) // заполнение первого столбца
        {
            if (array[n, i] == 0) array[n, i] = count++;
        }
    }

}

// Печать массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


int M = 5;
int N = 5;
int[,] Array = CreateArray(M, N);
SpiralFillArray(Array);
PrintArray(Array);


