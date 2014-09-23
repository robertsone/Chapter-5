using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhippetBuss
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("How far did you go, in miles: ");
            int distance = Convert.ToInt32(System.Console.ReadLine());
            int[] miles = { 99, 299, 499, 9999999, 999999999 };
            int[] price = { 25, 40, 55, 70,70 };
            for (int num = 0; num < miles.Length; num++)
            {
                if (miles[num] < distance && distance<miles[num+1])
                {
                    int cost = price[num+1];
                    System.Console.Write(cost);
                    break;
                }
            }

            
        }

        
    }
}
