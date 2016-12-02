using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsMyFriendCheating
{
    class Program
    {
        static void Main(string[] args)
        {

            removNb(26);
        }

        public static List<long[]> removNb(long n)
        {


            List<long[]> lst = new List<long[]>();

           
            for (long i = n/2*(n-1); i < n; i++)
            {


                for (long j = n/2; j < n; j++)
                {


                    if (i * j == ((n * (n + 1)) / 2) - (i + j))
                    {


                        lst.Add(new long[]{i,j});
                       



                    }

                }
            }




            return lst;



        }
    }
}
