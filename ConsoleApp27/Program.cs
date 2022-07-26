using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        int x, y;

        public Program()
        {
            x = 100;
            y = 175;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.x);
            Console.WriteLine(p.y);
            Console.ReadLine();
        }
    }
}
