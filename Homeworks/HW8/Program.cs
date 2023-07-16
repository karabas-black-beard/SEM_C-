//Задача 54: Задайте двумерный массив. Напишите программу,
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
// int[,] CrArr(int rows, int cols)
// {
//     int[,] arr = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             arr[i, j] = new Random().Next(0, 101);
//         }
//     }
//     return arr;
// }

// void PrArr(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             System.Console.Write(arr[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int[,] SortArr(int[,] arr)
// {
//     int indexMax = 0;
//     int index = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         index = 0;
//         while (index < arr.GetLength(1))
//         {
//             int max = arr[i,index]; //при новом цикле поиска макс из оставшихся объявляем макс след. элемент. Сброс индекса.
//             indexMax = index;
//             for (int j = 0 + index; j < arr.GetLength(1); j++) //находим макс элемент строки
//             {
//                 if (arr[i, j] > max)
//                 {
//                     max = arr[i, j];
//                     indexMax = j;
//                 }
//             }
//             arr[i, indexMax]=arr[i, index]; //меняем числа местами
//             arr[i, index] = max;
//             index++;
//         }
//     }
//     return arr;
// }

// System.Console.WriteLine("Ввести кол-во строк: ");
// int rows = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Ввести кол-во столбцов: ");
// int cols = Convert.ToInt32(System.Console.ReadLine());

// int[,] myArr = CrArr(rows, cols);
// PrArr(myArr);
// PrArr(SortArr(myArr));


//Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// int[,] CrArr(int rows, int cols)
// {
//     int[,] arr = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             arr[i, j] = new Random().Next(0, 11);
//         }
//     }
//     return arr;
// }

// void PrArr(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             System.Console.Write(arr[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void MinRow(int[,] arr)
// {
//     int tempSum = 0;
//     int numRow = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < arr.GetLength(1); j++) //находим сумму строки
//         {
//             sum = sum + arr[i, j];
//         }
//         System.Console.WriteLine($"сумма строки {i}: {sum}");
//         if (i < 1)
//         {
//             tempSum = sum;
//             numRow = i;
//         }
//         else if (tempSum > sum)
//         {
//             tempSum = sum;
//             numRow = i;
//         }
//     }
//     System.Console.WriteLine($"минимальная строка: {numRow}");
// }

// System.Console.WriteLine("Ввести кол-во строк: ");
// int rows = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Ввести кол-во столбцов: ");
// int cols = Convert.ToInt32(System.Console.ReadLine());

// int[,] myArr = CrArr(rows, cols);
// PrArr(myArr);
// MinRow(myArr);



//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int[,] CrArrA(int rows, int cols)
{
    int[,] arr = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            arr[i, j] = new Random().Next(0, 11);
        }
    }
    return arr;
}
int[,] CrArrB(int rowsB, int colsB)
{
    int[,] arr = new int[rowsB, colsB];
    for (int i = 0; i < rowsB; i++)
    {
        for (int j = 0; j < colsB; j++)
        {
            arr[i, j] = new Random().Next(0, 11);
        }
    }
    return arr;
}

void PrArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] MultiplyArr(int[,] myArrA, int[,] myArrB)
{
    int[,] arrRes = new int[myArrA.GetLength(0), myArrB.GetLength(1)];
    for (int i = 0; i < myArrA.GetLength(0); i++)
    {
        for (int j = 0; j < myArrB.GetLength(1); j++)
        {
            for (int k = 0; k < myArrB.GetLength(0); k++)
            {
                arrRes[i, j] += myArrA[i, k] * myArrB[k, j];
            }
        }
    }
    return arrRes;
}

System.Console.WriteLine("Ввести кол-во строк матрицы А: ");
int rows = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Ввести кол-во столбцов матрицы А: ");
int cols = Convert.ToInt32(System.Console.ReadLine());
int rowsB = cols;
int colsB = rows;

int[,] myArrA = CrArrA(rows, cols);
int[,] myArrB = CrArrB(rowsB, colsB);
PrArr(myArrA);
PrArr(myArrB);
PrArr(MultiplyArr(myArrA, myArrB));

