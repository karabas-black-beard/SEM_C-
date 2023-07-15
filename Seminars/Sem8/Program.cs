// двумерный массив. алгоритм меняет любые 2 строки местами
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
// System.Console.WriteLine("Ввести кол-во столбцов:");
// int cols = Convert.ToInt32(System.Console.ReadLine());


// int [,] myArr= CrArr(rows, cols);
// PrArr(myArr);

// System.Console.WriteLine("Ввести строку1: ");
// int row1 = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Ввести строку2: ");
// int row2 = Convert.ToInt32(System.Console.ReadLine());

// int [,] ChngRows(int [,] arr, int row1, int row2)
// {
//     if (row1>=arr.GetLength(0) || row2>=arr.GetLength(0))
//     {
//         System.Console.WriteLine("указанные строки за пределами массива");
//         return arr;
//     }
//     else 
//     for(int j=0; j<arr.GetLength(1); j++)
//     {
//         int temp = arr[row1,j];
//         arr[row1,j]= arr[row2,j];
//         arr[row2,j]=temp;
//     }
//     return arr;
// }
// PrArr(ChngRows(myArr, row1, row2));




//строки и колонки меняем местами
// int[,] RowsToCol(int[,] arr)
// {
//     if (arr.GetLength(0) != arr.GetLength(1))
//     {
//         System.Console.WriteLine("не квадратный массив");
//         return arr;
//     }
//     else 
//     {
//         for(int i = 0; i <arr.GetLength(0)-1; i++)
//         {
//             for(int j = i+1; j < arr.GetLength(1); j++)
//             {
//                 int temp= arr[i, j];
//                 arr[i, j] = arr[j, i];
//                 arr[j, i]=temp;
//             }
//         }
//     }
//     return arr;
// }
// int[,] CrArr(int rows, int cols)
// {
// int [,] arr = new int[rows, cols];
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < cols; j++)
//     {
//         arr[i, j] = new Random().Next(0, 10);
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
// System.Console.WriteLine("Ввести кол-во столбцов:");
// int cols = Convert.ToInt32(System.Console.ReadLine());


// int [,] myArr= CrArr(rows, cols);
// PrArr(myArr);

// PrArr(RowsToCol(myArr));




//найти миимальный элемент массива и занулить строку-столбец расположения
 int[,] ElToZero(int[,] arr)
{   int min= arr[0,0];
    int row=0;
    int col=0;
    for(int i = 0; i <arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i,j]<min)
                {
                    min=arr[i,j];
                    row=i;
                    col=j;
                }
            }
        }
    for(int i =0; i <arr.GetLength(0); i++)
    {
    arr[i, col]=0;
    }
     for(int j =0; j <arr.GetLength(1); j++)
    {
    arr[row,j]=0;
    }
        return arr;
}
int[,] CrArr(int rows, int cols)
{
int [,] arr = new int[rows, cols];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        arr[i, j] = new Random().Next(0, 10);
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
System.Console.WriteLine("Ввести кол-во столбцов:");
int cols = Convert.ToInt32(System.Console.ReadLine());


int [,] myArr= CrArr(rows, cols);
PrArr(myArr);

PrArr(ElToZero(myArr));
