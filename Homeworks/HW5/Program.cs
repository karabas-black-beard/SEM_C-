//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// int[] CrMass(int size)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(100, 1000);
//     }
//     return arr;
// }
// void PrintArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write(arr[i] + " ");
//     }
//     System.Console.WriteLine();
// }
// void ChetNum(int[] arr) 
// {
//     int chetNum = 0;
//         for (int i = 0; i < arr.Length; i++)
//     {
//        if (arr[i] % 2 == 0) chetNum++;
        
//     }
//     System.Console.WriteLine($"кол-во четных элементов {chetNum}");
//     }

// System.Console.WriteLine("input size arr: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArr = CrMass(size);

// PrintArr(myArr);  
// ChetNum(myArr);  


//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// int[] CrMass(int size, int minVal, int maxVal)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(minVal, maxVal + 1);
//     }
//     return arr;
// }
// void PrintArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write(arr[i] + " ");
//     }
//     System.Console.WriteLine();
// }
// void PosNechSum(int[] arr)  
// {
//     int PosNechSum = 0;
//       for (int i = 0; i < arr.Length; i++)
//     {
//         if (i % 2 == 0) PosNechSum = PosNechSum + arr[i];
        
//     }
//     System.Console.WriteLine($"sum pos nech {PosNechSum}");
//     }

// System.Console.WriteLine("input size arr: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input min: ");
// int minVal = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input max: ");
// int maxVal = Convert.ToInt32(Console.ReadLine());

// int[] myArr = CrMass(size, minVal, maxVal);

// PrintArr(myArr);  
// PosNechSum(myArr);  




//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
double[] CrMass(int size, int minVal, int maxVal)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        double val = new Random().NextDouble();
        arr[i] = new Random().Next(minVal, maxVal + 1) + Math.Round(val, 2);
    }
    return arr;
}
void PrintArr(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
}
void MaxMinNum(double[] arr)  
{
    double minNum = arr[0];
    double maxNum = arr[0];
      for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>maxNum) maxNum = arr[i];
        if (arr[i]<minNum) minNum = arr[i];
          }

    System.Console.WriteLine($"минимальное число: {minNum}");
    System.Console.WriteLine($"максимальное число: {maxNum}");
    System.Console.WriteLine($"макс - мин: {Math.Round(maxNum - minNum, 2)}");
    }

System.Console.WriteLine("input size arr: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input min: ");
int minVal = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input max: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

double[] myArr = CrMass(size, minVal, maxVal);

PrintArr(myArr); 
MaxMinNum(myArr); 