//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
int[] Mass(int size)
{ 
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());;
    }
    System.Console.WriteLine();
    return arr;
}
void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
}
int GetNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0) count++;
    }
    return count;
    
}

System.Console.Write("input size arr: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] MyArr = Mass(size);
PrintArr(MyArr);
System.Console.WriteLine($"кол-во положительных чисел в массиве: {GetNum(MyArr)}");



//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.