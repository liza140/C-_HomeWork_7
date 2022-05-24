// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника* 
// Показать только нечетные числа в треугольнике

// Создание массива
int[,] CreateArray(int m)
{
    int[,] array = new int[m, m];
    return array;
}

// Заполнение треугольника

void FillTriangle(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i, 0] = 1;
        array[i, i] = 1;
    }
    for (int i = 2; i < array.GetLength(0); i++)
    {
        for (int j = 1; j <= i; j++)
        {
            array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
        }
    }
}

// равнобедренное представление треугольника
void PrintFinalTriangle(int[,] array)
{
    int cell = 3;
    int col = cell * array.GetLength(0);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 5); //Добавила "5" для отступа от верхнего края
            if (array[i, j] != 0)
            {
                if (array[i, j] % 2 != 0)
                    Console.Write($"{array[i, j]}  ");
                else Console.Write($"   ");
            }
            col += cell * 2;
        }
        col = cell * array.GetLength(0) - cell * (i + 1);
        Console.WriteLine();
    }
}

int M = 10;
int[,] Triangle = CreateArray(M);
FillTriangle(Triangle);
PrintFinalTriangle(Triangle);