// Task
// Show how to concatenate two arrays in your language.


// If this is as simple as array1 + array2, so be it.

// http://www.rosettacode.org/wiki/Array_concatenation

using System;

class Program 
{
    static void Main()
    {
        // Instantiate arrays
        int[] arr1 = new int[] { 1, 2, 3};
        int[] arr2 = new int[] { 4, 5, 6, 7};

        // Instantiates a new array with the proper size
        int[] arr3 = new int[arr1.Length + arr2.Length];

        // Copies contents of arr1 to arr3 starting at inex 0
        arr1.CopyTo(arr3, 0);
        arr2.CopyTo(arr3, arr1.Length);

        foreach(int n in arr3)
        {
            Console.WriteLine(n.ToString());
        }
    }
}