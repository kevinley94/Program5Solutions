using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipMania
{
    class Program
    {
        static void Main(string[] args)
        {
            FlipCoins(10);
            FlipForHeads(10000);

            Console.ReadKey();
        }
        static void FlipCoins(int numberOfFlips)
        {
            int numberOfHeads = 0;
            int numberOfTails = 0;
            Random coinFlip= new Random();
            
            for( int i= 0; i <= numberOfFlips; i++)
            {
           int randomNumber= coinFlip.Next(0,2);
           if (randomNumber==1)
           {
               numberOfTails = numberOfTails + 1;
           }
           else {
               numberOfHeads = numberOfHeads + 1; }
           
           }Console.WriteLine("We flipped a coin " + numberOfFlips + " times.");
           Console.WriteLine("Number of Heads: " + numberOfHeads);
           Console.WriteLine("Number of Tails: " + numberOfTails);
            
Console.ReadKey(); 
        }
        static void FlipForHeads(int numberOfHeads)
        {
            int numberOfHeadsFlipped = 0;
            int totalFlips = 0;
            Random coinFlip = new Random();
            
            while (numberOfHeadsFlipped <= numberOfHeads)
            {
                int randomNumber = coinFlip.Next(0, 2);
                    totalFlips= totalFlips+1;
                    if (randomNumber == 1)
                    {
                        numberOfHeadsFlipped = numberOfHeadsFlipped + 1;
                    }
                

            }Console.WriteLine("We are flipping a coin until we find " + numberOfHeads + " heads");
                Console.WriteLine("It took " + totalFlips + " flips to find " + numberOfHeads + " heads");
            Console.ReadKey();
        } 

    } 
} 

