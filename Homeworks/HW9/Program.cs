//Задача 64: Задайте значение N.
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
// void PrintNum(int n)
// {
//     if (n > 0)
//     {
//         Console.Write(n + " ");
//         PrintNum(n - 1);
//     }
// }
// Console.WriteLine("введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// PrintNum(n);


//Задача 66: Задайте значения M и N.
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
// int FindNum(int n, int m)
// {
//     int i = 0;
//     if (n != m)
//     {
//         if (n > m)
//         {
//             return FindNum(n - 1, m) + n;
//         }
//         else
//         {
//             return FindNum(n, m - 1) + m;
//         }
//     }
//     else
//         return i = +m;
// }
// Console.WriteLine(FindNum(15, 1));


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
int Ack(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Ack(n - 1, 1);
    else
      return Ack(n - 1, Ack(n, m - 1));
}
int res;
Console.WriteLine(res = Ack(3, 2));
