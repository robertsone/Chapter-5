using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckZips
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]Zips={111,222,333,444,555,666,777,888,999,101010};
            System.Console.Write("Enter zip: ");
            int delivery = Convert.ToInt32(System.Console.ReadLine());
            for (int num = 0; num < Zips.Length; num++)
            {
                if (Zips[num] == delivery)
                {
                    System.Console.WriteLine("we know were that is");
                }
            }
         
        }
    }
}
