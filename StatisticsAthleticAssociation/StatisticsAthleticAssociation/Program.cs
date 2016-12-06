using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticsAthleticAssociation
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(stat("01|15|59, 1|47|16, 01|17|20, 1|32|34, 2|17|17"));

            Console.ReadLine();
        }

        public static string stat(string strg)
        {

            if (strg == "") return "";

            strg = strg.Replace(@"|",":");

            string [] results = strg.Trim().Split(',');

            List<TimeSpan> resultsTime = new List<TimeSpan>();

           foreach(string result in results)
            {

                TimeSpan time = new TimeSpan(int.Parse(result.Split(':')[0]),int.Parse(result.Split(':')[1]),int.Parse(result.Split(':')[2]));

                resultsTime.Add(time);

            }

            
            TimeSpan average = TimeSpan.FromSeconds((long)resultsTime.Select(ts => ts.TotalSeconds).Average());

            TimeSpan range = resultsTime.Max() - resultsTime.Min();

            TimeSpan median = TimeSpan.MinValue;

            resultsTime = resultsTime.OrderBy(t => t.TotalSeconds).ToList();

            if (resultsTime.Count % 2 == 0) {





                median =TimeSpan.FromSeconds((long)((resultsTime[(resultsTime.Count / 2) - 1] + resultsTime[resultsTime.Count / 2]).TotalSeconds/2));

            }
            else{

                median = resultsTime[(resultsTime.Count / 2)];

            }
           


            return "Range: "+range.ToString().Replace(":","|")+" Average: "+average.ToString().Replace(":","|")+" Median: "+median.ToString().Replace(":","|");

        }

       
        

    }
}
