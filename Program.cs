using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Created by Nicholas Robertson
 * January 18, 2017
*/

namespace GCU_ChickenHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            ChickenHouse sunnyDayFarm = new ChickenHouse();
            Chicken chicken1 = new Chicken();
            Chicken chicken2 = new Chicken();
            Chicken chicken3 = new Chicken();
            Chicken chicken4 = new Chicken();

            chicken1.setName(chicken1, "Sister");
            chicken2.setName(chicken2, "Beulah");
            chicken3.setName(chicken3, "Ms. Sassy");
            chicken4.setName(chicken4, "Crispy");

            sunnyDayFarm.spaces[0] = chicken1;
            sunnyDayFarm.spaces[1] = chicken2;
            sunnyDayFarm.spaces[3] = chicken3;
            sunnyDayFarm.spaces[5] = chicken4;

            Console.WriteLine("The chickens are in the following spaces:");
            Console.WriteLine("Sister is in space " + sunnyDayFarm.findChicken("Sister", sunnyDayFarm));
            Console.WriteLine("Beulah is in space " + sunnyDayFarm.findChicken("Beulah", sunnyDayFarm));
            Console.WriteLine("Ms. Sassy is in space " + sunnyDayFarm.findChicken("Ms. Sassy", sunnyDayFarm));
            Console.WriteLine("Crispy is in space " + sunnyDayFarm.findChicken("Crispy", sunnyDayFarm));

            sunnyDayFarm.consolidate(sunnyDayFarm);

            Console.WriteLine("\r\nAfter consolidation, the chickens are now in the following spaces:");
            Console.WriteLine("Sister is in space " + sunnyDayFarm.findChicken("Sister", sunnyDayFarm));
            Console.WriteLine("Beulah is in space " + sunnyDayFarm.findChicken("Beulah", sunnyDayFarm));
            Console.WriteLine("Ms. Sassy is in space " + sunnyDayFarm.findChicken("Ms. Sassy", sunnyDayFarm));
            Console.WriteLine("Crispy is in space " + sunnyDayFarm.findChicken("Crispy", sunnyDayFarm));

            Console.WriteLine("\r\nChicken Little is in space " + sunnyDayFarm.findChicken("Chicken Little", sunnyDayFarm));
            Console.WriteLine("Oh, right.  There is no Chicken Little in this house.");

            Console.ReadKey();
        }
    }

    public class Chicken
    {
        public string name;
        public int monthsOld;

        public Chicken()
        {
            name = "";
            monthsOld = 0;
        }

        string getName(Chicken chicken)
        {
            return chicken.name;
        }

        int getMonths(Chicken chicken)
        {
            return chicken.monthsOld;
        }

        public void setName(Chicken chicken, string name)
        {
            chicken.name = name;
        }

        public void setMonths(Chicken chicken, int monthsOld)
        {
            chicken.monthsOld = monthsOld;
        }
    }

    public class ChickenHouse
    {
        public Chicken[] spaces = new Chicken[6];

        public int findChicken(String name, ChickenHouse chickenHouse)
        {
            for (int i = 0; i < spaces.Length; i++)
            {
                try
                {
                    if (name == spaces[i].name)
                    {
                        return i;
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }

            return -1;
        }

        public ChickenHouse consolidate(ChickenHouse chickenHouse)
        {
            int nullCounter = 0;
            for (int i = 0; i < spaces.Length; i++)
            {
                try
                {
                    if(spaces[i] == null)
                    {
                        while (spaces[i] == null)
                        {
                            nullCounter++;
                            i++;
                        }
                        spaces[i - nullCounter] = spaces[i];
                        spaces[i] = null;
                    }

                }
                catch (Exception)
                {
                    continue;
                }
            }

            return chickenHouse;
        }
    }
}