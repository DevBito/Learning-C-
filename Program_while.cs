using System;
using System.Globalization;

class Program_while { 
    public static void Main(string[] args )
    {
        int count = 1;
        while (count <= 100000000)
        {
            Console.WriteLine(count);
            count = count + 1;
        }
    }



}