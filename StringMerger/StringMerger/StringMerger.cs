using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMerger
{
    class StringMerger
    {


        public static void Main(string[] args)
        {

            Console.ReadLine();

        }



        public static bool isMerge(string s, string part1, string part2)
        {

            if (s.Length != part1.Length + part2.Length)
            {


                return false;


            }

            for (int i = 0; i < s.Length; i++)
            {

                if ((part1.Length > 0 && s[i] != part1[0]) && (part2.Length > 0 && s[i] != part2[0]))
                {
                    return false;


                }
                else if ((part1.Length > 0 && s[i] == part1[0]))
                {

                    if (i != s.Length - 1)
                    {

                        if (part2.Length > 0 && part1[0] == part2[0] && part2[1] == s[i + 1])
                        {


                            part2 = part2.Remove(0, 1);

                        }
                        else {

                            part1 = part1.Remove(0, 1);

                        }

                    }
                    else {

                        part1 = part1.Remove(0, 1);
                    }

                }
                else if ((part2.Length > 0 && s[i] == part2[0]))
                {

                    part2 = part2.Remove(0, 1);

                }
                else {

                    return false;

                }





            }



            return true;
        }

    }
    [TestFixture]
    public class StringMergerTests
    {
        [Test]
        public void HappyPath1()
        {
            Assert.IsTrue(StringMerger.isMerge("codewars", "code", "wars"), "codewars can be created from code and wars");
        }

        [Test]
        public void HappyPath2()
        {
            Assert.IsTrue(StringMerger.isMerge("codewars", "cdwr", "oeas"), "codewars can be created from cdwr and oeas");
        }

        [Test]
        public void SadPath1()
        {
            Assert.IsFalse(StringMerger.isMerge("codewars", "cod", "wars"), "Codewars are not codwars");
        }
    }

}
