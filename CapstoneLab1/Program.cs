using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapstoneLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string toTranslate = "";
            string vowels = "AEIOUaeiou";
            bool alphaNum = true;

            // console input
            while (alphaNum)
            {
                Console.WriteLine("Translate English to PigLatin!");
                Console.WriteLine("Please type what you want translated:");
                toTranslate = Console.ReadLine().ToLower();

            // validation
            // if else statement
            

                for (int i = 0; i < toTranslate.Length; i++)
                {
                    if ((toTranslate[i] >= 'a') && (toTranslate[i] <= 'z') || (toTranslate[i] >= 'A') && (toTranslate[i] <= 'Z'))
                    {
                        alphaNum = false;
                    }
                    else
                    {
                        alphaNum = true;
                        Console.WriteLine("You entered an invalid response. Please try again.");
                    }
                 
                }
                
            }
                //formula to convert english to pig latin

                int index = toTranslate.IndexOfAny(vowels.ToCharArray()); // finding the firt vowel in the toTranslate input word.
                string endWord = toTranslate.Substring(index); // saving the vowel and anything after into an index
                string startWord = toTranslate.Substring(0, index); // saving anything before the first vowel + words "index"

                // result

                Console.WriteLine(endWord + startWord + "ay");
          
        }
    }
}
