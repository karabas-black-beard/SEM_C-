//задача 1 число А на вход, выход сумма от 1 до А
// int FindSum (int a)
// {
//     int sum = 0;
//     for (int i=1; i<=a; i++)
//     {
// sum += i;
//     }
//     return sum;
// }
// System.Console.WriteLine("inputnumber: ");
// int a= Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(FindSum(a));


//задача2 выводит массив из 4 элементов, заполненный 0 и 1 случайно
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

//задача 3 число и выдает кол-во цифр в числе
// int FindNum(int a)
// {
//     int count = 0;
//     for (int i = 1; a > 0; i++)
//     {
//         a = a / 10;
//         count = i;
//     }
//     return count;
// }
// System.Console.WriteLine("input num: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(FindNum(a));


задача 4 число n и выдает n!
int FindF(int a)
{
    int f = 1;
    for (int i = 1; i <= a ; i++)
    {
    f = f * i;
    }
return f;
}
System.Console.Write("input num: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(FindF(a));

