//задать массив произвольными числами из [-9, 9]
//найти сумму отрицательных и положительных элементов
// int[] CrMass(int size, int minVal, int maxVal)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(minVal, maxVal + 1);
//     }
//     return arr;
// }
// void PrintArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write(arr[i] + " ");
//     }
//     System.Console.WriteLine();
// }
// void PosNegSum(int[] arr)  //часть для первой задачи
// {
//     int sumPos = 0;
//     int sumNeg = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0) sumPos = sumPos + arr[i];
//         else sumNeg = sumNeg + arr[i];
//     }
//     System.Console.WriteLine($"sum pos el {sumPos}");
//     System.Console.WriteLine($"sum neg el {sumNeg}");
// }

// System.Console.WriteLine("input size arr: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input min: ");
// int minVal = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input max: ");
// int maxVal = Convert.ToInt32(Console.ReadLine());

// int[] myArr = CrMass(size, minVal, maxVal);

// PrintArr(myArr);  
// PosNegSum(myArr);  





//прога замена элементов массива.
// положительные на отрицательные и наоборот
// int[] CrMass(int size, int minVal, int maxVal)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(minVal, maxVal + 1);
//     }
//     return arr;
// }
// void PrintArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write(arr[i] + " ");
//     }
//     System.Console.WriteLine();
// }
// int[] InvArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] *= -1;
//     }
//     return arr;
// }

// System.Console.WriteLine("input size arr: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input min: ");
// int minVal = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input max: ");
// int maxVal = Convert.ToInt32(Console.ReadLine());

// int[] myArr = CrMass(size, minVal, maxVal);
// PrintArr(myArr);
// myArr = InvArr(myArr);
// PrintArr(myArr);



// проверить массив на наличие запрашиваемого числа,
// массив  вводить вручную
// int[] CrArr(int size)
// {
//     System.Console.WriteLine("введите числа массива");
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return arr;
// }
// bool FindNum(int[] arr, int num)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == num) return true;
//             }
//             return false;
// }
// System.Console.WriteLine("введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] arr = CrArr(size);
// System.Console.WriteLine("введите число для поиска");
// int num = Convert.ToInt32(Console.ReadLine());
// if (FindNum(arr, num)) System.Console.WriteLine($"{num} есть в массиве");
// else System.Console.WriteLine($"{num} нет в массиве");


// массив из 123 случайных, найти кол-во элементов 
//из заданного диапазона
int[] CrArr()
{
    System.Console.WriteLine("массив:");
    int[] arr = new int[123];
    Random rnd = new Random();
    for (int i = 0; i < 123; i++)
    {
        arr[i] = rnd.Next(-100, 100);
    }
    return arr;
}
int FindColvo(int[] arr, int minValue, int maxValue)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > minValue && arr[i] < maxValue)
        {
            count++;
        }
    }
    return count;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}, ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine("введите мин значение");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите макс значение");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] arr = CrArr();
PrintArray(arr);
System.Console.WriteLine($"кол-во элементов  в диапазоне {FindColvo(arr, minValue, maxValue)}");