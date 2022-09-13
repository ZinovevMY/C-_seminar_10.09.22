/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfNumbers(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num%10;
        num = num/10;
    }
    return result;
}

int number = Prompt("Введите число: ");
System.Console.WriteLine($"Сумма чисел, составляющих число {number} равна {SumOfNumbers(number)}");
