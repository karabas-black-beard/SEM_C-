//задать N. прогшрамма вывоит все натур. число от 1 до N
//рекурсивный метод
// void PrintNum(int n)
// {
//     if (n >= 1)
//     {
//         PrintNum(n - 1);
//         Console.Write(n+ " ");
//     }
// }
// PrintNum(6);

//число на входе. на выходе сумма его цифр
// int FindSum(int n)
// {
//     if (n > 0)
//     {
//         return FindSum(n/10)+ n%10;
//     }
//     else return n;
// }
// Console.WriteLine(FindSum(234));

//вывод в указанном диапазоне
// void FindNum(int n, int m)
// {
//     if (n != m)
//     {
//         if (n > m)
//         {
//             FindNum(n-1, m);
//             Console.Write(n + " ");
//         }
//         else
//         {
//             FindNum(n, m-1);
//             Console.Write(m + " ");
//         }
//     }
//     else Console.Write(m + " ");
// }
// FindNum(2, 4);


//A возводит в степень B рекурсией
int FindNum(int a, int b)
{
    if (b>0)
    {
        return FindNum(a, b-1)*a;
    }
    else return 1;
}
Console.WriteLine(FindNum(2,8));