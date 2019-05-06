using System;

namespace SOReverseMe
{
    class MainClass
    {
        public static void Main()
        {
            const string s1 = "Bill Gates is the richest man on Earth";
            const string s2 = "uoY detnaw ot wonk ohw I ,ma oreZ ?looC ,lleW tel em nialpxe eht weN dlroW .redrO stnemnrevoG dna snoitaroproc deen elpoep ekil uoy dna .em eW era ...iarumaS eht draobyeK ...syobwoC dna lla esoht rehto elpoep ohw evah on aedi s'tahw gniog no era eht ...elttac ooooM";
            const char s3 = 'uoY detnaw ot wonk ohw I ,ma oreZ ?looC ,lleW tel em nialpxe eht weN dlroW .redrO stnemnrevoG dna snoitaroproc deen elpoep ekil uoy dna .em eW era ...iarumaS eht draobyeK ...syobwoC dna lla esoht rehto elpoep ohw evah on aedi s'tahw gniog no era eht...elttac ooooM';

            // In the Main() method, the rev1/rev2 string variables will
            // call the WordTools class and its .ReverseWords() method
            // and applied to both s1 and s2 strings that were declared
            // and assigned the beginning of the method. 'rev1' and 'rev2'
            // are introduced as new variables because the original s1
            // and s2 were declared as constant strings.
            string rev1 = ReverseWords(s1);
            Console.WriteLine(rev1);

            // Print original
            Console.WriteLine(s2);

            // Print original
            Console.WriteLine(s3);

            string rev2 = ReverseWords(s2);
            Console.WriteLine(rev2);
        }

        private static string ReverseWords(string sentence)
        {
            // The ReverseWords class accepts a string data type
            // for the 'sentence' variable.

            // The 'words' variable is declared as a string
            // data type that will be an array. The sentence.Split()
            // will store strings that are split by spaces, e.g.,
            // "the dog" string will store the strings "the" and "dog".
            string[] words = sentence.Split(' ');

            // The .Reverse() method will now reverse the stored strings
            // inside the 'words' array.
            Array.Reverse(words);

            // Finally, the ReverseWords() method will return
            // the previously reversed strings in the 'words'
            // variable and join the strings separated by
            // a space.
            return string.Join(" ", words);
        }

        private static string ReverseCharacters(char s3)
        {
            // The ReverseWords class accepts a string data type
            // for the 'sentence' variable.

            // The 'words' variable is declared as a string
            // data type that will be an array. The sentence.Split()
            // will store strings that are split by spaces, e.g.,
            // "the dog" string will store the strings "the" and "dog".
            char[] characters = s3(' ');

            // The .Reverse() method will now reverse the stored strings
            // inside the 'words' array.
            Array.Reverse(characters);

            // Finally, the ReverseWords() method will return
            // the previously reversed strings in the 'words'
            // variable and join the strings separated by
            // a space.
            return string.Join(" ", characters);
        }
    }
}
/*
   Source: https://www.dotnetperls.com/reverse-words
   Author: Sam Allen
   Summary: This program reverses the order of strings without
            reversing the strings.
   Date: 4 May 2019
   Modifications: ----
 */


/*      
        Example output:
        Earth on man richest the is Gates Bill
        mathematician brilliant a was Ramanujan Srinivasa
*/
