using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static string Concat(string a, string b)
        {
            return a + b;
        }
        public static string Substring(string a, int start, int length)
        {
            string sub = "";
            for (int i = start; i < start + length; i++)
            {
                sub += a[i];
            }
            return sub;
        }
        public static int IndexOf(string a, string b)
        {
            int index = 0;
            int indexB = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b[indexB])
                {
                    indexB++;
                    if (indexB == b.Length)
                    {
                        index = i - b.Length + 1;
                        break;
                    }
                }
                else
                {
                    indexB = 0;
                }
            }
            return index;
        }
        public static string Replace(string a, string b, string c)
        {
            string replace = "";
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b[index])
                {
                    index++;
                    if (index == b.Length)
                    {
                        replace += c;
                        index = 0;
                    }
                }
                else
                {
                    replace += a[i];
                    index = 0;
                }
            }
            return replace;
        }
    }
}
