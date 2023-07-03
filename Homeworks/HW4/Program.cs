//задача29 выводит массив из 4 элементов, заполненный 0 и 1 случайно
// int[] CrMass(int size, int minVal, int maxVal)
// {
//     int[] arr = new int[size];
//     for (int i=0; i<size; i++)
//     {
//         arr[i] = new Random().Next(minVal, maxVal+1);
//     }
//     return arr;
// }

// void PrintArr(int[] arr)
// {
//     for (int i=0; i < arr.Length; i++)
//     {
//         System.Console.Write(arr[i] + " " );
//     }
//     System.Console.WriteLine();
// }
// System.Console.WriteLine("input size arr: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input min: ");
// int minVal = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input max: ");
// int maxVal = Convert.ToInt32(Console.ReadLine());
// PrintArr(CrMass(size, minVal, maxVal));



//задача 25 Цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.
// int FindDegree(int a, int b)
// {
//     int c = 1;
//     for (int i = 0; i < b; i++)
//     {
//         c = c * a;
//     }

//     return c;
// }
// System.Console.Write("ввести основание: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("ввести степень: ");
// int b = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(FindDegree(a, b));

//Задача 27: Напишите программу,
// которая принимает на вход число и выдаёт сумму цифр в числе.
int SumNum(int a)
{
    int res = 0;
    while (a > 0)
    {
        res += a % 10;
        a = a / 10;
    }
    return res;
}
System.Console.Write("ввести число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"сумма цифр в числе= {SumNum(a)}");
