﻿// ********************************Задание 1:******************************************
// Напишите программу, которая на вход принимает два числа 
//и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

//говорим введи числа - запрашиваем у пользователя

// Console.WriteLine("Input first number");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int b = Convert.ToInt32(Console.ReadLine());

// if(a > b)
// {
//     Console.WriteLine($"{a} is bigger then {b}");
// }
// if(a == b)
// {
//     Console.WriteLine($"{a} = {b}");
// }
// //если условие не выполняется пишем "иначе выполняй":
// else
// {
//     Console.WriteLine($"{b} is bigger then {a}");
// }






// ********************************Задание 2:******************************************
// Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


// Console.WriteLine("Input first number");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input second number");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input third number");
// int c = Convert.ToInt32(Console.ReadLine());

// int max = a;

// if ( b > max) max = b;
// if ( c > max) max = c;

// Console.WriteLine($"The biggest integer is {max}");
// // 
// изначально взять какое то число за максимальное а потом уже сравнивать

// // ********************************Задание 3:******************************************
// Напишите программу, которая на вход принимает число 
//и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// делится на 2 и остаток от деления равен 0

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// if ((a % 2) == 0)
// {
//    Console.WriteLine($"Это число четное");
// }
// else
// {
//    Console.WriteLine($"Это число нечетное");
// }


// // ********************************Задание 4:******************************************
// Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// int res = 1;      
// if (res == 1)
// {
//    res = res + 1;
// }
//    while (res <= N)
// {
//    Console.WriteLine(res);
//    res = res + 2;
// }
    
// схитрить - выводить четные, не проверяя на четность