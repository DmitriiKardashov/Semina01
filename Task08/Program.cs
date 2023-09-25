// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 1)
 {
    int count = 2;
    while (count <= number)
    {
        Console.Write($"{count} ");
        count = count + 2;
    }
 }
 else 
 {
    Console.WriteLine("В заданом диапазоне положительных четных чисел нет.");
 }