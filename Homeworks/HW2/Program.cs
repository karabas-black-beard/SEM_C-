//задача 1 прога из 3 значного выводит вторую цифру

// int GetNum(int num)
// {
//     if (num > 99 && num < 1000)
//     {
//         int res = num / 10 % 10;
//         return res;

//     }
//     else
//     {
//         System.Console.WriteLine("ввели не трехзначное число");
//         return 0;
//     }
// }
// System.Console.Write("введите трехзначное число:");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(GetNum(num));



//задача 2 прога ввывоит третью цифру с конца, сообщать если её нет
// int PrintThird(int num)
// {
//     while (num > 999)
//     {
//         num = num / 10;
//     }
//     return num % 10;
// }
// System.Console.Write("введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 100)
// {
//     System.Console.WriteLine("третьего числа нет");
// }
// System.Console.WriteLine(PrintThird(num));  


//задача 3 прога  которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
bool ValidateDay(int day)
{
    if (day > 7)
    {
        System.Console.WriteLine("такого дня недели нет");
        return false;
    }
    return true;
}
void GetDay(int day)
{
    if (day == 6 || day == 7) System.Console.WriteLine("выходной день");
    else System.Console.WriteLine("рабочий день");
}
System.Console.WriteLine("введите номер дня недели:");
int day = Convert.ToInt32(Console.ReadLine());
if (ValidateDay(day)) GetDay(day);

