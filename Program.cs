// // Задача 64: Задайте значение N. Напишите программу, 
// // которая выведет все натуральные числа в промежутке от N до 1. 
// // Выполнить с помощью рекурсии.

// // N = 5 -> "5, 4, 3, 2, 1"
// // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// string RankToOne(int n)
// {
//     if (n == 1) return 1.ToString();
//     else return n.ToString() + ", " + RankToOne(n - 1);
// }

// void Main()
// {
//     System.Console.Write("Программа выведет все натуральные числа в промежутке от указанного числа до 1.\nВведите число: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine(RankToOne(number));
// }

// Main();


// // Задача 66: Задайте значения M и N. 
// // Напишите программу, которая найдёт сумму натуральных элементов
// //  в промежутке от M до N.

// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

// void Main()
// {
//     System.Console.Write("Программа найдёт сумму натуральных элементов от A до B.\nВведите число A: ");
//     int numberA = Convert.ToInt32(Console.ReadLine());
//     System.Console.Write("Введите число B: ");
//     int numberB = Convert.ToInt32(Console.ReadLine());

//     if (numberA > numberB)
//     {
//         int temp = numberB;
//         numberB = numberA;
//         numberA = temp;
//     }
//     System.Console.WriteLine($"Сумма всех чисел от {numberA} до {numberB} равна {SummInterval(numberA, numberB)}");
// }

// int SummInterval(int a, int b)
// {
//     if (a == b) return b;
//     else
//     {
//         return a + SummInterval(a + 1, b);
//     }
// }

// Main();


// // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// // Даны два неотрицательных числа m и n.
// // m = 2, n = 3 -> A(m,n) = 9
// // m = 3, n = 2 -> A(m,n) = 29

// void Main()
// {
//     System.Console.Write("Программа вычислит функцию Аккрмана с заданными M и N .\nВведите число M: ");
//     uint numberM = Convert.ToUInt32(Console.ReadLine());
//     System.Console.Write("Введите число N: ");
//     uint numberN = Convert.ToUInt32(Console.ReadLine());

//     System.Console.WriteLine($"Akerman({numberM} , {numberN}) = {Akkerman(numberM, numberN)}");
// }

// uint Akkerman(uint m, uint n)
// {
//     if (m == 0)
//         return n + 1;
//     if (n == 0)
//         return Akkerman(m - 1, 1);
//     else
//         return Akkerman(m - 1, Akkerman(m, n - 1));
// }

// Main();