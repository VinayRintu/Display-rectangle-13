using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_rectangle_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int a=int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}",a);
            Console.WriteLine("{0} {0}", a);
            Console.WriteLine("{0} {0}", a);
            Console.WriteLine("{0}{0}{0}", a);
            Console.ReadLine();
        }
    }
}
