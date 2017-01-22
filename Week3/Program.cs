using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCU_Plinko
{
    class PlinkoBall
    {
        public int[] path { get; set; }
        public int slot { get; set; }
    }

    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            int totalBalls = 0;
            int totalSlots = 0;

            Console.WriteLine("Welcome to GCU Plinko!\r\n");

            //Get number of balls and slots
            Console.Write("Enter the number of balls to play: ");
            totalBalls = EnterNumber(totalBalls);
            Console.Write("\r\nEnter the number of slots at the bottom of the board: ");
            totalSlots = EnterNumber(totalSlots);

            Console.WriteLine("\r\nPlaying with {0} balls and {1} slots.", totalBalls, totalSlots);

            //Create list of plinko balls
            List<PlinkoBall> plinkoBalls = new List<PlinkoBall>();
            for (int i = 0; i < totalBalls; i++)
            {
                plinkoBalls.Add(new PlinkoBall());
            }

            foreach (PlinkoBall ball in plinkoBalls)
            {
                ball.path = GetPath(totalSlots);
                ball.slot = CountRights(ball.path);

                foreach (var item in ball.path)
                {
                    if(item == 0)
                    {
                        Console.Write('L');
                    }
                    else
                    {
                        Console.Write('R');
                    }
                    
                }
                Console.Write(": {0}", ball.slot);
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < totalSlots; i++)
            {
                Console.Write("{0}: ", i);
                foreach (var item in plinkoBalls)
                {
                    if (item.slot == i)
                    {
                        Console.Write('*');
                    }
                }
                Console.WriteLine();
            }

            //To keep console open
            Console.ReadKey();
        }

        static int EnterNumber(int totalVariable)
        {
            while (!(totalVariable > 1))
            {
                int.TryParse(Console.ReadLine(), out totalVariable);
                if (!(totalVariable > 1))
                {
                    Console.Write("Must enter a number higher than 1: ");
                }
            }
            return totalVariable;
        }

        static int[] GetPath(int totalSlots)
        {
            int[] path = new int[totalSlots - 1];

            //Cannot use foreach loop
            for (int i = 0; i < totalSlots-1; i++)
            {
                path[i] = random.Next(0, 2);
            }

            return path;
        }

        static int CountRights(int[] path)
        {
            //Count rights
            int totalRights = 0;

            foreach (var item in path)
            {
                if (item == 1)
                {
                    totalRights++;
                }
            }

            return totalRights;
        }
    }
}