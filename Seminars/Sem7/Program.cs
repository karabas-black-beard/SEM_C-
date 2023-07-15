//заполнить массив mxn произвольными целыми числами
// int[,] CrArr(int rows, int cols, int minVal, int maxVal)
// {
// int [,] arr = new int[rows, cols];
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < cols; j++)
//     {
//         arr[i, j] = new Random().Next(minVal, maxVal+1);
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
// System.Console.WriteLine("Ввести кол-во столбцов");
// int cols = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("min: ");
// int minVal= Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("max:");
// int maxVal = Convert.ToInt32(System.Console.ReadLine());

// int [,] myArr= CrArr(rows, cols, minVal, maxVal);
// PrArr(myArr);

// //создать 2 маерный массив, найти сумму элементов на главной диагонали
// int SumMainDiag(int[,] arr)
// {
//     int sum=0;
//    for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//         if (i==j) sum += arr[i, j];
//         }
//            }
//    return sum;
// }

// System.Console.WriteLine("суммa элементов на главной диагонали  "+ SumMainDiag(myArr));



//массив х2. найти элемент у которого оба индеуса четные, заменить эти элементы на их квадраты
// int[,] CrArr(int rows, int cols, int minVal, int maxVal)
// {
// int [,] arr = new int[rows, cols];
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < cols; j++)
//     {
//         arr[i, j] = new Random().Next(minVal, maxVal+1);
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
// System.Console.WriteLine("Ввести кол-во столбцов");
// int cols = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("min: ");
// int minVal= Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("max:");
// int maxVal = Convert.ToInt32(System.Console.ReadLine());

// int [,] myArr= CrArr(rows, cols, minVal, maxVal);
// PrArr(myArr);

// int[,] EvenSum(int[,] arr)
// {
//      for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//         if (i %2 ==0 && j %2 ==0) arr[i,j]=Convert.ToInt32(Math.Pow(arr[i, j], 2));
//         }
//            }
//    return arr;
// }

// PrArr(EvenSum(myArr));




//m x n массив, каждый элемент: Amn=m+n
int[,] CrArr(int rows, int cols)
{
int [,] arr = new int[rows, cols];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        arr[i, j] = i+j;
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
System.Console.WriteLine("Ввести кол-во столбцов");
int cols = Convert.ToInt32(System.Console.ReadLine());

int [,] myArr= CrArr(rows, cols);
PrArr(myArr);

