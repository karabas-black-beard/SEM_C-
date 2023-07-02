//вводная часть
// int FindSumm(int num1, int num2)
// {
//     int sum = num1 + num2;
//     return sum;
// }
// int x = 5;
// int y = 6;
// System.Console.WriteLine(FindSumm(x, y));


//задача 1 прога принимает2 числа и проверяет кратно ли 2 число первому
//34, 5 не кратно, остаток 4
//16, 4 кратно
// void CheckEven(int num1, int num2)
// {
//     if (num1 % num2 == 0)
//     {
//         System.Console.WriteLine($"Число {num2} кратно {num1}");
//     }
//     else
//     {
//         System.Console.WriteLine($"Число {num2} не кратно {num1}, остаток {num1 % num2}");
//     }
// }
// System.Console.Write("введите первое число:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("введите второе число:");
// int num2 = Convert.ToInt32(Console.ReadLine());
// CheckEven (num1, num2);


//задача 2 прога проверяет число на кратность 7 и 23
//14 нет. 46 нет. 161 да
// bool CheckEven (int num)
// {
//     if (num % 7 == 0 && num % 23 == 0) return true;
//     else return false;
// }
// System.Console.Write("введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(CheckEven(num));


//задача 3 прога из случайного трех значного числа удаляет второе
// int CheckNum( int index)
// {
//     System.Console.WriteLine(index);
//     int num1 = index % 10; //единицы
//     int num2 = index / 100; //сотни
//     int res = num2 * 10 + num1;
//     return res;
// }
// int index = new Random().Next(100, 1000);
// System.Console.WriteLine(CheckNum(index));

//задача 4 прога проверяет 2 числа, является ли одно квадратом другого
// System.Console.Write("введите первое число:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("введите второе число:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// void VentNum(int num1, int num2)
// {
//     if (num1 == num2 * num2)
//     {
//         System.Console.Write($"{num1} квадрат {num2}");
//     }
//     else if (num2 == num1 * num1)
//     {
//         System.Console.Write($"{num2} квадрат {num1}");
//     }
//     else System.Console.Write("ничего");
// }
// VentNum(num1, num2);
