// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// double[,] CrArr(int rows, int cols, int minVal, int maxVal)
// {
// double [,] arr = new double[rows, cols];
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < cols; j++)
//     {
//         double val = new Random().NextDouble();
//         arr[i, j] = new Random().Next(minVal, maxVal+1)+ Math.Round(val, 2);
//     }
// }
// return arr;
// }

// void PrArr(double[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//         System.Console.Write(arr[i, j] + " "); 
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }
// System.Console.WriteLine("Ввести кол-во строк: ");
// int rows = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Ввести кол-во столбцов");
// int cols = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("min: ");
// int minVal= Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("max:");
// int maxVal = Convert.ToInt32(System.Console.ReadLine());

// double [,] myArr= CrArr(rows, cols, minVal, maxVal);
// PrArr(myArr);





//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// int[,] CrArr(int rows, int cols)
// {
// int [,] arr = new int[rows, cols];
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < cols; j++)
//     {
//         arr[i, j] = new Random().Next(0, 101);
//     }
// }
// return arr;
// }

// void PrArr(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//         System.Console.Write(arr[i, j] + " "); 
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }
// System.Console.WriteLine("Ввести кол-во строк: ");
// int rows = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Ввести кол-во столбцов: ");
// int cols = Convert.ToInt32(System.Console.ReadLine());

// int [,] myArr= CrArr(rows, cols);
// PrArr(myArr);

// System.Console.WriteLine("Поиск элемента по координатам");
// System.Console.WriteLine("Ввести номер строки: ");
// int i = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Ввести номер столбца: ");
// int j = Convert.ToInt32(System.Console.ReadLine());

// if (i>rows || j>cols) System.Console.WriteLine("элемент не существует");
// else System.Console.WriteLine(myArr[i, j]);



//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
int[,] CrArr(int rows, int cols)
{
int [,] arr = new int[rows, cols];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        arr[i, j] = new Random().Next(0, 101);
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
System.Console.WriteLine("Ввести кол-во строк: ");
int rows = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Ввести кол-во столбцов: ");
int cols = Convert.ToInt32(System.Console.ReadLine());

int [,] myArr= CrArr(rows, cols);
PrArr(myArr);

void PrSum(int[,] myArr)
{
   int sum=0;
    for (int j=0; j<cols; j++)
    {
         for (int i=0; i<rows; i++)
         {
            sum=sum + myArr [i, j];
         }
         System.Console.WriteLine($"сумма столбца {j}: {sum} ");
         sum=0;
    }
   
}
PrSum(myArr);