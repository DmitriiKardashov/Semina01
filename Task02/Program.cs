// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введине первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введине второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
        Console.WriteLine($"max = {number1}, min = {number2}");
else if (number1 < number2)
        Console.WriteLine($"max = {number2}, min = {number1}");
else
        Console.WriteLine("Числа равны.");