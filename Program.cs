using System;

namespace data_structures
{
    class Program
    {
        static void Main(string[] args)
        {
            ArraysStrings arr = new();

            bool res = arr.IsOneEditAway("g1235", "g12315");

            Console.WriteLine(res);
        }
    }
}
