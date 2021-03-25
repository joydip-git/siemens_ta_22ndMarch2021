using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamArray
{
    class Program
    {
        //static string[] SplitSentence(string input, params char[] splitters)
        //{
        //    return new string[] { };
        //}
        static void Main()
        {
            //Console.Write("Enter a sentence: ");
            //string sentence = Console.ReadLine();
            string sentence = "My name is Joydip, I am a DotNet Consultant.";
            sentence.Split(' ', ',', '.');
            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    char ch = sentence[i];
            //    if (char.IsSeparator(ch))
            //    {

            //    }
            //}

            //char[] separators = new char[] { ' ', ',' };
            //SplitSentence(sentence, separators);
            //SplitSentence(sentence, ' ', ',');
            //SplitSentence(sentence, ' ', ',', '.');
            /**
             * My
             * name
             * is
             * joydip
             * I 
             * am 
             * a
             * DotNet
             * Consultant
             */
        }
    }
}
