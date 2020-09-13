using System;
using System.Collections.Generic;


namespace Abbreviator //Application that takes in a string and provides an abbreviation in the form of (first letter)+(count of removed letters)+(last letter) and checks if the abbreviation matches the abbreviation of any word in a dictionary
{

 

    class Program
    {


        static string abbreviate(string word)
        {
            string abb = string.Empty;
            try
            {
                string first = word[0].ToString();
                string last = word[word.Length - 1].ToString();


                // if Word is of size 1 
                if (word.Length < 2)
                    abb = first+"0";

                //  if Word is of size 2
                if (word.Length == 2)
                    abb = first +"0"+ last;
                

                
                if (word.Length >= 3)
                abb = (first + (word.Length - 2).ToString() + last);

                
            }
            catch { Console.WriteLine("Abbreviation has failed, please enter a string.");}
            return abb;
        }



        static bool dictionaryLookUp(string word)
        {
           bool wordIsUnique = true;
            try
            {
                
                
                List<string> dictionary = new List<string> { "accessibility", "automatically", "internationalization", "localization" };

                foreach(string item in dictionary)
                {
                    
                    if(abbreviate(item) == abbreviate(word))
                    { 
                        wordIsUnique = false;
                    }
                       
                }



            } catch { Console.WriteLine("Dictionary Look up has encountered an error"); }
            return wordIsUnique;
        }





        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string.");
            string checkWord;
            checkWord = Console.ReadLine();
            Console.WriteLine("the abbreviation of the word you entered is: ");
            Console.WriteLine(abbreviate(checkWord));


            Console.WriteLine("Is the abbreviation unique the Dictionary?");

            Console.WriteLine(dictionaryLookUp(checkWord));
           


        }
    }

    
}
