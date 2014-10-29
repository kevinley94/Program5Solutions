using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = ("Jackie");
            Console.WriteLine("My name is " + myName + " and I'm a beast of a programmer");
            int myAge = (20);
            Console.WriteLine("I am " + myAge + " years awesome!");
            bool myBool = true;
            Console.WriteLine("I set my boolean value equal to " + myBool);
            Console.ReadKey();
            List<string> productsList = new List<string>() { "baskeball", "baseball glove", "tennis shoes", "hockey puck" };
            // loop that prints out the strings in productsList
            for (int i = 0; i < productsList.Count; i++)
            {

                Console.WriteLine(productsList[i]);
       
                }
            Console.ReadKey();
            // Loop that counts from 1 to 10 by 1's
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);

            }
            Console.ReadKey();
            // Loop that counts down from 10 to 1 by 1's
            for (int i = 10; i >= 1; i = i - 1)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            // Loop that starts at 10, counts to 30, but only even numbers
            for (int i = 10; i <=30; i = i + 2)
            {
                Console.WriteLine(i);

            }
            Console.ReadKey();
            // loop starts at 100 and counts down to 75 by 5's
            for (int i = 100; i >= 75; i = i - 5)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            //counts from 1 up to 10
            int j=1;
            while (j <= 10){
                Console.WriteLine(j);
                j = j + 1;
            }
            Console.ReadKey();
            //counts from 10 down to 1
            j= 10;
                while (j >=1){
                    Console.WriteLine(j);
                    j = j - 1;
                }
                Console.ReadKey();
            //counts from 15 up to 30 by even numbers
                j = 15;
                while (j <= 30)
                {
                    Console.WriteLine(j);
                    j = j + 3;
                }
                Console.ReadKey();
            //counts down from 100 to 75 by 5's
            j = 100;
                while (j >= 75)
                {
                    Console.WriteLine(j);
                    j = j - 5;
                }
                Console.ReadKey();
            //once the loop catches a number that divides into 4 with no remainders,
            //it changes myBool from true to false and stops
                j = 1;
                while (myBool)
                {
                    if (j % 4 == 0)
                    {
                        myBool = false;
                        Console.WriteLine(myBool);
                    }
                    else
                    {
                        Console.WriteLine(j);
                        j++;
                    }
                    

                }
            Console.ReadKey();
            Console.WriteLine("My name, " + myName + ", has " + myName.Length + " letters in it.");
            Console.ReadKey();
            Console.WriteLine("My product list has " + productsList.Count + " items in it.");
            Console.ReadKey();
            //names how many letters are in the words of productsList. Counts one line at a time.
            for (int l = 0; l <
                productsList.Count; l++)
            {
                Console.WriteLine(productsList[l] + " has " + productsList[l].Length + " letters in it.");
               
            }
            //called functions brought to the main console
            Console.ReadKey();
            Greeting("Beef Hardchest");
            Greeting(myName);
            DoubleIt(1337);
            DoubleIt(myAge);
            Multiply(2, 8);
            Multiply(3, myAge);
            LoopThis(20, 30);
            LoopThis(0, myAge);
            SuperLoop(0, 100, 15);
            SuperLoop(0, 200, myAge);
            Console.WriteLine(newGreeting("Neil deGrasse-Tyson"));
            Console.WriteLine(newGreeting(myName));
            Console.WriteLine("10 tripled is " + (TripleIt(10)));
            Console.WriteLine(myAge + " tripled is " + (TripleIt(myAge)));
            Console.WriteLine(RealMultiply(5, 10));
            Console.WriteLine(RealMultiply(2, myAge));
            SuperLoop(RealMultiply(1, 5), TripleIt(myAge), TripleIt(myAge - 10));
            SuperLoop(RealMultiply(1, TripleIt(3)), TripleIt(RealMultiply(myAge, 7)),TripleIt(myAge - RealMultiply(2, 4)));
            Console.ReadKey();
            


        }
        /// <summary>
        /// Says Hello to a name
        /// </summary>
        /// <param name="name">A name</param>
        static void Greeting(string name)
        {
            Console.WriteLine("Hello " + name);
            Console.ReadKey();
        }
        /// <summary>
        /// Multiplies a number by two
        /// </summary>
        /// <param name="number">a number to multiply</param>
        static void DoubleIt(int number)
        {
            Console.WriteLine(number + " doubled is " + number * 2);
            Console.ReadKey();
        }
        /// <summary>
        /// Multiply two numbers together
        /// </summary>
        /// <param name="num1">a number to multiply</param>
        /// <param name="num2">another number to multiply</param>
        static void Multiply(int num1, int num2)
        {
            Console.WriteLine(num1 + " times " + num2 + " is " + num1 * num2);
            Console.ReadKey();
        }
        /// <summary>
        /// Loop from starting number to ending number
        /// </summary>
        /// <param name="startNum">number loop starts at</param>
        /// <param name="endNum">number loop ends at</param>
        static void LoopThis(int startNum, int endNum)
        {
            Console.WriteLine("I'm looping from " + startNum + " to " + endNum + ".");
           
            for (int m = startNum; m <= endNum; m++)
            {
                Console.WriteLine(m);
                
            }
            Console.ReadKey();
           
        }
        /// <summary>
        /// Loops start number to end number by different increments, then tracks the amount of loops before starting number becomes end number
        /// </summary>
        /// <param name="startNum">the starting number</param>
        /// <param name="endNum">the ending number</param>
        /// <param name="increment">amount the starting number increases by</param>
        static void SuperLoop(int startNum, int endNum, int increment)
        {
            int loopCount = 0;
            Console.WriteLine("I'm looping from " + startNum + " to " + endNum + ", incrementing " + increment + " each time");
                for ( int n= startNum; n <= endNum ; n= n + increment){ 
                    loopCount= loopCount +1;
                    
                }
            Console.WriteLine("That loopCount was craaaaaaazy, we looped " + loopCount + " times!");
                    Console.ReadKey();

        }
        /// <summary>
        /// says hello to a name
        /// </summary>
        /// <param name="name">a name</param>
        /// <returns></returns>
        static string newGreeting(string name)
        {
            return ("Hello, " + name);
            

        }
        /// <summary>
        /// takes a number and multiplies it by 3
        /// </summary>
        /// <param name="number">a number to multiply</param>
        /// <returns></returns>
        static int TripleIt(int number)
        {
            return number * 3;
        }
        /// <summary>
        /// takes two numbers and multiplies them, then prints result with no additional sentences
        /// </summary>
        /// <param name="num1">a number to multiply</param>
        /// <param name="num2">another number to multiply</param>
        /// <returns></returns>
        static int RealMultiply(int num1, int num2)
        {
            return num1 * num2;
        }
        }
    }
   
       


