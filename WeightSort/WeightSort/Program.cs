using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightSort
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(orderWeight("103 123 4444 99 2000"));

            Console.ReadLine();

        }

        public static string orderWeight(string strng)
        {

            

            if (strng == "") return "";



            var listOfWeights = new List<KeyValuePair<string, int>>();


            var weights = strng.Split(' ');

            

            foreach (string weight in weights)
            {
                int sum = 0;

                foreach (char c in weight)
                {
                    sum += ((int)Char.GetNumericValue(c));

                }

                listOfWeights.Add(new KeyValuePair<string, int>(weight, sum));

            }

            listOfWeights = listOfWeights.OrderBy(x => x.Value).ThenBy(x => x.Key).ToList();

           


            strng = "";

            foreach(KeyValuePair<string,int> str in listOfWeights)
            {
                strng += str.Key + " ";

            }

            return strng.Trim();
       }
    }
}
