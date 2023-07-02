//задание1 программа принимает координаты x y (не 0)
//выдает номер четверти 
// int FindQuad(int x, int y)
// {
//     if (x > 0 && y > 0)
//     {
//         return 1;
//     }
//     if (x < 0 && y > 0)
//     {
//         return 2;
//     }
//     if (x < 0 && y < 0)
//     {
//         return 3;
//     }
//     if (x > 0 && y < 0)
//     {
//         return 4;
//     }
//     return 0;

// }
// System.Console.WriteLine("ввести x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("ввести y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"координаты ({x}:{y}) лежат в {FindQuad(x,y)} четверти");

//задание 2 прога принимает координаты 2 точек
// и ищет расстояние между ними
// double FindDist(double x1, double y1, double x2, double y2)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 2);
// }
// System.Console.WriteLine("ввести x1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("ввести y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("ввести x2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("ввести y2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine($"Расстояние между точками {FindDist(x1, y1, x2, y2)}");


//задание 3  прог по заданному номру четверти выставляет возможный диапазон
// void GetRange(int quad)
// {
//     if (quad < 5)
//     {
//         if (quad == 1) System.Console.WriteLine("диапазон1");
//         if (quad == 2) System.Console.WriteLine("диапазон2");
//         if (quad == 3) System.Console.WriteLine("диапазон3");
//         if (quad == 4) System.Console.WriteLine("диапазон4");
//     }
//     else System.Console.WriteLine("нет такой четверти");

// }
// System.Console.WriteLine("ввести четверть: ");
// int quad = Convert.ToInt32(Console.ReadLine());
// GetRange(quad);

//задание 4 вход N, выход  квардаты чисел до N построчно
void GetQuad(int cnt)
{
    int i = 1;
    while (i <= cnt)
    {
        System.Console.WriteLine($"квадрат {i} = {Math.Pow(i, 2)}");
        i++;
    }

}

System.Console.WriteLine("ввести число: ");
int cnt = Convert.ToInt32(Console.ReadLine());
GetQuad(cnt);

