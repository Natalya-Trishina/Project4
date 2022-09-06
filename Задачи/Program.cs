// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

{
    Console.Write("Решаем задачу 25 ");
    Console.Write("Введите число A: ");
    int NumberA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число B: ");
    int NumberB = Convert.ToInt32(Console.ReadLine());
    int result = 1;
    for (int i = 0; i < NumberB; i++)
    {
        result = result * NumberA;
    }

    Console.WriteLine("число A  в степени B = ");
    Console.WriteLine(result);

}


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
{
    Console.Write("Решаем задачу 27 ");
    int inputNumber = GetInteger(" Введите число: ");
    int sumDigits = SumDigits(inputNumber);
    Console.WriteLine($"Сумма цифр числа {inputNumber}: {sumDigits}");

    int GetInteger(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }

    int SumDigits(int number)
    {
        int result = 0;

        while (number != 0)
        {
            result += number % 10;
            number /= 10;
        }

        return result;
    }
}

 
