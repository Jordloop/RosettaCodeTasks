// Task
// List the   conditional structures   offered by a programming language.

// Common conditional structures are     if-then-else     and     switch. 

// http://www.rosettacode.org/wiki/Conditional_structures

using System;

class Program
{
    static void Main()
    {
        bool condition = false;
        int caseSwitch = 42;
        
// if-else statement
        if(condition)
        {
            Console.WriteLine("Condition evaluated true.");
        }
        else
        {
            Console.WriteLine("Condition evaluated false.");
        }

// ternary opperator
        string Ternary_Operator = condition ? "Condition evaluated true." : "Condition evaluated false.";
        Console.WriteLine(Ternary_Operator);

// switch statement
        switch(caseSwitch)
        {
            case 1:
                Console.WriteLine("case 1");
                break;
            case 2:
                Console.WriteLine("case 2");
                break;
            case 3:
                Console.WriteLine("case 3");
                break;
            default:
                Console.WriteLine("Default case");
                break;
        }

    }
}