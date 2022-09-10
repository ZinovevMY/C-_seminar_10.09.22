//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = Prompt("Введите число: ");

int NumCount(int num)
{
    int counter = 0;
    while (num > 0)
    {
        num = num/10;
        counter++;
    }
    return counter;

}
int numcount = NumCount(number);
System.Console.WriteLine($"В числе {number} {numcount} цифр.");
