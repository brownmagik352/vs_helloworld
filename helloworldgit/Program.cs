using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; //need this for ArrayList
//extra comment to test branch committing
namespace helloworldgit
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = { "James", "Dean", "robert" };
            Array.Sort(names);
            printNames(names);
            Array.Reverse(names);
            printNames(names);

            Console.ReadLine();
        }

        static void printNames(params string[] titles)
        {
            foreach (string name in titles)
            {
                Console.WriteLine(name);
            }
        }

        
    }
}
