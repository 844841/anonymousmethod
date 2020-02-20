using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymousmethod
{
    class Program
    {
        public delegate void Mydelg(string s);

        static void Main(string[] args)
        {

            //anonymous method
            Mydelg delgt = a => Console.WriteLine(a);
            delgt("hello");


        }
    }
}
