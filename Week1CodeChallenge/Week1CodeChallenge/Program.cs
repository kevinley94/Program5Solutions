using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for (int j= 1; j <= 10; j = j + 1) 
            {
                IsPrime(j);
            }

                for (int i = 0; i <= 20; i++)
                {
                    FizzBuzz(i);
                }
            for (int i = 92; i >= 79; i = i - 1)
            {
                FizzBuzz(i);
            }
            Yodaizer("I like code");
            Yodaizer2("May the force be with you.");
            TextStats("Here we go. Hope this works. Fingers crossed.");
            DashInsert(1835709);
                Console.ReadKey();
        }
        static void FizzBuzz(int number)
        {
            // if the number is divisble by 5 & 3, it will print out "FizzBuzz" to the console
            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else { Console.WriteLine(number); }
        }
        static void Yodaizer(string text)
        {
           
            string[] words = text.Split(' ');
            // .reverse will reverse the order.
            // its "parameter" is the name of whatever you're trying to reverse
            Array.Reverse(words);
            // the String.Join method takes two "parameters". the second is what you are trying to join together into a string, 
            //in this case, an array named words. The first parameter is what it will join the values of the array with.
            Console.WriteLine(string.Join(" ", words));

            
        }
        //the way Dustin did it:
        static void Yodaizer2(string text)
        {
            List<string> wordList = text.Split(' ').ToList();
            for (int i = wordList.Count(); i >= 0; i = i - 1)
                {
                    //remove characters
                    // .Replace(thing to be replaced, thing that replaces it
                    //get the current word from the list
                    string currentWord = wordList[i];
                    Console.Write(currentWord + " ");
                }
                //add a blank line after the loop completes
                Console.WriteLine();
            }
        static void TextStats(string input)
        {
            string[] words = input.Split(' ');
            
            Console.WriteLine("Number of characters: " + input.Length);
            Console.WriteLine("Number of words: " + words.Count());// use .length for arrays
            int numberOfVowels = 0;
            int numberOfConsonants = 0;
            int numberOfSpecial = 0;
            // we'll be doing a for loop since we know that we just want to go through the letters in a word or phrase
            // to get the vowels and consonants out of it
            for (int i = 1; i < input.Count(); i++)
            {
                
                // this checks for the index of whatever input is, converts it to a string, and makes it lowercase
                //so we can use the if statement to see if its a vowel
                string letter = input[i].ToString().ToLower();
                if (letter == "a" | letter == "e" | letter == "i" | letter == "o" | letter == "u")
                {
                    numberOfVowels= numberOfVowels + 1;
                }
                // same function as above except for spaces, periods and question marks
                else if (letter == " " || letter == "." || letter == "?")
                {
                    numberOfSpecial = numberOfSpecial + 1;
                }

                else
                    //since the vowels were already being checked , every other letter is a consonant
                    //which will be added to the counter
                {
                    numberOfConsonants = numberOfConsonants + 1;
                }


            } 
            Console.WriteLine("Number of Special Characters: " + numberOfSpecial);
            Console.WriteLine("Number of Vowels: " + numberOfVowels);
            Console.WriteLine("Number of Consonants: " + numberOfConsonants);
        }
        // under development
        static void IsPrime(int number)
        {
            //sets a count for the number of devisors of a given number
            int devisors = 0;
            //checks all numbers up until the input number if its divisible
            for (int i = 1; i <= number; i++)

                if (number % i == 0)
                    //whenever it finds a number, counter goes up
                    devisors++;
            // it should only have 2 devisors..itself and 1
            if (devisors ==2)
                Console.WriteLine(number + " is prime");
            else
                //if it finds any more than ..or less than.. 2, it isn't a prime number
                Console.WriteLine(number);
             
       
        }
        static void IsPrime2(int number)
        {
            bool itsAPrime = true;
            for (int i = 2; i < number; i = i + 1)
            {
                if (number % i == 0)
                {
                    itsAPrime = false;
                    //its not a prime number , no need to keep checking
                    break;
                }
            }
            //output
            if (itsAPrime)
            {
                Console.WriteLine(number + " is a prime");
            }
            else
            {
                Console.WriteLine(number + " is not a prime");
            }
        }
       
        static void DashInsert(int number)
        {
            string numString = number.ToString();
            for (int i = 0; i < numString.Length - 1; i++)
               
            {
                
                if (numString[i] % 2 != 0)
                {Console.Write(numString[i]);


                    if (numString[i + 1] % 2 != 0)
                    {
                        Console.Write('-');

                    }
                    
                   
                } else { Console.Write(numString[i]); }

            } 
                }
        static void DashInsert2(int number)
        {
            //can't loop over each digit of a number
            //so convert to a string
            string numberString = number.ToString();
            //declare a string to hold the output
            //.empty lets you make a empty string
            string outputString = string.Empty;
            //loop over all digits except last one
            for (int i = 0; i < numberString.Length - 1; i = i + 1)
            {//int parse allows something to be used as an integer, but can not function
                //on chars so must convert to string.
                int currentDigit = int.Parse(numberString[i].ToString());
                int nextDigit = int.Parse(numberString[i + 1].ToString());
                if (currentDigit % 2 != 0 && nextDigit % 2 != 0)
                {
                    outputString = outputString += currentDigit + "-";
                }
                else
                {
                    outputString = currentDigit.ToString();
                }
                Console.WriteLine("Original: " + numberString);
                Console.WriteLine("Finished: " + outputString);
            }
        }
            } 


           

        }

  
   