using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Will 1", "Will 2", "Ethan, Adam, Ben Hudson, Tom, Cormac R, Ashton, Henry J, Mr. Dring" };
            names.Add("Tom");

            for (int i = 0; i < names.Capacity; i++)
            {
                Console.WriteLine(names[i]);
            }
            


        }
    }
}
