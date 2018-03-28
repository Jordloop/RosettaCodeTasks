// Task
// Show basic array syntax in your language.

// Basically, create an array, assign a value to it, and retrieve an element   (if available, show both fixed-length arrays and dynamic arrays, pushing a value into it).

// Please discuss at Village Pump:   Arrays.

// Please merge code in from these obsolete tasks:

//   Creating an Array
//   Assigning Values to an Array
//   Retrieving an Element of an Array

// http://www.rosettacode.org/wiki/Arrays

using System;
using System.Collections.Generic;

class Project
{
    static void Main()
    {
        //Create a list with assigned values
        List<string> fruits = new List<string>() {"Raspberry", "Blueberry", "Pineapple" };

        //Assign new value to list
        fruits.Add("Apple");

        //Access the 2nd element of the list
        string blueberry = fruits[1];

        //Print each list element to console
        foreach(string fruit in fruits) Console.WriteLine(fruit);
    }
}