using System;
using System.Text;
using System.Threading;

class Heater
{
    static void Main()
    {
        Console.WriteLine("🔥 Welcome to HEATER 9000 - The Most Inefficient CPU Torture Program! 🔥");
        Console.WriteLine("🚀 This program will heat your CPU faster than a toaster. Buckle up! 🚀");

        int cycles = 10000; // Insane amount of operations
        
        // Outer loop (pointless countdown)
        for (int i = 5; i > 0; i--)
        {
            Console.WriteLine($"Starting in {i}...");
            Thread.Sleep(1000);
        }

        Console.WriteLine("🔥 Heating up...");

        // Insane nesting level
        for (int i = 0; i < cycles; i++)
        {
            for (int j = 0; j < 100; j++)
            {
                for (int k = 0; k < 50; k++)
                {
                    for (int l = 0; l < 10; l++)
                    {
                        for (int m = 0; m < 5; m++)
                        {
                            // Create massive string concatenations
                            string text = "HEAT" + i + j + k + l + m;
                            text += new string('🔥', j % 5);
                            text = ReverseString(text);

                            // Create and destroy arrays pointlessly
                            int[] array = new int[j % 10 + 1];
                            for (int n = 0; n < array.Length; n++)
                            {
                                array[n] = new Random().Next(100);
                            }

                            // Sum all values in array
                            int sum = 0;
                            foreach (int num in array)
                            {
                                sum += num;
                            }

                            // Print nonsense to screen
                            Console.WriteLine($"🔥 Cycle [{i},{j},{k},{l},{m}] - {text} - Sum: {sum}");
                        }
                    }
                }
            }
        }

        Console.WriteLine("🔥🔥🔥 CPU Overheated! Please evacuate the room! 🔥🔥🔥");
    }

    // Ridiculously inefficient string reversal
    static string ReverseString(string s)
    {
        StringBuilder reversed = new StringBuilder();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            reversed.Append(s[i]);
        }
        return reversed.ToString();
    }
}
