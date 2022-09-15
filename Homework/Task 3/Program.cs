/*Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. Также ищет второй максимум (число меньше максимального элемента, но больше всех остальных)
8 1 2 4 4 5 3 1 -> 5
1 2 6 9 8 1 1 1 -> 8
*/

const int MIN_ELEMENTS = 1;
const int MAX_ELEMENTS = 50;
const int ARRAY_SIZE   = 8;

int[] GenerateArray(int length, int minRandom, int maxRandom)
{
    Random rnd = new Random();
    int[] answer = new int[length];
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(minRandom, maxRandom + 1);
    }
    return answer;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "\t");
    }
    System.Console.WriteLine();
}

int FindSecondMaxInArray(int[] arr)
{
    int max1 = 0;
    int max2 = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max1)
        {
            max2 = max1;
            max1 = arr[i];
        }
        if (arr[i] > max2 && arr[i] < max1)
        {
            max2 = arr[i];
        }
    }
    return max2;
}

int[] array = GenerateArray(ARRAY_SIZE, MIN_ELEMENTS, MAX_ELEMENTS);
PrintArray(array);
System.Console.WriteLine($"Второе максимально число в массиве {FindSecondMaxInArray(array)}");
