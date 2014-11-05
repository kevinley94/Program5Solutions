using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupPicker
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Random rng = new Random();
            List<int> classList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            List<int> groupList = new List<int>();

            
    // so long as there is a number in the classsList, the loop will keep going.
           while (classList.Count > 0)
            {
               //pulls a random number from classList
                int i = rng.Next(0, classList.Count);
               //aStudent assigns that number an index for the list
                int aStudent = classList[i];
                // remove the indexed student and add him to groupList
                   classList.Remove(aStudent);
                   groupList.Add(aStudent);
               //once group list is four..
                    if(groupList.Count == 4)
                    {
                        //it will print out the people in th group
                       Console.WriteLine("Group: \n {0} {1} {2} {3}" , groupList[0], groupList [1], groupList[2], groupList [3]);
                        //this will clear it out so the loop can begin again with the people left
                       groupList.Clear();
                }
                    
            } Console.ReadKey();

           
 

        }
        
    }
}
