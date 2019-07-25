using System;
using System.IO;
using System.Collections.Generic;

namespace ReversChar
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string str = "";
            getWords(str);
            //string str = "uoY detnaw ot wonk ohw I ,ma oreZ ?looC ,lleW tel em nialpxe eht weN dlroW .redrO stnemnrevoG dna snoitaroproc deen elpoep ekil uoy dna .em eW era ...iarumaS eht draobyeK ...syobwoC dna lla esoht rehto elpoep ohw evah on aedi s'tahw gniog no era eht ...elttac ooooM";

            reverseWords(str);
        }

        private static string getWords(object str)
        {
            string filePath = @"/Users/antonio/Documents/GitHub/CSC180/ReversChar/ReversChar/bin/Debugreversme.txt";
            using (FileStream file = new FileStream(filePath))
            {
                StreamReader reader = new StreamReader(file);
            }

            return reader;
        }

        // Reverse individual words in a string.
        public static void reverseWords(string str)
        {
            Stack<char> st = new Stack<char>();

            // Traverse given string and push 
            // all characters to stack until 
            // we see a space. 
            for (int i = 0; i < str.Length; ++i)
            {
                if (str[i] != ' ')
                {
                    st.Push(str[i]);
                }

                // When we see a space, we 
                // print contents of stack. 
                else
                {
                    while (st.Count > 0)
                    {
                        Console.Write(st.Pop());
                    }
                    Console.Write(" ");
                }
            }

            // Since there may not be 
            // space after last word. 
            while (st.Count > 0)
            {
                Console.Write(st.Pop());

            }
        }
    }
}





