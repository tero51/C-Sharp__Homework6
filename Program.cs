// Задача 41 (много тупил тут)
// int[] FillArray(int size)
// {
//     int[] array = new int[size]; // инициализация массива
//     for (int i = 0; i < size; i++)
//     {
//         System.Console.Write($"Enter your number array {size - i}: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.Write("-> ");
// }

// int CountPositiveNumber(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int[] array;
// System.Console.Write("Enter your size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// array = FillArray(size);
// PrintArray(array);
// System.Console.Write(CountPositiveNumber(array));
// ============================================================
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)//  5 * (-0.5) + 2 - 9 * (-0.5) - 4 = 0 // -0.5 = 

// задача 43 (не смог разобраться как это вывести в метод) поэтому решение корявое.
System.Console.Write("Enter your k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter your k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter your b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter your b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2 && b1 == b2)
{
    System.Console.WriteLine("Прямые совпадают");
}
else if (k1 == k2)
{
    System.Console.WriteLine("Прямые параллельны");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    System.Console.WriteLine($"x = {x}, y = {y}");
}
