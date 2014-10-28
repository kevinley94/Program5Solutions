using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();

            int myAgeDouble = DoubleIt(20);
            Console.WriteLine(DoubleIt(myAgeDouble));
            LoopTests();
            //keep the console open
            Console.ReadLine();
        }

        /// <summary>
        /// Writes "Hello World!" to the console
        /// </summary>
        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
        static int DoubleIt(int someNumber)
        {
            return someNumber * 2;
        }
        /// <summary>
        /// prints numbers to the console from start to the end
        /// </summary>
        /// <param name="startNumber">number the loops starts at</param>
        /// <param name="endNumber">inclusive end point of the loop</param>
        static void LoopSomeNumbers(int startNumber, int endNumber)
        {
            for (int i = startNumber; i <= endNumber; i = i + 1)
            {
                Console.WriteLine(i);
            }


        }
        static void LoopTests()
        {
            LoopSomeNumbers(5, 10);
            LoopSomeNumbers(23333, 33333);
            LoopSomeNumbers(31, DoubleIt(DoubleIt(31)));
        }
        /// <summary>
        /// retruns the number of vowels in a string
        /// </summary>
        /// <param name="inputString">a string that you want to count the number of vowels</param>
        /// <returns>the number of vowels found</returns>
        static int VowelCounter3000(string inputString)
        {
            // declare a variable to count values
            int numberOfVowelsFound = 0;
            //loop over each letter of the string
            //use for loops for strings
            for (int i = 0; i < inputString.Length; i = i + 1)
            {
                //take a letter from the string and make it lowercase
                string letter = inputString[i].ToString().ToLower();
                if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
                {
                    //fouund a vowel
                    numberOfVowelsFound = numberOfVowelsFound + 1; //so whenever it finds a lower case letter from above, it counts it.
                }
                //alternate way of checking to see if its a vowel
                if ("aeiou".Contains(letter));

            }
                //loop complete, time to write the output
            Console.WriteLine(inputString + " has " + numberOfVowelsFound + " vowels in it");
            return numberOfVowelsFound;
        }
        static void VowelCounter3000Tests()
        {
            //count the number of vowels counted
            int totalNumberOfVowelsCounted = 0;
            totalNumberOfVowelsCounted += VowelCounter3000("Jackie seems like a guy who might like Nickleback");
            totalNumberOfVowelsCounted += VowelCounter3000("I love to eat instant mashed potatoes.");
            Console.WriteLine("Total Vowels Counted: " + totalNumberOfVowelsCounted);
        }

    }
}//End of namespace
