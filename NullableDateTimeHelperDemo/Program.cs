using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableDateTimeHelperDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var d = new DateTime();
            //DateTime? d = DateTime.Now;
            DateTime d = DateTime.Now;

            Console.WriteLine("d = "+d);

            //Console.WriteLine("d.DateOnly=" + d.DateOnly);
            Console.WriteLine("d.DateOnly = " + d.DateOnly());

            DateTime? nd = DateTime.Now;
            Console.WriteLine("nd.DateOnly = " + nd.NullableDateOnly());

            Console.ReadKey();
        }
    }
}
