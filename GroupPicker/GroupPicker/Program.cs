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

            
   
           while (classList.Count > 0)
            {
                int i = rng.Next(0, classList.Count);
                int aStudent = classList[i];
                
                   classList.Remove(aStudent);
                   groupList.Add(aStudent);

                    if(groupList.Count == 4)
                    {
                       Console.WriteLine("Group: \n {0} {1} {2} {3}" , groupList[0], groupList [1], groupList[2], groupList [3]);
                       groupList.Clear();
                }
                    
            } Console.ReadKey();

           
 

        }
        
    }
}
