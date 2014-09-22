using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatAWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zips = { 262,414,608,715,815,920};
            double[] price = { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };
            System.Console.Write("What is your area code: ");
            int area=Convert.ToInt32(System.Console.ReadLine());
            for (int num=0;num<zips.Length; num++)
            {
                if (area == zips[num])
                {
                    System.Console.Write("Your area code has been found, your cost is " + price[num] + " per hour");
                }
            }
        }
    }
}
