using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate2DPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string[] input = Console.ReadLine().Split();
            double x = double.Parse(input[0]);
            double y = double.Parse(input[1]);
            double angle = double.Parse(input[2]);
            double centerX = double.Parse(input[3]);
            double centerY = double.Parse(input[4]);
            x -= centerX;
            y -= centerY;
            double resX = Math.Round(x * Math.Cos(angle) - y * Math.Sin(angle) + centerX, 1);
            double resY = Math.Round(x * Math.Sin(angle) + y * Math.Cos(angle) + centerY, 1);
            Console.Write("{0:f1} ", resX);
            Console.Write("{0:f1}", resY);
        }
    }
}
