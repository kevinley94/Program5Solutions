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
            PickGroups(2, 20);
        }

        static void PickGroups(int groupSize, int classSize)
        {
            Random rng = new Random();
            List<int> classList = new List<int>{classSize};
            List<int> groupList = new List<int>(groupSize);

            
   
           while (classList.Count > 0)
            {
                int i = rng.Next(0, classSize + 1);
                int aStudent = classList[i];
                
                    classList.Remove(aStudent);
                   groupList.Add(aStudent);
                    if(groupList.Count == groupSize)
                    {
                       Console.WriteLine();
                }
                    
            }


 

        }
        
    }
}
