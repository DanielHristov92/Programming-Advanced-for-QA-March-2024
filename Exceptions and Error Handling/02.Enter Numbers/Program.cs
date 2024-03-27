using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[10];
        int start = 1;
        int end = 100;

        try
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ReadNumber(start, end);
                start = numbers[i];
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static int ReadNumber(int start, int end)
    {
        while (true)
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Invalid Number!");
                continue;
            }

            if (number <= start || number >= end)
            {
                Console.WriteLine($"Your number is not in range {start} - {end}!");
                continue;
            }

            return number;
        }
    }
}
