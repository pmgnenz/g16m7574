using System;

namespace Problems
{
   public class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine(Prefix("hello"));
              Console.WriteLine(Prefix(""));
            Console.WriteLine(Prefix("what    ...  did you say?? "));
            Console.ReadLine();
        }
        static string Prefix(string inp)
        {
            int strlength = inp.Length;
            int wordscount = 0;
            string str;
            string[] words = inp.Split(' ');
            if (strlength != 0)
            {
                foreach (string word in words)
                {
                    if (word != "")
                    {
                        wordscount++;
                    }
                }
            }
            
            str = strlength + "," + wordscount + ":" + inp;
            return str;



        }
    }
}
