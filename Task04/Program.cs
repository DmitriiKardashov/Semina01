// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.WriteLine("Введите число №1:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №2:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №3:");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number1 < number2)
     max = number2;
if (number2 < number3)
     max = number3;
Console.WriteLine($"Максимальное число = {max}.");