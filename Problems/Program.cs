using System;

namespace Problems
{
   public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
             Console.WriteLine(p.Prefix("hello"));
              Console.WriteLine(p.Prefix(""));
            Console.WriteLine(p.Prefix("what    ...  did you say?? "));
            Console.ReadLine();
        }
        public string Prefix(string inp)
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
