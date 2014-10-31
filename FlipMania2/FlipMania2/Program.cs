using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipMania2
{
    class Program
    {
        static void Main(string[] args)
        {
            FlipCoins(100);
            //insert 3 blank lines between my output
            FlipForHeads(100);
            Console.WriteLine("\n\n\n");
                Console.ReadKey();
        }

        static void FlipCoins(int numberOfFlips)
        {
            //what data do we need to track
            int numberOfHeads = 0;
            int numberOfTails = 0;
            //random number gen. to flip a coin
            Random coinFlip = new Random();
            for (int i = 0; i < numberOfFlips; i = i + 1)
            {
                //flipping a coin
                int coin = coinFlip.Next(0, 2);
                if (coin == 1)
                {
                    // got a heads
                    numberOfHeads = numberOfHeads + 1;
                }
                else
                {
                    // got a tails
                    numberOfTails = numberOfTails + 1;
                }


            } //output goes where loop completes
            Console.WriteLine("We flipped " + numberOfFlips + " times.");
            Console.WriteLine("# of Tails: " + numberOfTails);
            Console.WriteLine("# of Heads: " + numberOfHeads);
        }
        static void FlipForHeads(int numberOfFlipsLookingFor)
        {
            //what data do we need?
            int numberOfHeadsFound = 0;
            int numberOfTotalFlips = 0;
            Random coinFlip = new Random();

            // now flip some coins

            while (numberOfHeadsFound != numberOfFlipsLookingFor)
            {
                //flip a coin
                int coinFlipResult = coinFlip.Next(0, 2);

                //was it a heads
                if (coinFlipResult == 0)
                {
                    //got a heads
                    numberOfHeadsFound = numberOfHeadsFound + 1;
                    
                }
                //flipped a coin, track it
                numberOfTotalFlips = numberOfTotalFlips + 1;

            }
            Console.WriteLine("It took us {0} flips to get {1} heads", numberOfTotalFlips, numberOfHeadsFound
                );

        }
    }
}
