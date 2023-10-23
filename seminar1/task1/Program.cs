// Задача 1: Напишите программу, которая 
// на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a=5; b=7   => max=7,  min=5
// a=2; b=10  => max=10, min=2
// a=-9; b=-3 => max=-3, min=-9

Console.WriteLine("Введите числа a и b через Enter");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"max={a},\tmin={b}");
}
else if (b > a)
{
    Console.WriteLine($"max={b},\tmin={a}");
}
else
{
    Console.WriteLine("a = b");
}