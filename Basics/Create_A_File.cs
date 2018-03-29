// Task
// Create a new, empty, file called "output.txt" of size 0 bytes and an empty directory called "docs". 
// This should once in the current working directory and once in the filesystem root.

// http://www.rosettacode.org/wiki/Create_a_file

using System;
using System.IO;

class Program
{
    static void Main()
    {
        Directory.CreateDirectory("docs");
        Directory.CreateDirectory(@"\docs");

        File.Create("output.txt");
        File.Create(@"\docs\output.txt");
    }
}