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

        public string URLify (string str, int cnt)
        {
            
            if (str != null && str != "")
            {
                char[] arr = str.ToCharArray();

                int spases = 0;

                for (int i = 0; i < cnt; i++)
                {
                    if (arr[i] == ' ')
                        spases++;
                }

                int index = cnt + spases * 2;                                
                
                for (int i = cnt - 1; i >= 0; i--)
                {                   
                    
                    if (arr[i] == ' ')
                    {
                        arr[index - 1] = '0';
                        arr[index - 2] = '2';
                        arr[index - 3] = '%';
                        index -= 3;
                    }
                    else
                    {
                        arr[index - 1] = arr[i];
                        index--;
                    }
                    
                }
                return new string(arr);
            }
            return "";
        }

        public bool IsPermutationPalindrome(string str)
        {
            if (str != null && str != "")
            {
                int[] freq = CreateFreqTable(str);

                return IsMaxOne(freq);
            }
            else
                return true;
        }

        private int[] CreateFreqTable(string str)
        {
            int[] dict = new int[(int)('z') - (int)('a') + 1];
            for (int i = 0; i < str.Length; i++)
            {
                int index = GetCharIndex(str[i]);

                if (index != -1)
                    dict[index]++;
            }
            return dict;
        }

        private int GetCharIndex(char ch)
        {
            int a = (int)('a');
            int z = (int)('z');
            int c = (int)(ch);

            if (a <= c && c <= z)
            {
                return c- a;
            }
            else
                return -1;
        }

        private bool IsMaxOne(int[] freqTable)
        {
            bool isOne = false;

            for (int i = 0; i < freqTable.Length; i++)
            {
                if (freqTable[i] % 2 == 1)
                {
                    if (isOne)
                    {
                        return false;
                    }
                    else
                        isOne = true;
                }
            }
            return true;
        }

        public bool IsOneEditAway(string str1, string str2)
        {
            if (str1 != null && str2 != null)
            {
                if (str1.Length == str2.Length)
                    return IsOneReplacement(str1, str2);

                if (str1.Length == str2.Length + 1)
                    return IsOneEdit(str1, str2);

                if (str1.Length == str2.Length - 1)
                    return IsOneEdit(str2, str1);
            }
            return false;
        }

        private bool IsOneReplacement(string str1, string str2)
        {
            bool isFound = false;

            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    if (isFound)
                        return false;
                    isFound = true;
                }                
            }
            return true;
        }

        private bool IsOneEdit(string large, string small)
        {
            bool isFound = false;
            int index = 0;

            if (small == "" && large.Length == 1)
                return true;

            for(int i = 0; i < large.Length; i++)
            {                
                if (large[i] != small[index])
                {                    
                    if (isFound)
                        return false;
                    isFound = true;
                    index--;
                }
                index++;
            }
            return true;
        }
    }
}
