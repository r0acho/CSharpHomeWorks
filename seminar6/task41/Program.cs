// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//метод для считывания целого числа с консоли
int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

//метод для заполнения массива с консоли на length элементов
int[] ReadArray(int length)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadNumber($"Введите {i}-ый элемент массива");
    }

    return array;
}

int CountPositiveElements(int[] array)
{
    int count = 0; //количество положительных элементов

    for(int i = 0; i < array.Length; i++) 
    {
        if (array[i] > 0)
        {
            count++;
        }
    }

    return count;
}

int m = ReadNumber("Введите число m"); //длина нашего массива
int[] myArray = ReadArray(m); //получаем массив на count элементов
int result = CountPositiveElements(myArray); //получаем количество положительных переменных
Console.WriteLine($"Было введено {result} положительных элемента(-ов)");





