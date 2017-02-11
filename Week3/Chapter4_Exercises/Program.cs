using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = 0;

            Console.WriteLine("Robertson Software Suite: 2017 Edition\r\n");
            Console.WriteLine("Enter the number of the software you want to use:");
            Console.WriteLine(
                "1) Circumference Calculator\r\n" +
                "2) Square Root Calculator\r\n" +
                "3) £ and $ Converter");

            if (int.TryParse(Console.ReadLine(), out selection))
            {
                Console.WriteLine();
                switch (selection)
                {
                    case 1:
                        ch4ex14();
                        break;
                    case 2:
                        ch4ex16();
                        break;
                    case 3:
                        ch4ex20();
                        break;
                }
            }

            Console.WriteLine("Thank you for trying this software.");
            Console.ReadKey();
        }

        //Chapter 4 Exercise 14

        static void ch4ex14()
        {
            double radius = 0;
            double diameter = 0;
            double circumference = 0;

            Console.WriteLine("Welcome to Circumference Calculator: 2017 Edition!\r\n");
            Console.WriteLine("Type \"-1\" to quit.\r\n");

            while (radius != -1)
            {
                Console.WriteLine("Please enter the radius: ");
                if (double.TryParse(Console.ReadLine(), out radius))
                {
                    //Exit application
                    if (radius == -1)
                    {
                        return;
                    }

                    diameter = radius * 2;
                    circumference = diameter * Math.PI;
                    Console.WriteLine("The circumference is {0:0.00}\r\n", circumference);
                }
                else
                {
                    Console.WriteLine("Error.  Please try again.");
                }
            }
        }

        //Chapter 4 Exercise 16

        static void ch4ex16()
        {
            double average = 0;
            double oldEstimate = 1;
            double newEstimate = 1;
            double inputNum = 0;

            Console.WriteLine("Welcome to Square Root Calculator: 2017 Edition!\r\n");
            Console.WriteLine("Type \"-1\" to quit.\r\n");

            while (inputNum != -1)
            {
                oldEstimate = 1;
                newEstimate = 1;

                Console.WriteLine("Please enter the number: ");
                if (double.TryParse(Console.ReadLine(), out inputNum))
                {
                    //Exit application
                    if (inputNum == -1)
                    {
                        return;
                    }

                    for (int i = 1; i < 11; i++)
                    {
                        newEstimate = inputNum / oldEstimate;
                        Console.WriteLine("Estimate {0}: {1}", i, oldEstimate);
                        average = (newEstimate + oldEstimate) / 2;
                        Console.WriteLine("Average {0}: {1}", i, average);
                        oldEstimate = average;
                    }

                    Console.WriteLine("\r\nFinal estimate: {0}", average);
                    Console.WriteLine("Actual square root: {0}\r\n", Math.Sqrt(inputNum));
                }
                else
                {
                    Console.WriteLine("Error.  Please try again.");
                }
            }
        }

        //Chapter 4 Exercise 20

        static void ch4ex20()
        {
            int selection = 0;

            //Exchange rate equals x for each 1
            //Ex. britishExchangeRate = 1.6595 dollars for each 1.00 pound
            //Ex. usExchangeRate = 0.6026 pounds for each 1.00 dollar
            double britishPounds = 0;
            double britishExchangeRate = 1.6595;
            double usDollars = 0;
            double usExchangeRate = 1 / britishExchangeRate;
            char dollarSymbol = '$';
            char poundSymbol = '£';

            Console.WriteLine("Welcome to British and US Currency Converter: 2017 Edition!\r\n");
            Console.WriteLine("Type \"-1\" to quit.\r\n");

            Console.WriteLine(
                "1) Convert £ to $\r\n" +
                "2) Convert $ to £\r\n");

            while (selection != -1)
            {
                if (int.TryParse(Console.ReadLine(), out selection))
                {
                    Console.WriteLine();
                    switch (selection)
                    {
                        case -1:
                            break;
                        case 1:
                            britishPounds = acceptInput();
                            usDollars = convertCurrency(britishPounds, britishExchangeRate);
                            displayOutput(poundSymbol, britishPounds, dollarSymbol, usDollars);
                            break;
                        case 2:
                            usDollars = acceptInput();
                            britishPounds = convertCurrency(usDollars, usExchangeRate);
                            displayOutput(dollarSymbol, usDollars, poundSymbol, britishPounds);
                            break;
                    }
                    Console.WriteLine(
                        "1) Convert £ to $\r\n" +
                        "2) Convert $ to £\r\n");
                }
            }
        }

        static double convertCurrency(double money, double exchangeRate)
        {
            return money / exchangeRate;
        }

        static double acceptInput()
        {
            double output = 0;
            bool validInput = false;
            while (validInput == false)
            {
                Console.WriteLine("Enter the amount to convert:");
                if (double.TryParse(Console.ReadLine(), out output))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.\r\n");
                    validInput = false;
                }
            }
            return output;
        }

        static void displayOutput(char symbol1, double money1, char symbol2, double money2)
        {
            Console.WriteLine("{0}{1:0.00} = {2}{3:0.00}\r\n", symbol1, money1, symbol2, money2);
        }
    }
}
