﻿Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number*number;
Console.Write("Квадрат введенного числа: ");
Console.WriteLine(square);
Console.WriteLine($"{number} -> {square}");