using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures
{
    public class ArraysStrings
    {
        public ArraysStrings() { }

        public bool isUniqueCharsInString(string str)
        {
            if (str.Length > 128)
                return false;
            bool[] chars = new bool[128];
            for (int i = 0; i < str.Length; i++)
            {

            }
            return true;
        }
    }
}
