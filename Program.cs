// Домашняя работа № 4

// Задача 1 - Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Product(int numA, int numB)
{
    int prod = 1;
    while (numB > 0)
    {
        prod = prod * numA;
        numB--;
    }
    return prod;
}
Console.Write("Input a number A: ");
int nA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number B: ");
int nB = Convert.ToInt32(Console.ReadLine());

int result = Product(nA, nB);
Console.WriteLine($"Натуральная тепень А равна: {result}");
*/

// Задача 2 -  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumOfNumber(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum = sum + number % 10;
        number/=10;
    }
    return sum;
}
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = SumOfNumber(num);
Console.WriteLine($"Сумма цифр в числе {num} равна {result}");
*/

// Задача 3 - Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int[] CreateArray(int size = 8)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write("Input a number: ");
        array [i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(i == 0) Console.Write("[" + array[i] + ", ");
        else
        if(i == array.Length - 1) Console.Write(array [i] + "]");
        else
        if(i<array.Length) Console.Write(array[i] + ", ");
    }
}

Console.WriteLine("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateArray(size);
ShowArray(myArray);
*/

