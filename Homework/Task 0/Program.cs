/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int DegreeOfNumber(int num, int deg)
{
    int result = 1;
    for (int i = 0; i < deg; i++)
    {
        result = result * num;
    }
    return result;
}

int number = Prompt("Введите число: ");
int degreeOfNumber = Prompt("Введите степень в которую возводим: ");
System.Console.WriteLine($"Число {number} в степени {degreeOfNumber} равно {DegreeOfNumber(number,degreeOfNumber)}");
