// Task
// Show how to represent the boolean states "true" and "false" in a language.

// If other objects represent "true" or "false" in conditionals, note it.

// http://www.rosettacode.org/wiki/Boolean_values

using System;

class Program 
{
    static void Main()
    {
        bool isTrue = false;

        if(isTrue != true) isTrue = !isTrue;

        Console.WriteLine(isTrue);
    }
}