//расчет квадрата числа  
// System.Console.WriteLine("расчет квадрата числа");
// System.Console.Write("введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"кадрат числа {num}: {num*num}"); 


// явл ли число квадратом другого числа
// System.Console.Write("введите первое число:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("введите второе число:");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int quadrat = num2 * num2;
// if (num1 == quadrat)
// {
//     System.Console.WriteLine($"первое число {num1} является квадрато второго числа {num2}");
// }
// else
// {
//     System.Console.WriteLine($"первое число {num1} не является квадратом второго числа {num2}");
// }

//прога принимает число N и выводит последоватеьность чисел от -N до N.
// System.Console.Write("введите число N:");
// int n = Convert.ToInt32(Console.ReadLine());
// int current = n * (-1);

// while (current <= n)
// {
//     System.Console.Write(current + " ");
//     current++;
// }


// даетя 3х значное число, вывести его последнюю цифру0
System.Console.Write("ввести трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    System.Console.WriteLine(num % 10);
}
else
{
    System.Console.WriteLine("не верное число");
}
