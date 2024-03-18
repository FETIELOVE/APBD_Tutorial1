namespace Tutorial;



public class Program
{
    public static void Main(string[] args)
    {
        // Example usage:
        int[] numbers = { 1, 2, 3, 4, 5 };
        double average = CalculateAverage(numbers);
        Console.WriteLine("Average: " + average);
    }

    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty");
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        // Calculate average
        double average = (double)sum / numbers.Length;
        return average;
    }
}