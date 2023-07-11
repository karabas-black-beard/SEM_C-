//отзеркалить элементы массива 
//   int[] CrMass(int size, int minVal, int maxVal)
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
// int[] RevArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length/2; i++)
//     {
//         int temp = arr[i];
//         arr[i] = arr [arr.Length - i-1];
//         arr [arr.Length - i-1] = temp;
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
// myArr = RevArr(myArr);
// PrintArr(myArr);




//число перевести в двоичную систему счисления
// void DecToBin(int num)
// {
//     string str = string.Empty;
//     while (num>0)
//     {
//         str =  num % 2 + str ;
//         num = num / 2;
//     }
//     System.Console.WriteLine(str);
// }
// System.Console.WriteLine("Ввести число для перевода");
// int num = Convert.ToInt32(System.Console.ReadLine());
// DecToBin(num);

//task 1
// int[] Fibb(int size, int num1, int num2)
// {
//     int[] arr = new int[size];
//     arr[0]=num1;
//     arr[1]=num2;
//     for (int i = 2; i < arr.Length; i++)
//     {
//        arr[i] = arr[i-2]+arr[i-1];
             
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
// System.Console.WriteLine("Ввести размер массива");
// int size = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Ввести 1 число последовательности");
// int num1 = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Ввести 2 число последовательности");
// int num2 = Convert.ToInt32(System.Console.ReadLine());

// PrintArr (Fibb(size, num1, num2));


//task2 вход 3 числа. может ли быть треугольник с этими сторонами
bool ChkTriangle(int a, int b, int c)
{
    if (a < b+c && b<a+c && c<a+b) return true;
    else return false;
}
System.Console.WriteLine(ChkTriangle(4,5,10));

