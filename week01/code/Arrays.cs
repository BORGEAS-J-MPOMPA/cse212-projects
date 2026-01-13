using System.Drawing;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Set a condition to return an empty array if the length is less than or egal to zero
        if (length <= 0)
            return Array.Empty<double>();
            // Assign result to new double depending on the length
        double[] result = new double[length];

        // Iterate through the function

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        return result; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Create a variable to count data in the list
        int n = data.Count;
        
        // Set a conditional function returns nothing if the list or the array is empty
        if (n == 0)
            return;

        // Set a normal rotation of the amount
        amount %= n;

        // Create a temporary list or array 
        List<int> temp = new List<int>(new int[n]);
        
        // Put each element in its rotated position
        for (int i = 0; i < n; i++)
        {
            int newIndex = (i + amount) % n;
            temp[newIndex] = data[i];
        }

        // Copy the rotated values back
        for (int i = 0; i < n; i++)
        {
            data[i] = temp[i];
        }
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
    }
}
