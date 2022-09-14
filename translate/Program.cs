// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {           
            // Write a program that translates a 
            // text to Pig Latin and back. English 
            // is translated to Pig Latin by taking 
            // the first letter of every word, moving 
            // it to the end of the word and adding 
            // ‘ay’. “The quick brown fox” becomes 
            // “Hetay uickqay rownbay oxfay”.
            TranslateText();

        }

        static void TranslateText(){
            // Getting a text from user
            Console.BackgroundColor = ConsoleColor.Green;            
            Console.WriteLine("Insert a word you'd love to translate");
            Console.ResetColor();
            string text = Console.ReadLine();

            if(!(text == "")){
                // splitting and looping through each word
                string[] subs = text.Split(' ');
            
                foreach(var word in subs){
                    // removing the last char from each word
                    string remo = word.Remove(0, 1);
                    string subst = word.Substring(0, 1);   

                    //  adding the removed word to end inserting
                    // "ay" string 
                    string wrd = word.Remove(0, 1) + word.Substring(0, 1);
                    string finalwrd =  wrd.Insert(wrd.Length, "ay");            
                    Console.WriteLine("Translated word: "+ finalwrd);
                                
                }
            }
                        
        }
                   
    }
}
