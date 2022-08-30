// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine ("Введите число A:  ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите число B:  ");
// int B = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// int result = A;
// if (B == 0) result = 1;
// else
// while (i < B)
// {
//     result = result*A;
//     i++;
// }
// Console.WriteLine ($"Число {A} в степени {B} = {result}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// вариант 1
//Console.WriteLine ("Введите число:  ");
// int number = Convert.ToInt32(Console.ReadLine());
// int SumNumber=0;
// {
//     while (number > 0)
//     {
//         SumNumber = SumNumber + number% 10;
//         number = number/10;
//     }
// }
// Console.WriteLine ($"сумма цифр в числе  = {SumNumber}");

//вариант 2

// Console.WriteLine ("Введите число:  ");
// int number = Convert.ToInt32(Console.ReadLine());
// int SumNumber=0;
// int Calculate (int num)
// {
//     int result = 0;
//     result = num% 10;
//     number = number/10;
// return result;
// }
// while (number > 0)
// {
//     SumNumber=SumNumber + Calculate (number);
// }
// Console.WriteLine ($"сумма цифр в числе  = {SumNumber}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] array = new int [8];
int i;
    Console.WriteLine($"Введите 8 элементов массива");
for (i=0; i<8;)
{   
    int k = Int32.Parse(Console.ReadLine());
    array[i] = k;
    i++;
}
    Console.WriteLine($"Массив из 8 заданных элементов: [{String.Join(",",array)}]");

