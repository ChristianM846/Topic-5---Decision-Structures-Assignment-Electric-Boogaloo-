namespace Topic_5___Decision_Structures_Assignment__Electric_Boogaloo_
{
    //Christian Moyes
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            string doneChoice;
            bool done = false;

            while (!done)
            {
                Console.WriteLine("Which program would you like to run?");
                Console.WriteLine();
                Console.WriteLine("1 - Compass Bearings");
                Console.WriteLine("2 - Parking Garage Cost");
                Console.WriteLine("3 - Hurricane");
                Console.WriteLine();
                Console.WriteLine("Input the number corresponding to your choice:");

                while (!Int32.TryParse(Console.ReadLine().Trim(), out choice) || choice != 1 && choice != 2 && choice != 3)
                {
                    Console.WriteLine("That is not a valid input. Please input the number of the program you wish to run.");
                }

                if (choice == 1)
                {
                    CompassBearings();
                }
                else if (choice == 2)
                {
                    ParkingGarage();
                }
                else if(choice == 3)
                {
                    Hurricane();
                }

                Console.WriteLine("Would you like continue? (y/n)");

                doneChoice = Console.ReadLine().Trim().ToLower();

                while (doneChoice != "y" && doneChoice != "n")
                {
                    Console.WriteLine("That is not a valid response, please input y or n:");
                    doneChoice = Console.ReadLine().Trim().ToLower();
                }

                if (doneChoice == "y")
                {
                    Console.WriteLine("Okay!");
                    Console.WriteLine();
                }    
                else if (doneChoice == "n")
                {
                    done = true;
                    Console.WriteLine("Okay, goodbye");
                }
            }





        }

        public static void CompassBearings()
        {
            double enteredAngle, actualAngle;
            bool outsideRange = false;

            Console.WriteLine();
            Console.WriteLine("Give me an angle, and I'll tell you which cardinal direction it points closest to. (0 or 360 degrees = North");
            Console.WriteLine("Please input your angle now:");

            while(!Double.TryParse(Console.ReadLine().Trim(), out enteredAngle))
            {
                Console.WriteLine("That is not a valid response, please input a proper angle");
            }

            actualAngle = enteredAngle;

            if (enteredAngle < 0 || enteredAngle > 360)
            {
                outsideRange = true;
            }

            while (actualAngle < 0)
            {
                actualAngle = actualAngle + 360;
            }

            while (actualAngle > 360)
            {
                actualAngle = actualAngle - 360;
            }

            if (!outsideRange)
            {
                if (actualAngle == 0 || actualAngle == 360)
                {
                    Console.WriteLine("That's perfectly North!");
                }
                else if (actualAngle == 90)
                {
                    Console.WriteLine("That's perfectly East!");
                }
                else if (actualAngle == 180)
                {
                    Console.WriteLine("That's perfectly South!");
                }
                else if (actualAngle == 270)
                {
                    Console.WriteLine("That's perfectly West!");
                }
                else if (actualAngle == 45)
                {
                    Console.WriteLine("That's perfectly between North and East. It's Northeast!");
                }
                else if (actualAngle == 135)
                {
                    Console.WriteLine("That's perfectly between South and East. It's Southeast!");
                }
                else if (actualAngle == 225)
                {
                    Console.WriteLine("That's perectly between South and West. It's Southwest!");
                }
                else if (actualAngle == 315)
                {
                    Console.WriteLine("That's perfectly between North and West. It's Northwest!");
                }
                else if (actualAngle > 315 || actualAngle < 45)
                {
                    Console.WriteLine("That's closest to North.");
                }

            }





        }

        public static void ParkingGarage()
        {

        }

        public static void Hurricane()
        {

        }













    }
}
