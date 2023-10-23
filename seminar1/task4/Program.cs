//Задача 4: Напишите программу, которая 
//на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 => 2, 4
//8 => 2, 4, 6, 8


Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 2)
{
    Console.WriteLine("Нет четных чисел в указанном промежутке");
}
else
{
    int current = 2;
    int step = 2;

    while(current < N - step)
    {
        Console.Write($"{current}, ");
        current += step;
    }

    Console.WriteLine(current);
}