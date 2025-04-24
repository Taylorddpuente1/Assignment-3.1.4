



using System;
 
class Program
{
    static void Main()
    {
        int[] numbers = { 0, 2, 1, 1, 9, 1, 1 };

        Console.WriteLine("Before: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i] + " ");
        }
        ReplaceOnes(numbers);

        Console.WriteLine("After: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i] + " ");
        }
    }

    static void ReplaceOnes(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == 1 && arr[i + 1] == 1)
            {
                arr[i] = 0;
                arr[i + 1] = 0;
                break;
            }
        }
    }
}