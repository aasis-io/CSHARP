// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic
{
    internal class Program
    {
        static void Main(String[] args)
        {
            int x, y, a;
            Console.WriteLine("Enter length of rectangle:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width of rectangle:");
            y = Convert.ToInt32(Console.ReadLine());
            a = x * y;
            Console.WriteLine("Area=" + a.ToString());
        }
    }
    
}

