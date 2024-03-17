namespace Tutorial;



public class Program
{
    public static void Main(string[] args)
    {
       
        int[] numbers = { 10, 8, 3, 12, 4 };
        int max = FindMaximum(numbers);
        Console.WriteLine("Maximum value: " + max);
    }

    
    public static int FindMaximum(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty");
        }

        int max = numbers[0]; 

       
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num; 
            }
        }

        return max; 
    }
}
