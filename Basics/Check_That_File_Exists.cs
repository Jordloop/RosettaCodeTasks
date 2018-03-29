// Task
// Verify that a file called     input.txt     and   a directory called     docs     exist.


// This should be done twice:  

//   once for the current working directory,   and
//   once for a file and a directory in the filesystem root.

//   http://www.rosettacode.org/wiki/Check_that_file_exists

using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine(File.Exists("Check_that_file_exists.cs"));
        Console.WriteLine(Directory.Exists("../Basics"));
    }
}