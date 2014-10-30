using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzzpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            fizzBuzz(1, 30);
            lettersInWord("e" , "Kevin");
            Console.WriteLine();
            Console.ReadKey();
          
        }
        static void fizzBuzz(int startNum, int endNum){
          for(int i= startNum; i <=endNum; i++){
              if (i % 3 ==0 && i % 5 ==0){
                  Console.WriteLine("FizzBuzz");
                  
              }
              else if (i % 3==0){
                  Console.WriteLine("Fizz");
              }
              else if (i % 5==0){
                  Console.WriteLine("Buzz");
              }
              else Console.WriteLine(i);
          }

            Console.ReadKey();
           
        }
        static void lettersInWord(string letterLookedFor, string word)
        {
            int letterCount = 0;
            for (int i = 0; i < word.Length; i++)
            {
                //the index will find a letter in the word
                // it comes as a char, since its only 1 character
                //the .tostring converts it to a string
                //.tolower makes it lower case
                string letter = word[i].ToString().ToLower();
                if (letter == letterLookedFor)
                {
                    letterCount = letterCount + 1;
                    

                }
                
                }Console.WriteLine(word + " has " + letterCount + " " +  letterLookedFor + " in it.");
                Console.ReadKey();
            }
        }
    }
   

    

