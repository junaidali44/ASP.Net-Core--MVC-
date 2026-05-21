using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void MyMethod()
            {
                Console.WriteLine("I just got executed!");
            }

            static void Main(string[] args)
            {
                MyMethod();
            }

            // Outputs "I just got executed!"

        }
    }
}
