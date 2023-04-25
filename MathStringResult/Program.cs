using System;
using System.Data;

namespace MathStringResult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable();
            var Statement = dt.Compute("3*2+4-4/2", "");
            Console.WriteLine("Result is: " + Statement);
        }
    }
}
