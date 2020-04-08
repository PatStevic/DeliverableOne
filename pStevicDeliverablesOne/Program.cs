using System;

namespace pStevicDeliverablesOne
{
    class Program
    {
        static string vacationType = "";
        static string transportationType = "";
        static string DestinationType = "";
        static string result = "";
        static int groupSize = 0;


        static void Main(string[] args)
        {
            Console.WriteLine("\nWhat kind of trip would you like to go on?\na) Musical\nb) Tropical\nc) Adventurous\n\nPlease enter a, b, or c, and hit enter.\n");

            string vacationResponse = Console.ReadLine();
            if (vacationResponse == "a")
            {
                vacationType = "musical";
            }

            else if (vacationResponse == "b")
            {
                vacationType = "tropical";
            }

            else if (vacationResponse == "c")
            {
                vacationType = "adventurous";
            }

            else if (vacationResponse != "a" || vacationResponse != "b" || vacationResponse != "c")
            {
                Console.WriteLine("Please only enter in a, b, or c");
                vacationType = Console.ReadLine();
            }

            try
            { 
            Console.WriteLine("What is the total number of people going on this vacation?");
            string groupSizeInput = Console.ReadLine();
            int numberOfFriendsComingAlong = int.Parse(groupSizeInput);
            groupSize = numberOfFriendsComingAlong - 1;
            }
            catch
            {
                Console.WriteLine("Please enter a number and not a letter");
                Console.WriteLine("What is the total number of people going on this vacation?");
                string groupSizeInput = Console.ReadLine();
                int numberOfFriendsComingAlong = int.Parse(groupSizeInput);
                groupSize = numberOfFriendsComingAlong - 1;
            }

            Console.WriteLine("\nDo you perfer taking the:\na) Helicopter\nb) Flight\nc) Cruise\n\nPlease enter a, b, or c, and hit enter.");
            string transportationResponse = Console.ReadLine();

            if (transportationResponse == "a")
            {
                transportationType = "Helicopter";
            }

            else if (transportationResponse == "b")
            {
                transportationType = "Flight";
            }

            else if (transportationResponse == "c")
            {
                transportationType = "Cruise";
            }

            else if (transportationResponse != "a" || transportationResponse != "b" || transportationResponse != "c")
            {
                Console.WriteLine("Please only enter in a, b, or c");
                transportationType = Console.ReadLine();
            }

            if (vacationResponse == "a")
            {
                DestinationType = "New Orleans";
            }

            else if (vacationResponse == "b")
            {
                DestinationType = "Beach Vacation in Mexico";
            }

            else if (vacationResponse == "c")
            {
                DestinationType = "Whitewater Rafting the Grand Canyon";
            }

            result = ("\nWell how about a " + vacationType + " trip to " + DestinationType + " for you and your " + groupSize + " friend(s). \nYou can take a " + transportationType + " there!");
            Console.WriteLine(result);
        }
    }
}
