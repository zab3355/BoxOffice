using System;

namespace SanboxUnionTickets
{

    /*
     * author: Zach Brown
     * Box Office Simulator
    */
    class Program
    {
        static void Main(string[] args)
        {

            //define tickets and ticket quantity
            int ticket1 = 0;
            int ticket2 = 0;
            int ticket3 = 0;
            int ticket4 = 0;
            int ticket5 = 0;

            int ticketQuantity1 = 100;
            int ticketQuantity2 = 150;
            int ticketQuantity3 = 120;
            int ticketQuantity4 = 130;
            int ticketQuantity5 = 110;

            //define the sum
            int sum;

            //for loop to ask user for valid tickets, loop will continue until there's a valid ticket number
            for (int i = 0; i < 10; i++)
            {
            //Enter movie name
            Console.WriteLine("Enter the theater you'd like admission to:\n");

            // Create a string variable and get user input and store movieName
            string movieName = Console.ReadLine();

                if (movieName == "theater1")
                {
                    Console.WriteLine("\nEnter number of tickets, there are " + ticketQuantity1 + " left:\n ");

                    ticket1 = Convert.ToInt32(Console.ReadLine());

                    sum = ticketQuantity1 - ticket1;

                    if (ticket1 > ticketQuantity1)
                    {
                        Console.Write("\nYou cannot purchase more tickets than available! Try again!\n");
                        i = 0;
                    }
                    else
                    {
                        Console.Write("\nAmount of tickets for theater 1:\n " + sum);

                        ticketQuantity1 = sum;

                        i = 10;
                    }
                }
                else if (movieName == "theater2")
                {
                    Console.WriteLine("\nEnter number of tickets, there are " + ticketQuantity2+ " left:\n ");

                    ticket2 = Convert.ToInt32(Console.ReadLine());

                    sum = ticketQuantity2 - ticket2;

                    Console.Write("\nThere are " + ticketQuantity2 + " remaining.\n");

                    if (ticket2 > ticketQuantity2)
                    {
                        Console.Write("\nYou cannot purchase more tickets than available! Try again!\n");
                        i = 0;
                    }
                    else
                    {
                        Console.Write("\nAmount of tickets for theater 2:\n " + sum);
                        ticketQuantity2 = sum;
                        i = 10;
                    }
                }

                else if (movieName == "theater3")
                {
                    Console.WriteLine("\nEnter number of tickets, there are " + ticketQuantity3 + " left:\n ");

                    ticket3 = Convert.ToInt32(Console.ReadLine());

                    sum = ticketQuantity3 - ticket3;

                    Console.Write("\nThere are " + ticketQuantity3 + " remaining.\n");

                    if (ticket3 > ticketQuantity3)
                    {
                        Console.Write("\nYou cannot purchase more tickets than available! Try again!\n");
                        i = 0;
                    }
                    else
                    {
                        Console.Write("\nAmount of tickets for theater 3:\n " + sum);
                        ticketQuantity3 = sum;
                        i = 10;
                    }
                }

                else if (movieName == "theater4")
                {
                    Console.WriteLine("\nEnter number of tickets, there are " + ticketQuantity4 + " left:\n ");

                    ticket4 = Convert.ToInt32(Console.ReadLine());

                    sum = ticketQuantity4 - ticket4;

                    Console.Write("\nThere are " + ticketQuantity4 + " remaining.\n");

                    if (ticket4 > ticketQuantity4)
                    {
                        Console.Write("\nYou cannot purchase more tickets than available! Try again!\n");
                        i = 0;
                    }
                    else
                    {
                        Console.Write("\nAmount of tickets for theater 4:\n " + sum);
                        ticketQuantity4 = sum;
                        i = 10;
                    }
                }

                else if (movieName == "theater5")
                {
                    Console.WriteLine("\nEnter number of tickets, there are " + ticketQuantity5 + " left:\n ");

                    ticket1 = Convert.ToInt32(Console.ReadLine());

                    sum = ticketQuantity5 - ticket5;

                    Console.Write("\nThere are " + ticketQuantity5 + " remaining.\n");

                    if (ticket5 > ticketQuantity5)
                    {
                        Console.Write("\nYou cannot purchase more tickets than available! Try again!\n");
                        i = 9;
                    }
                    else
                    {
                        Console.Write("\nAmount of tickets for theater 5:\n " + sum);
                        ticketQuantity5 = sum;
                        i = 10;
                    }
                }

                else
                {
                    Console.Write("\nTheater name provided not valid.\n");
                    Environment.Exit(0);
                }
            }

            //individual reports
            Console.WriteLine("\nWhich theater do you wish to see a report for? ");

            string movieReport = Console.ReadLine();

            if (movieReport == "theater1")
            {
                Console.WriteLine("\nTickets purchased: \n" + ticket1);
            }
            else if (movieReport == "theater2")
            {
                Console.WriteLine("\nTickets purchased: \n" + ticket2);
            }
            else if (movieReport == "theater3")
            {
                Console.WriteLine("\nTickets purchased: \n" + ticket3);
            }
            else if (movieReport == "theater4")
            {
                Console.WriteLine("\nTickets purchased: \n" + ticket4);
            }
            else if (movieReport == "theater5")
            {
                Console.WriteLine("\nTickets purchased: \n" + ticket5);
            }

            Console.WriteLine("\nWould you like to see the full report for all tickets remaining? Please state Y for yes, enter for no: \n ");

            string answer = Console.ReadLine();

            //total report
            if (answer == "y")
            {
                Console.WriteLine("Tickets Remaining in Stock: \n" + "theater1:" + ticketQuantity1 + ", theater2: " + ticketQuantity2 + ", theater3: " + ticketQuantity3 + ", theater4: " + ticketQuantity4 + ", theater5:" + ticketQuantity5);
                Environment.Exit(0);
            }
                Environment.Exit(0);
            }
        }
    }
