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
    /*
    Plan:
       1. Initialize a double array called `result` with a size equal to the `length` parameter.
       2. Use a for loop to iterate from `0` to `length - 1`, using `i` as the index variable.
       3. Inside the loop, create a double variable `num` and set it to `number * (i + 1)` to calculate the multiple.
       4. Assign the value of `num` to `result[i]`.
       5. After the loop, return the `result` array containing the calculated multiples.
    */
        
        var result = new double[length];

        for (var i = 0; i < length; i++) {
            double num = number * (i + 1);
            result[i] = num;
        }

        return result;
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
    /*
    Plan:
       1. Get the count of elements in `data` and store it in the variable `length`.
       2. Check if `length` is `0` or if `amount` is divisible by `length`. If true, return early.
       3. Create a list `partToMove` by using `GetRange` to retrieve the last `amount` elements from `data`.
       4. Remove the same `amount` of elements from the end of `data` using `RemoveRange`.
       5. Insert `partToMove` at the beginning of `data` using `InsertRange`.
    */
        int length = data.Count;
        if (length == 0 || amount % length == 0) 
            return;
        List<int> partToMove = data.GetRange(length - amount, amount);
        data.RemoveRange(length - amount, amount);
        data.InsertRange(0, partToMove);
        
    }
}
