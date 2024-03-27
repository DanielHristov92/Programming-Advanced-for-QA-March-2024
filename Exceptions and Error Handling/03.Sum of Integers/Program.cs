using System;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        int sum = 0;

        foreach (string input in inputs)
        {

            try
            {
                int number = int.Parse(input);
                sum += number;
            }

            catch (FormatException)
            {
                Console.WriteLine($"The element '{input}' is in wrong format!");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"The element '{input}' is out of range!");
            }
            finally
            {
                Console.WriteLine($"Element '{input}' processed - current sum: {sum}");
            }
        }
        Console.WriteLine($"The total sum of all integers is: {sum}");
    }
}