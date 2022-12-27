//Задание 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:

//8 4 2 4
//5 9 2 3
//1 4 7 2



// int[,] Create2DRandomArray (int rows, int colomns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows,colomns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colomns; j++)
//         {
//             newArray[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2DArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }


// int[,] ChangeRows (int[,] array, int row1, int row2)
// {
//     if (row1 >= array.GetLength(0) || row2 >= array.GetLength(0))
//     return array;
//     else
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         int temp = array[row1,j];
//         array[row1,j] = array[row2,j];
//         array[row2,j] = temp;
//     }
//     return array;
// }

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер строки которую хотите поменять:");
// int r1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер второй строки которую хотите поменять:");
// int r2 = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(m,n,min,max);
// Show2DArray(myArray);
// Console.WriteLine();
// ChangeRows(myArray, r1, r2);
// Show2DArray(myArray);

// Задание 2. Напишите программу, которая меняет строки и столбцы местами


int[,] Create2DRandomArray(int rows, int colomns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colomns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int[,] RowsToColomns(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
        return array;
    else
    {
        for (int i = 0; i < array.GetLength(0) - 1; i++)
        {
            for (int j = i+1; j < array.GetLength(0); j++)
            {
                int temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
        }
    }
    return array;
}

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное возможное значение элемента массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива:");
int max = Convert.ToInt32(Console.ReadLine());


int[,] myArray = Create2DRandomArray(m, n, min, max);
Show2DArray(myArray);
Console.WriteLine();
myArray = RowsToColomns(myArray);
Show2DArray(myArray);