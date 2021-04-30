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

        public bool IsUniqueCharsInString(string str)
        {            
            if(str != null && str != "")
            {
                if (str.Length > 128)
                    return false;

                bool[] chars = new bool[128];
                for (int i = 0; i < str.Length; i++)
                {
                    int val = (int)str[i];
                    if (chars[val])
                        return false;
                    chars[val] = true;
                }
            }            
            return true;
        }

        public bool CheckPermutation(string str1, string str2)
        {
            //faster method O(N) time
            if (str1 != null && str2 != null && str1 != "" && str2 != "")
            {
                if (str1.Length != str2.Length)
                    return false;

                int[] chars1 = new int[128];
                int[] chars2 = new int[128];
                for (int i = 0; i < str1.Length; i++)
                {
                    int val = (int)str1[i];
                    chars1[val] = chars1[val] + 1;
                    val = (int)str2[i];
                    chars2[val] = chars2[val] + 1;
                }


                for (int i = 0; i < 128; i++)
                {
                    if (chars1[i] != chars2[i])
                    {
                        return false;
                    }

                }
            }
            return true;

            //slower method O(NlogN) time

            //if (str1 != null && str2 != null && str1 != "" && str2 != "")
            //{
            //    if (str1.Length != str2.Length)
            //        return false;

            //    return Sort(str1) == Sort(str2);
            //}
            //return true;
        }

        private string Sort (string str)
        {
            char[] arr = str.ToCharArray();            
            Array.Sort(arr);
            return new string(arr);
        }

       
    }
}
