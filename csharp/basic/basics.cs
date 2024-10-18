using System;

class BasicCodes {
    public BasicCodes() {
        // SAMPLE COMMMENT FOR SINGLE LINE

        /*
            SAMPLE COMMMENTATION FOR MULTIPLE LINES
        */
        Console.WriteLine("Hello World!"); // .WriteLine appends new line to console
    }

    public static void verbatim(string input) {
        Console.WriteLine(@"C:\\output\data"); // Print the input string without escaping characters
    }

    public static void stringInterpolation(string input) {
        Console.WriteLine($"Hello, {input}!"); // Use string interpolation to embed variables in the string
    }

    public static void tupplesImp(string name, string rank) 
    {   
        (string userName, string userRank) user = (name, rank);
        Console.WriteLine($"Name: {user.userName}, Rank: {user.userRank}"); // Deconstruct the tuple
    }
}