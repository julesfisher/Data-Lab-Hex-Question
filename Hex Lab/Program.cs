using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hex_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = "0xFE";
            int hexint = Convert.ToInt32(hex, 16);
            Console.WriteLine(hexint);
        }
    }
}
