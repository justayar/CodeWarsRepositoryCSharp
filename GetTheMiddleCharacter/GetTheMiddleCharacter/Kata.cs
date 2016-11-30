using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTheMiddleCharacter
{
    class Kata
    {
        static void Main(string[] args)
        {
        }

        public static string GetMiddle(string s)
        {

            if (s.Length % 2 == 1)
            {


                return s[s.Length / 2].ToString();

            }
            else {

                return s[s.Length / 2 - 1].ToString() + s[s.Length / 2].ToString();

            }
        }
    }
}
