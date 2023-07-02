// задача 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
// System.Console.Write("Сравнение 2х чисел. Введите первое число:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("введите второе число:");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2)
// {
//     System.Console.WriteLine($"MAX: {num1}");
// }
// else
// {
//     System.Console.WriteLine($"MAX: {num2}");
// }


//задача 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// System.Console.WriteLine("Сравнение 3х чисел");
// int[] arr = new int [3];
// int max = 0, i = 0;
// for (i = 0; i < 3; i++)
// {
//    System.Console.Write($"введите число:");
//    arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// max=arr[0];
// for (i = 0; i < 2; i++)
// {
//    if (arr[i] > arr[i+1])
//    {}
//    else 
//    {
//     max = arr[i+1];
//    }
// }
// System.Console.WriteLine($"MAX: {max}");


//задача 6 программа, которая на вход принимает число и выдаёт, является ли число чётным
// System.Console.Write("Проврка на четность. Введите число:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// if (num1 % 2 == 0)
// {
//     System.Console.Write("число четное");
// }
// else
// {
//     System.Console.Write("число нечетное");
// }


//задача 8 программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
System.Console.Write("введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
int current = 1;

while (current <= n)
{
    if (current % 2 == 0)
    {
        System.Console.Write(current + " ");
    }
    else
    { }
    current++;
}
