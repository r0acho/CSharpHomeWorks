//Задача 43: Напишите программу, которая найдёт точку пересечения двух
//прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0,5; -0,5)

//метод для считывания целого числа с консоли
int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

// определяет, есть ли у прямых, заданных формулами ниже, точка пересечения:
// y = ax + c
// y = bx + d
// где "a" и "b" — угловые коэффициенты прямых, а "c" и "d" — пересечения прямых с осью y.
// Формат выходных данных: true - точка пересечения есть, false - точки пересечения нет (по причине параллельности прямых)
bool isLinesIntersect(double a, double b, double c, double d)
{
    return !(a == b); //если угловые коэффициенты равны, то возвращаем false (внутри скобок будет true, а !true = false), поскольку пересечения нет, иначе true
}

// вычисляет точку пересечения прямых, заданных формулами:
// y = ax + c
// y = bx + d
// где "a" и "b" — угловые коэффициенты прямых, а "c" и "d" — пересечения прямых с осью y.
// Формат выходных данных: (x, y) - координаты точки пересечения
// не контролирует то, пересекаются ли прямые!
(double, double) GetIntersectionPoint(double a, double b, double c, double d)
{
    double x = (d - c)/(a - b);
    double y = a * (d - c) / (a - b) + c; //формулы взяты с https://ru.wikipedia.org/wiki/%D0%9F%D0%B5%D1%80%D0%B5%D1%81%D0%B5%D1%87%D0%B5%D0%BD%D0%B8%D0%B5_%D0%BF%D1%80%D1%8F%D0%BC%D1%8B%D1%85
    return (x, y);
}

int b1 = ReadNumber("Введите свободный член b1");
int k1 = ReadNumber("Введите угловой коэффициент k1");
int b2 = ReadNumber("Введите свободный член b2");
int k2 = ReadNumber("Введите угловой коэффициент k2");

if (isLinesIntersect(k1, k2, b1, b2) == true)
{
    (double x, double y) = GetIntersectionPoint(k1, k2, b1, b2);
    Console.WriteLine($"Точка пересечения находится по координатам: ({x}, {y})");
}
else
{
    Console.WriteLine("Прямые не пересекаются");
}
