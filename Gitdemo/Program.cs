using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gitdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(add(3,3));
        }
        public static int add(int a, int b)
        {
            int c;
            c = a + b;
            return c;
        }
    
    }
}
