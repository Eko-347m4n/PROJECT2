using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Case 1
        int[] numbers1 = { 1, 2, 3, 4, 5 };
        int target1 = 4;
        FindTarget(numbers1, target1);

        Console.WriteLine(); // Add a blank line for better readability between cases

        // Case 2
        int[] numbers2 = { 2, 4, 3 };
        int target2 = 4;
        FindTarget(numbers2, target2);

        Console.WriteLine(); // Add a blank line for better readability between cases

        // Case 3
        int[] numbers3 = { 1, 5, 8, 9 };
        int target3 = 2;
        FindTarget(numbers3, target3);
    }

    public static void FindTarget(int[] numbers, int target)
    {
        bool found = false;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
            {
                Console.WriteLine($"Target has been reached in index number {i}");
                found = true;
                break; // Exit the loop once the target is found
            }
        }

        if (!found)
        {
            Console.WriteLine("Target not found in array data");
        }
    }
}