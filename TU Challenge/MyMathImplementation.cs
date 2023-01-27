using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static bool IsMajeur(int age)
        {
            if (age < 0 || age > 150)
            {
                throw new ArgumentException();
            }
            else
            {
                if (age >= 18)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool IsEven(int a)
        {
            if (a < 0)
            {
                a = -a;
            }
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
