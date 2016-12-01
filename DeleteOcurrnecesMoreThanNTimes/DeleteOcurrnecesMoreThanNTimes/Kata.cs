using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteOcurrnecesMoreThanNTimes
{
    class Kata
    {
        static void Main(string[] args)
        {
        }

        public static int[] DeleteNth(int[] arr, int x)
        {

            

            int[] result_arr = new int[arr.Count()];


            for (int i = 0; i < arr.Count(); i++)
            {


                int counter = 0;


                int arr_nextposition = 0;


                for (int j = 0; j < result_arr.Count(); j++)
                {


                    if (result_arr[j] == 0)
                    {


                        arr_nextposition = j;


                        break;

                    }



                    if (result_arr[j] == arr[i])
                    {

                        counter++;

                    }



                }

                if (counter < x)
                {


                    result_arr[arr_nextposition] = arr[i];

                }


            }


            result_arr = result_arr.Where(val => val != 0).ToArray();


            return result_arr;


        }
    }
}
