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

                Console.WriteLine();
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

            Console.WriteLine();
            Console.WriteLine("Give me an angle, and I'll tell you which cardinal direction it points closest to. (0 or 360 degrees = North");
            Console.WriteLine("Please input your angle now:");

            while(!Double.TryParse(Console.ReadLine().Trim(), out enteredAngle))
            {
                Console.WriteLine("That is not a valid response, please input a proper angle:");
            }

            actualAngle = enteredAngle % 360;          

            if (actualAngle < 0)
            {
                actualAngle += 360;
            }

            if (enteredAngle < 0 || enteredAngle > 360)
            {
                Console.WriteLine($"You entered {enteredAngle} degrees. That is equivalent to {actualAngle} degrees");
            }

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
            else if (actualAngle > 45 && actualAngle < 135)
            {
                Console.WriteLine("That's closest to East.");
            }
            else if (actualAngle > 135 && actualAngle < 225)
            {
                Console.WriteLine("That's closest to South.");
            }
            else if (actualAngle > 225 && actualAngle < 315)
            {
                Console.WriteLine("That's closest to West.");
            }
        }

        public static void ParkingGarage()
        {
            double minutes, hours;

            Console.WriteLine();
            Console.WriteLine("Welcome to the digital parking meter.");
            Console.WriteLine("How many minutes will you be staying for:");

            while (!Double.TryParse(Console.ReadLine().Trim(), out minutes) || minutes < 0)
            {
                Console.WriteLine("That is not a valid input, please input a proper value:");
            }

            hours = Math.Ceiling(minutes / 60);

            Console.WriteLine($"You will be charged for {hours} hours.");

            if (hours == 1)
            {
                Console.WriteLine("Your bill is $4.00");
            }
            else if (hours == 2)
            {
                Console.WriteLine("Your bill is $6.00");
            }
            else if (hours == 3)
            {
                Console.WriteLine("Your bill is $8.00");
            }
            else if (hours == 4)
            {
                Console.WriteLine("Your bill is $10.00");
            }
            else if (hours == 5)
            {
                Console.WriteLine("Your bill is $12.00");
            }
            else if (hours == 6)
            {
                Console.WriteLine("Your bill is $14.00");
            }
            else if (hours == 7)
            {
                Console.WriteLine("Your bill is $16.00");
            }
            else if (hours == 8)
            {
                Console.WriteLine("Your bill is $18.00");
            }
            else if (hours >= 9)
            {
                Console.WriteLine("Your bill is $20.00");
            }

        }

        public static void Hurricane()
        {

        }













    }
}
