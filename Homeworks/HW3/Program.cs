//задание 23 вход N, выход  кубы чисел до N построчно
// void GetQuad(int cnt)
// {
//     int i = 1;
//     while (i <= cnt)
//     {
//         System.Console.WriteLine($"куб {i} = {Math.Pow(i, 3)}");
//         i++;
//     }
// }
// System.Console.WriteLine("ввести число: ");
// int cnt = Convert.ToInt32(Console.ReadLine());
// GetQuad(cnt);

//задание 21 прога принимает координаты 2 точек
// и ищет расстояние между ними
// double FindDist(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
// }
// System.Console.Write("ввести x1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("ввести y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("ввести z1: ");
// double z1 = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("ввести x2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("ввести y2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("ввести z2: ");
// double z2 = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine($"Расстояние между точками {FindDist(x1, y1, z1, x2, y2, z2)}");


//задание 19 пятизначное число проверяет на полиндромность
void GetPol(int i)
{
    if (i < 100000)
    {
        int m1 = i / 10000;
        int m2 = (i - m1 * 10000) / 1000;
        int m = m2 * 10 + m1;
        int k = i % 100;
        if (k == m) System.Console.WriteLine("число полиндромное");
        else System.Console.WriteLine("число не полиндромное");
    }
    else System.Console.WriteLine("смотри что вводишь!");
}

System.Console.WriteLine("ввести пятизначное число: ");
int i = Convert.ToInt32(Console.ReadLine());
GetPol(i);