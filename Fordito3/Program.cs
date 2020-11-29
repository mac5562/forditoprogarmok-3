using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fordito3
{
    class Program
    {
        static void Main(string[] args)
        {
            Automata a = new Automata("(31+233)*a+4");
            a.S();
            Console.ReadLine();
        }
    }
}
