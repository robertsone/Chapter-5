using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeeBall
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] players;
            System.Console.WriteLine("How many people are on the team?");
            int length = Convert.ToInt32(System.Console.ReadLine()); 
            players = new int[length, 6];
            while (true)
            {

                System.Console.WriteLine("Please enter new player number to add update player info, or type 999 to exit");
                int num = Convert.ToInt32(System.Console.ReadLine());
                if (num == 999)
                    break;
                System.Console.WriteLine("How many bases did they run?");
                int bases = Convert.ToInt32(System.Console.ReadLine());
                if (bases==0)
                    players[num,1] += 1;
                else if (bases==1)
                    players[num,2] += 1;
                else if (bases==2)
                    players[num,3] += 1;
                else if (bases==3)
                    players[num,4] += 1;
                else if (bases==4)
                    players[num,5] += 1;

            }
            System.Console.WriteLine("\n\n\n");
            for (int number = 0; number < length;number++)
            {
                System.Console.WriteLine("{0,8}{1,8}{2,8}{3,8}{4,8}{5,8}", players[number, 0], players[number, 1], players[number, 2], players[number, 3], players[number, 4], players[number, 5]);
            }

      

             
        }
    }
}
