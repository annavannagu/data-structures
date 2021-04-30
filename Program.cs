using System;

namespace data_structures
{
    class Program
    {
        static void Main(string[] args)
        {
            ArraysStrings arr = new();

            bool res = arr.CheckPermutation("g3215", "g3254");

            Console.WriteLine(res);
        }
    }
}
