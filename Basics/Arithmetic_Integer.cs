// Task
// Get two integers from the user,   and then (for those two integers), display their:

//   sum
//   difference
//   product
//   integer quotient
//   remainder
//   exponentiation 

// Don't include error handling.
// For quotient, indicate how it rounds   (e.g. towards zero, towards negative infinity, etc.).
// For remainder, indicate whether its sign matches the sign of the first operand or of the second operand, if they are different. 

// http://www.rosettacode.org/wiki/Arithmetic/Integer#C.23

using System;
 
class Program
{
    static void Main(string[] args)
    {
        int a = Convert.ToInt32(args[0]);
        int b = Convert.ToInt32(args[1]);

        Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        Console.WriteLine("{0} % {1} = {2}", a, b, a % b);
        Console.WriteLine("{0} to the power of {1} = {2}", a, b, Math.Pow(a, b));

    }
}