using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsShift
{
    class Program
    {
        static void Main(string[] args)
        {

           

            Console.ReadLine();
        }

        public static string VowelShift(string text, int n)
        {

            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            List<int> vowels_in_text = new List<int>();
            List<char> vowels_chars = new List<char>();
            
            for (int i = 0; i < text.Length; i++)
            {


                if (Array.IndexOf(vowels,text[i]) != -1){


                    vowels_in_text.Add(i);
                    vowels_chars.Add(text[i]);
                }

            }


            List<int> copy_indexes = new List<int>();

            for(int k = 0; k < vowels_in_text.Count; k++)
            {

                copy_indexes.Add(0);
            }

            
            


            for (int i = 0; i<vowels_in_text.Count; i++)
            {

                int difference = 0 - n;

                int exp = difference / vowels_in_text.Count + 1;

                int index = n + (exp * vowels_in_text.Count);


                if (n < 0)
                {

                   
                    copy_indexes[(index+i) % vowels_in_text.Count] = vowels_in_text[i];

                }else
                {

                    copy_indexes[(i + n + vowels_in_text.Count) % vowels_in_text.Count] = vowels_in_text[i];

                }







            }

            StringBuilder text_result = new StringBuilder(text);

            for(int i=0; i < vowels_in_text.Count; i++)
            {

                int x = copy_indexes[i];

                text_result[vowels_in_text[i]] = text[x];


                
            }
                    


                return text_result.ToString();
        }

    }
}
