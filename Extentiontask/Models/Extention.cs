using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extentiontask.Models
{
    static class Extention
    {
        public static bool HasDigit(this string str)
        {
            bool answerr = false;
            str = str.Trim();
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    answerr = true;
                }
            }
            return answerr;
        }
        public static bool IsOdd(this int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            return true;
        }
        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            return false;
        }
        public static void ToCapitalize(this string str)
        {
            str = str.Trim();
            if (String.IsNullOrEmpty(str))
            {
                Console.WriteLine("Empty String");
            }
            else
            {
                Console.WriteLine(char.ToUpper(str[0])+str.Substring(1).ToLower());
             }
        }

    }
}
